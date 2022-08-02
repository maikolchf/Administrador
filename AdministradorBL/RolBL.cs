using administradorDAL;
using AdministradorEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace AdministradorBL
{
    public class RolBL
    {
        private RolDAL rolDAL = new RolDAL();
        private PermisoDAL  permisoDAL = new PermisoDAL();
        public Respuesta<Rol> InsertarModificar(Rol rol)
        {
            Respuesta<Rol> respuesta = new Respuesta<Rol>();
            using (TransactionScope transaccion = new TransactionScope())
            {
                try
                {
                    respuesta = rolDAL.InsertarModificar(rol);

                    if (!respuesta.HayError)
                    {
                        rol.Permisos.RolId = rol.RolId;
                        var respuestaPermiso = permisoDAL.InsertarModificar(rol.Permisos);

                        if (!respuestaPermiso.HayError)
                        {
                            rol.Permisos = respuestaPermiso.ObjetoRespuesta;
                        }
                        else
                        {
                            respuesta.Mensaje = respuestaPermiso.Mensaje;
                            respuesta.HayError = true;
                        }

                    }
                    transaccion.Complete();
                }
                catch (Exception oEx)
                {
                    respuesta.HayError = true;
                    respuesta.Mensaje = oEx.Message;
                    respuesta.ObjetoRespuesta = new Rol();
                    transaccion.Dispose();
                }
            }
            return respuesta;
        }

        public Respuesta<List<Rol>> Obtener(Rol rol)
        {
            return rolDAL.Obtener(rol);
        }
    }
}
