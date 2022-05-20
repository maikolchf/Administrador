using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministradorEntidades.Entidades;
using AdministradorEntidades.Modelo;

namespace administradorDAL
{
    public class ProveedoresDal
    {        
        public Respuesta<Proveedor> Insertar(Proveedor proveedor)
        {
            Respuesta<Proveedor> respuesta = new Respuesta<Proveedor>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    Proveedores proveedorNuevo = new Proveedores
                    {
                        ProveedorId = proveedor.ProveedorId,
                        ProveedorNombre = proveedor.ProveedorNombre,
                        ProveedorCedula = proveedor.ProveedorCedula,
                        ProveedorGastoFijo = proveedor.ProveedorGastoFijo,
                        ProveedorEstado = proveedor.ProveedorEstado,
                        ProveedorTelefono = proveedor.ProveedorTelefono
                    };
                    dbContexto.Proveedores.Add(proveedorNuevo);
                    dbContexto.SaveChanges();
                }
                respuesta.HayError = false;
                respuesta.Mensaje = "Resgistrado con exito";
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new Proveedor();
            }
            return respuesta;
        }

        public Respuesta<List<Proveedor>> Obtener()
        {
            Respuesta<List<Proveedor>> respuesta = new Respuesta<List<Proveedor>>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from x in dbContexto.Proveedores
                                                 select new Proveedor
                                                 {
                                                     ProveedorId = x.ProveedorId,
                                                     ProveedorNombre = x.ProveedorNombre,
                                                     ProveedorCedula = x.ProveedorCedula,
                                                     ProveedorTelefono = x.ProveedorTelefono,
                                                     ProveedorGastoFijo = x.ProveedorGastoFijo,
                                                     ProveedorEstado = x.ProveedorEstado,
                                                     Estado = (from y in dbContexto.Estados select new Estado
                                                     {
                                                         EstadoId = y.EstadoId,
                                                         EstadoCodigo = y.EstadoCodigo,
                                                         EstadoDescripcion = y.EstadoDescripcion
                                                     }).ToList().Where(e => e.EstadoCodigo == x.ProveedorEstado).FirstOrDefault()
                                                 }).ToList();
                    respuesta.HayError = false;
                    respuesta.Mensaje = "Exito";
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<Proveedor>();
            }
            return respuesta;
        }
    }
}
