using AdministradorEntidades.Entidades;
using AdministradorEntidades.Entidades.Reportes;
using AdministradorEntidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administradorDAL
{
    public  class GastosDal
    {
        public Respuesta<Gasto> Insertar(Gasto gasto)
        {
            Respuesta<Gasto> respuesta = new Respuesta<Gasto>(); 
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    Gastos nuevoGasto = new Gastos
                    {
                        GastoId = gasto.GastoId,
                        Consecutivo = gasto.Consecutivo,
                        Descripcion = gasto.Detalle,
                        FechaVencimiento = gasto.FechaVencimiento,
                        Estado = gasto.CodigoEstado,
                        Monto = gasto.Monto,
                        Proveedor = gasto.CodigoProveedor,
                    };
                    if (gasto.GastoId == 0)
                    {
                        dbContexto.Gastos.Add(nuevoGasto);
                        dbContexto.SaveChanges();
                        respuesta.HayError = false;
                        respuesta.Mensaje = "Resgistrado con exito";
                    }
                    else
                    {
                        respuesta = Modificar(gasto);
                    }
                    respuesta.ObjetoRespuesta = gasto;
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = gasto;
            }
            return respuesta;
        }

        public Respuesta<List<Gasto>> Obtener()
        {
            Respuesta<List<Gasto>> respuesta = new Respuesta<List<Gasto>>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from x in dbContexto.Gastos
                                                 select new Gasto
                                                 {
                                                     GastoId = x.GastoId,
                                                     Consecutivo = x.Consecutivo,
                                                     Detalle = x.Descripcion,
                                                     Monto = x.Monto,
                                                     CodigoProveedor = x.Proveedor,
                                                     CodigoEstado = x.Estado,
                                                     FechaVencimiento = x.FechaVencimiento,
                                                     Estado = (from y in dbContexto.Estados
                                                               select new Estado
                                                               {
                                                                   EstadoId = y.EstadoId,
                                                                   EstadoCodigo = y.EstadoCodigo,
                                                                   EstadoDescripcion = y.EstadoDescripcion
                                                               }).ToList().Where(e => e.EstadoCodigo == x.Estado).FirstOrDefault(),
                                                     
                                                     Proveedor = (from p in dbContexto.Proveedores
                                                                  select new Proveedor
                                                                  {
                                                                      ProveedorId = p.ProveedorId,
                                                                      ProveedorCedula = p.ProveedorCedula,
                                                                      ProveedorTelefono = p.ProveedorTelefono,
                                                                      ProveedorGastoFijo = p.ProveedorGastoFijo,
                                                                      ProveedorEstado = p.ProveedorEstado,
                                                                      ProveedorNombre = p.ProveedorNombre,
                                                                      ProveedorCodigo = p.ProveedorCodigo
                                                                  }).ToList().Where(j => j.ProveedorCodigo == x.Proveedor).FirstOrDefault()
                                                 }).ToList();
                    respuesta.HayError = false;
                    respuesta.Mensaje = "Exito";
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<Gasto>();
            }
            return respuesta;
        }

        private Respuesta<Gasto> Modificar(Gasto gastoMod)
        {
            Respuesta<Gasto> respuesta = new Respuesta<Gasto>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    var gasto = (from x in dbContexto.Gastos
                                     where x.GastoId == gastoMod.GastoId
                                     select x).FirstOrDefault();
                    if (gasto != null)
                    {
                        gasto.GastoId = gastoMod.GastoId;
                        gasto.Consecutivo = gastoMod.Consecutivo;
                        gasto.Descripcion = gastoMod.Detalle;
                        gasto.FechaVencimiento = gastoMod.FechaVencimiento;
                        gasto.Estado = gastoMod.CodigoEstado;
                        gasto.Monto = gastoMod.Monto;
                        gasto.Proveedor = gastoMod.CodigoProveedor;

                        dbContexto.Entry(gasto).CurrentValues.SetValues(gasto);
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
                respuesta.ObjetoRespuesta = new Gasto();
            }
            return respuesta;
        }

        public Respuesta<List<GastoReporte>> ObtenerDatosReporte(string estado, DateTime fechaInicio, DateTime fechaFinal)
        {
            Respuesta<List<GastoReporte>> respuesta = new Respuesta<List<GastoReporte>>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from G in dbContexto.Gastos
                                                 join E in dbContexto.Estados
                                                 on G.Estado equals E.EstadoCodigo
                                                 join P in dbContexto.Proveedores
                                                 on G.Proveedor equals P.ProveedorCodigo
                                                 where (G.Estado.Equals(estado)
                                                      && (G.FechaVencimiento >= fechaInicio
                                                      && G.FechaVencimiento <= fechaFinal))
                                                select new GastoReporte
                                                {
                                                    Consecutivo = G.Consecutivo,
                                                    Proveedor = P.ProveedorNombre,
                                                    FechaRegistro = G.FechaVencimiento,
                                                    Descriptcion = G.Descripcion,
                                                    Estado = E.EstadoDescripcion,
                                                    Monto = G.Monto
                                                }).ToList();
                    respuesta.HayError = false;
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError= true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<GastoReporte>();
            }
            return respuesta;
        }
    }
}
