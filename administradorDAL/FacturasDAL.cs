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
                    if (!factura.FacturaId.Equals(0))
                    {
                        dbContexto.Facturas.Add(factura.convertirObjetoInsertar(factura));
                        respuesta.Mensaje = "Registrado correctamente";
                    }
                    else
                    {
                        dbContexto.Entry(factura.convertirObjetoInsertar(factura)).CurrentValues.SetValues(factura.convertirObjetoInsertar(factura));
                        respuesta.Mensaje = "Modificado correctamente";
                    }
                    dbContexto.SaveChanges();
                    respuesta.HayError = true;
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
                                                 where (item.FacturaId == factura.FacturaId || factura.FacturaId == 0)
                                                 select new Factura
                                                 {
                                                     FacturaId = item.FacturaId,
                                                     ConsecutivoFactura = item.ConsecutivoFactura,
                                                     EstadoFactura = item.EstadoFactura,
                                                     FechaRegistro = item.FechaRegistro,
                                                     MontoFactura = item.MontoFactura,
                                                     ProveedorFactura = item.ProveedorFactura
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
    }
}
