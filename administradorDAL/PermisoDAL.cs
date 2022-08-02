using AdministradorEntidades.Entidades;
using AdministradorEntidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administradorDAL
{
    public  class PermisoDAL
    {
        public Respuesta<Permiso> InsertarModificar(Permiso permiso)
        {
            Respuesta<Permiso> respuesta = new Respuesta<Permiso>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    Permisos permisos = new Permisos
                    {
                        PermisoId = permiso.PermisoId,
                        Facturas = permiso.Facturas,
                        Gastos = permiso.Gastos,
                        Inicio = permiso.Inicio,
                        NotasCambio = permiso.NotasCambio,
                        Perfiles = permiso.Perfiles,
                        Proveedores = permiso.Proveedores,
                        Usuarios = permiso.Usuarios,
                        RolId = permiso.RolId,
                    };

                    if (permisos.PermisoId.Equals(0))
                    {
                        dbContexto.Permisos.Add(permisos);
                        respuesta.Mensaje = "Permisos insertado con exito";
                    }
                    else
                    {
                        Modificar(permiso);
                        respuesta.Mensaje = "Rol modificado con exito";
                    }

                    dbContexto.SaveChanges();
                    permiso.PermisoId = permisos.PermisoId;
                    respuesta.ObjetoRespuesta = permiso;
                    respuesta.HayError = false;
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new Permiso();
                throw oEx;
            }
            return respuesta;
        }
        private Respuesta<Permiso> Modificar(Permiso permiso)
        {
            Respuesta<Permiso> respuesta = new Respuesta<Permiso>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    var permisos = (from x in dbContexto.Permisos
                               where x.RolId == permiso.RolId
                               select x).FirstOrDefault();
                    if (permisos != null)
                    {
                        permisos.Facturas = permiso.Facturas;
                        permisos.Facturas = permiso.Facturas;
                        permisos.Gastos = permiso.Gastos;
                        permisos.Inicio = permiso.Inicio;
                        permisos.NotasCambio = permiso.NotasCambio;
                        permisos.Perfiles = permiso.Perfiles;
                        permisos.Proveedores = permiso.Proveedores;
                        permisos.Usuarios = permiso.Usuarios;

                        dbContexto.Entry(permisos).CurrentValues.SetValues(permisos);
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
                respuesta.ObjetoRespuesta = new Permiso();
                throw oEx;
            }
            return respuesta;
        }
    }
}
