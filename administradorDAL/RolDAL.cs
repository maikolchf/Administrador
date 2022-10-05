using AdministradorEntidades.Entidades;
using AdministradorEntidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administradorDAL
{
    public class RolDAL
    {
        public Respuesta<Rol> InsertarModificar(Rol rolInsertar)
        {
            Respuesta<Rol> respuesta = new Respuesta<Rol>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    Roles rol = new Roles
                    {
                        RolId = rolInsertar.RolId,
                        NombreRol = rolInsertar.NombreRol,   
                        EstadoRol = rolInsertar.EstadoRol
                    };

                    if (rol.RolId.Equals(0))
                    {
                        dbContexto.Roles.Add(rol);
                        respuesta.Mensaje = "Rol insertado con exito";
                    }
                    else
                    {
                        Modificar(rolInsertar);
                        respuesta.Mensaje = "Rol modificado con exito";
                    }
                                        
                    dbContexto.SaveChanges();
                    rolInsertar.RolId = rol.RolId;
                    respuesta.ObjetoRespuesta = rolInsertar;
                    respuesta.HayError = false;
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new Rol();
                throw oEx;
            }
            return respuesta;
        }
        public Respuesta<List<Rol>> Obtener(Rol filtro)
        {
            Respuesta<List<Rol>> respuesta = new Respuesta<List<Rol>>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from R in dbContexto.Roles
                                                 select new Rol
                                                 {
                                                     NombreRol = R.NombreRol,
                                                     RolId = R.RolId,
                                                     EstadoRol = R.EstadoRol,
                                                     Permisos = (from P in dbContexto.Permisos
                                                                 select new Permiso
                                                                 {
                                                                     PermisoId = P.PermisoId,
                                                                     RolId = P.RolId,
                                                                     Facturas = P.Facturas,
                                                                     Gastos = P.Gastos,
                                                                     Inicio = P.Inicio,
                                                                     NotasCambio = P.NotasCambio,
                                                                     Perfiles = P.Perfiles,
                                                                     Proveedores = P.Proveedores,
                                                                     Usuarios = P.Usuarios,
                                                                     ReporteNC = P.ReporteNC,
                                                                     ProductosBodega = P.ProductosBodega
                                                                 }).Where(i => i.RolId.Equals(R.RolId)).FirstOrDefault(),
                                                     Estado = (from E in dbContexto.Estados
                                                               select new Estado
                                                               {
                                                                   EstadoCodigo = E.EstadoCodigo,
                                                                   EstadoDescripcion = E.EstadoDescripcion,
                                                                   EstadoId = E.EstadoId
                                                               }).Where(i => i.EstadoCodigo.Equals(R.EstadoRol)).FirstOrDefault()
                                                 }).Where(e => (filtro.RolId.Equals(0)
                                                   || (e.RolId.Equals(filtro.RolId))))
                                                 .ToList();

                    respuesta.HayError = false;
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<Rol>();
            }
            return respuesta;
        }

        private Respuesta<Rol> Modificar(Rol rolModificar)
        {
            Respuesta<Rol> respuesta = new Respuesta<Rol>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    var Rol = (from x in dbContexto.Roles
                                 where x.RolId == rolModificar.RolId
                                 select x).FirstOrDefault();
                    if (Rol != null)
                    {
                        Rol.RolId = rolModificar.RolId;
                        Rol.NombreRol = rolModificar.NombreRol;
                        Rol.EstadoRol = rolModificar.EstadoRol;

                        dbContexto.Entry(Rol).CurrentValues.SetValues(Rol);
                        dbContexto.SaveChanges();

                        respuesta.Mensaje = "Modificado con exito";
                    }
                    respuesta.HayError = false;
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new Rol();
                throw oEx;
            }
            return respuesta;
        }        
    }
}
