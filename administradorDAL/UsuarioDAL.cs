using administradorCompartidas;
using AdministradorEntidades.Entidades;
using AdministradorEntidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administradorDAL
{
    public class UsuarioDAL
    {
        FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        public Respuesta<Usuario> InsertarModificar(Usuario usuario)
        {
            Respuesta<Usuario> respuesta = new Respuesta<Usuario>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    Usuarios usuarios = new Usuarios
                    {
                        NombreUsuario = usuario.NombreUsuario,
                        PrimerApellido = usuario.PrimerApellido,
                        SegundoApellido = usuario.SegundoApellido,
                        Correo = usuario.Correo,
                        Telefono = usuario.Telefono,
                        Usuario = usuario.UsuarioLogin,
                        Contrasenna = funcionesCompartidas.Encriptar(usuario.Contrasenna),
                        Estado = usuario.EstadoUsuario,
                        RolId = usuario.RolId
                    };

                    if (usuario.UsuarioId.Equals(0))
                    {
                        dbContexto.Usuarios.Add(usuarios);
                        respuesta.HayError = false;
                        respuesta.Mensaje = "Usuario agregado correctamente";

                        dbContexto.SaveChanges();
                    }
                    else
                    {
                        Modificar(usuario);
                        respuesta.HayError = false;
                        respuesta.Mensaje = "Usuario modificado correctamente";
                    }
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new Usuario();
            }
            return respuesta;
        }

        public Respuesta<List<Usuario>> Obtener(Usuario filtro)
        {
            Respuesta<List<Usuario>> respuesta = new Respuesta<List<Usuario>>();
            try
            {
                using ( AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from U in dbContexto.Usuarios
                                                 join R in dbContexto.Roles
                                                 on U.RolId equals (R.RolId)
                                                 join P in dbContexto.Permisos
                                                 on R.RolId equals P.RolId
                                                 join E in dbContexto.Estados
                                                 on U.Estado equals E.EstadoCodigo
                                                 select new Usuario
                                                 {
                                                     NombreUsuario = U.NombreUsuario,
                                                     PrimerApellido = U.PrimerApellido,
                                                     SegundoApellido = U.SegundoApellido,
                                                     Telefono = U.Telefono,
                                                     Correo = U.Correo,                                                     
                                                     UsuarioLogin = U.Usuario,
                                                     EstadoUsuario = U.Estado,
                                                     RolId = U.RolId,
                                                     UsuarioId = U.UsuarioId,
                                                     Estado = new Estado
                                                     {
                                                         EstadoCodigo = E.EstadoCodigo,
                                                         EstadoDescripcion = E.EstadoDescripcion,
                                                         EstadoId = E.EstadoId
                                                     },
                                                     Rol = new Rol
                                                     {
                                                         NombreRol = R.NombreRol,
                                                         EstadoRol = R.EstadoRol,
                                                         RolId = R.RolId,
                                                         Permisos = new Permiso
                                                         {
                                                             RolId = P.RolId,
                                                             PermisoId = P.PermisoId,
                                                             Facturas = P.Facturas,
                                                             Gastos = P.Gastos,
                                                             Inicio = P.Inicio,
                                                             NotasCambio = P.NotasCambio,
                                                             Perfiles = P.Perfiles,
                                                             Proveedores = P.Proveedores,
                                                             Usuarios = P.Usuarios
                                                         }
                                                     }
                                                 }).Where(e => (filtro.UsuarioId.Equals(0)
                                                   || (e.RolId.Equals(filtro.RolId))))
                                                 .ToList();
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<Usuario>();
            }
            return respuesta;
        }
        
        private Respuesta<Usuario> Modificar(Usuario usuario)
        {
            Respuesta<Usuario> respuesta = new Respuesta<Usuario>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    var usuarioMod = (from x in dbContexto.Usuarios
                                      where x.UsuarioId == usuario.UsuarioId
                                      select x).FirstOrDefault();
                    if (usuarioMod != null)
                    {

                        usuarioMod.NombreUsuario = usuario.NombreUsuario;
                        usuarioMod.PrimerApellido = usuario.PrimerApellido;
                        usuarioMod.SegundoApellido = usuario.SegundoApellido;
                        usuarioMod.Correo = usuario.Correo;
                        usuarioMod.Telefono = usuario.Telefono;
                        usuarioMod.Usuario = usuario.UsuarioLogin;
                        usuarioMod.Contrasenna = funcionesCompartidas.Encriptar(usuario.Contrasenna);
                        usuarioMod.Estado = usuario.EstadoUsuario;
                        usuarioMod.RolId = usuario.RolId;

                        dbContexto.Entry(usuarioMod).CurrentValues.SetValues(usuarioMod);
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
                respuesta.ObjetoRespuesta = new Usuario();
                throw oEx;
            }
            return respuesta;
        }      
    }
}
