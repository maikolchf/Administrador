using AdministradorEntidades.Entidades;
using AdministradorEntidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administradorDAL
{
    public  class FacturasDAL
    {
        public Respuesta<Factura> InsertarModificar(Factura factura)
        {
            Respuesta<Factura> respuesta = new Respuesta<Factura>();
            try
            {

                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    if (factura.FacturaId.Equals(0))
                    {
                        dbContexto.Facturas.Add(factura.convertirObjetoInsertar(factura));
                        respuesta.Mensaje = "Registrado correctamente";
                    }
                    else
                    {
                        Modificar(factura);
                        respuesta.Mensaje = "Modificado correctamente";
                    }
                    dbContexto.SaveChanges();
                    respuesta.HayError = false;
                    respuesta.ObjetoRespuesta = factura;
                }
                
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new Factura();
            }
            return respuesta;
        }

        public Respuesta<List<Factura>>Obtener(Factura factura)
        {
            Respuesta<List<Factura>> respuesta = new Respuesta<List<Factura>>();
            try
            {

                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from item in dbContexto.Facturas
                                                 where (item.FacturaId == factura.FacturaId || factura.FacturaId == 0) &&
                                                       (item.EstadoFactura == factura.EstadoFactura || factura.EstadoFactura == string.Empty || factura.EstadoFactura == null)
                                                 select new Factura
                                                 {
                                                     FacturaId = item.FacturaId,
                                                     ConsecutivoFactura = item.ConsecutivoFactura,
                                                     EstadoFactura = item.EstadoFactura,
                                                     FechaRegistro = item.FechaRegistro,
                                                     MontoFactura = item.MontoFactura,
                                                     ProveedorFactura = item.ProveedorFactura,
                                                     Estado = (from E in dbContexto.Estados
                                                               where E.EstadoCodigo == item.EstadoFactura
                                                               select new Estado
                                                               {
                                                                   EstadoCodigo = E.EstadoCodigo,
                                                                   EstadoId = E.EstadoId,
                                                                   EstadoDescripcion = E.EstadoDescripcion
                                                               }).FirstOrDefault(),
                                                     Proveedor = (from P in dbContexto.Proveedores
                                                                  where P.ProveedorCodigo == item.ProveedorFactura
                                                                  select new Proveedor
                                                                  {
                                                                      ProveedorCodigo = P.ProveedorCodigo,
                                                                      ProveedorId = P.ProveedorId,
                                                                      ProveedorCedula = P.ProveedorNombre,
                                                                      ProveedorGastoFijo = P.ProveedorGastoFijo,
                                                                      ProveedorEstado = P.ProveedorEstado,
                                                                      ProveedorNombre = P.ProveedorNombre,
                                                                      ProveedorTelefono = P.ProveedorTelefono
                                                                  }).FirstOrDefault()
                                                 }).ToList();
                    respuesta.HayError = false;
                }

            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<Factura>();
            }
            return respuesta;
        }

        private Respuesta<Factura> Modificar(Factura factura)
        {
            Respuesta<Factura> respuesta = new Respuesta<Factura>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    var facturas = (from x in dbContexto.Facturas
                                     where x.FacturaId == factura.FacturaId
                                     select x).FirstOrDefault();
                    if (facturas != null)
                    {
                        facturas.FacturaId = factura.FacturaId;
                        facturas.ConsecutivoFactura = factura.ConsecutivoFactura;
                        facturas.MontoFactura = factura.MontoFactura;
                        facturas.FechaRegistro = factura.FechaRegistro;
                        facturas.EstadoFactura = factura.EstadoFactura;
                        facturas.ProveedorFactura = factura.ProveedorFactura;

                        dbContexto.Entry(facturas).CurrentValues.SetValues(facturas);
                        dbContexto.SaveChanges();
                    }
                    respuesta.HayError = false;
                    respuesta.Mensaje = "Modificado con exito";
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new Factura();
            }
            return respuesta;
        }
    }
}
