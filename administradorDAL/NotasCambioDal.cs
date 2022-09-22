using AdministradorEntidades.Entidades;
using AdministradorEntidades.Entidades.Reportes;
using AdministradorEntidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace administradorDAL
{
    public  class NotasCambioDal
    {
        public Respuesta<NotaCambio> Insertar(NotaCambio notaCambioInsertar)
        {
            Respuesta<NotaCambio> respuesta = new Respuesta<NotaCambio>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    NotasCambio notaCambio = new NotasCambio
                    {
                        IdNC = notaCambioInsertar.IdNC,
                        ConsecutivoNC = notaCambioInsertar.ConsecutivoNC,
                        FechaEmisionNC = notaCambioInsertar.FechaEmisionNC,
                        CodProveedorNC = notaCambioInsertar.CodProveedorNC,
                        MontoNC = notaCambioInsertar.MontoNC,
                        EstadoNC = notaCambioInsertar.EstadoNC,
                        IdFacturaAplicada = notaCambioInsertar.IdFacturaAplicada
                    };

                    if (notaCambio.IdNC == 0)
                    {
                        dbContexto.NotasCambio.Add(notaCambio);
                        dbContexto.SaveChanges();
                        respuesta.HayError = false;
                        respuesta.Mensaje = "Registrado con exito";
                        notaCambioInsertar.IdNC = notaCambio.IdNC;
                    }
                    else
                    {
                        respuesta = Modificar(notaCambioInsertar);
                    }
                    respuesta.ObjetoRespuesta = notaCambioInsertar;
                }

            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new NotaCambio();
            }
            return respuesta;
        }

        private Respuesta<NotaCambio> Modificar(NotaCambio notaCambioMod)
        {
            Respuesta<NotaCambio> respuesta = new Respuesta<NotaCambio>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    NotasCambio notasCambio = (from x in dbContexto.NotasCambio
                                 where x.IdNC == notaCambioMod.IdNC
                                 select x).FirstOrDefault();
                    if (notasCambio != null)
                    {
                        notasCambio.IdNC = notaCambioMod.IdNC;
                        notasCambio.ConsecutivoNC = notaCambioMod.ConsecutivoNC;
                        notasCambio.FechaEmisionNC = notaCambioMod.FechaEmisionNC;
                        notasCambio.CodProveedorNC = notaCambioMod.CodProveedorNC;
                        notasCambio.MontoNC = notaCambioMod.MontoNC;
                        notasCambio.EstadoNC = notaCambioMod.EstadoNC;
                        notasCambio.IdFacturaAplicada = notaCambioMod.IdFacturaAplicada;

                        dbContexto.Entry(notasCambio).CurrentValues.SetValues(notasCambio);
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
                respuesta.ObjetoRespuesta = new NotaCambio();
            }
            return respuesta;
        }

        public Respuesta<List<NotaCambio>> Obtener()
        {
            Respuesta<List<NotaCambio>> respuesta = new Respuesta<List<NotaCambio>>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from x in dbContexto.NotasCambio
                                                 select new NotaCambio
                                                 {
                                                     IdNC = x.IdNC,
                                                     CodProveedorNC = x.CodProveedorNC,
                                                     ConsecutivoNC = x.ConsecutivoNC,
                                                     EstadoNC = x.EstadoNC,
                                                     FechaEmisionNC = x.FechaEmisionNC,
                                                     IdFacturaAplicada = x.IdFacturaAplicada,
                                                     MontoNC = x.MontoNC,
                                                     Estado = (from est in dbContexto.Estados
                                                               select new Estado
                                                               {
                                                                   EstadoCodigo = est.EstadoCodigo,
                                                                   EstadoDescripcion = est.EstadoDescripcion
                                                               }).ToList().Where(u => u.EstadoCodigo == x.EstadoNC).FirstOrDefault(),
                                                     Proveedor = (from prove in dbContexto.Proveedores
                                                                  select new Proveedor
                                                                  {
                                                                      ProveedorCodigo = prove.ProveedorCodigo,
                                                                      ProveedorNombre = prove.ProveedorNombre
                                                                  }).ToList().Where(g => g.ProveedorCodigo == x.CodProveedorNC).FirstOrDefault(),
                                                     ltsProductoNC = (from y in dbContexto.ProductosNC
                                                               select new ProductoNC
                                                               {
                                                                   IdNC = y.IdNC,
                                                                   IdProducto = y.IdProducto,
                                                                   CantidadProdNC = y.CantidadProdNC,
                                                                   DescripcionProdNC = y.DescripcionProdNC,
                                                                   IdProductoNC = y.IdProductoNC,
                                                                   PrecioProdNC = y.PrecioProdNC,
                                                                   ProductoBodega = (from p in dbContexto.ProductosBodega
                                                                                     select new ProductoBodega
                                                                                     {
                                                                                         CantidadProducto = p.CantidadProducto,
                                                                                         CodigoProducto = p.CodigoProducto,
                                                                                         IdProducto = p.IdProducto,
                                                                                         NombreProducto = p.NombreProducto
                                                                                     }).ToList().Where(k => k.IdProducto == y.IdProducto).FirstOrDefault()
                                                               }).Where(e => e.IdNC == x.IdNC).ToList(), 
                                                     Factura = (from f in dbContexto.Facturas
                                                                select new Factura
                                                                {
                                                                    ConsecutivoFactura = f.ConsecutivoFactura,
                                                                    EstadoFactura = f.EstadoFactura,
                                                                    FacturaId = f.FacturaId,
                                                                    FechaRegistro = f.FechaRegistro,
                                                                    MontoFactura = f.MontoFactura,     
                                                                    ProveedorFactura = f.ProveedorFactura
                                                                }).Where(l => l.FacturaId.Equals(x.IdFacturaAplicada)).FirstOrDefault()
                                                 }).ToList();
                    respuesta.HayError = false;
                    respuesta.Mensaje = "Exito";
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<NotaCambio>();
            }
            return respuesta;
        }

        public Respuesta<List<NotasCambioReporte>> DatosReporte(string estado, DateTime fechaInicio, DateTime fechaFinal)
        {
            Respuesta<List<NotasCambioReporte>> respuesta = new Respuesta<List<NotasCambioReporte>>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from NC in dbContexto.NotasCambio
                                                 join PNC in dbContexto.ProductosNC
                                                     on NC.IdNC equals PNC.IdNC
                                                 join P in dbContexto.ProductosBodega
                                                     on PNC.IdProducto equals P.IdProducto
                                                 join PRO in dbContexto.Proveedores
                                                     on NC.CodProveedorNC equals PRO.ProveedorCodigo
                                                 join E in dbContexto.Estados
                                                     on NC.EstadoNC equals E.EstadoCodigo
                                                 where (NC.EstadoNC.Equals(estado)
                                                       && (NC.FechaEmisionNC >= fechaInicio
                                                       && NC.FechaEmisionNC <= fechaFinal))
                                                select new NotasCambioReporte
                                                {
                                                    Consecutivo = NC.ConsecutivoNC,
                                                    Proveedor = PRO.ProveedorNombre,
                                                    Monto = NC.MontoNC,
                                                    Estado = E.EstadoDescripcion,
                                                    CodigoProducto = P.CodigoProducto,
                                                    NombreProducto = P.NombreProducto,
                                                    Precio = PNC.PrecioProdNC,
                                                    Cantidad = PNC.CantidadProdNC
                                                }
                                                     ).ToList();

                    respuesta.HayError = false;
                    respuesta.Mensaje = "Exito";
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<NotasCambioReporte>();
            }
            return respuesta;
        }
    }
}
