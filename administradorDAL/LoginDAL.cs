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
    public class LoginDAL
    {
        FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        public Respuesta<Usuario> Login(Login login)
        {
            Respuesta<Usuario> respuesta = new Respuesta<Usuario>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from U in dbContexto.Usuarios
                                                 join R in dbContexto.Roles on U.RolId equals R.RolId
                                                 join P in dbContexto.Permisos on R.RolId equals P.RolId
                                                 where (U.Usuario == login.Usuario
                                                        && U.Contrasenna == login.Contrasenna
                                                        && U.Estado == Constantes.EstadosDefaul.Activo)
                                                 select new Usuario
                                                 {
                                                     Contrasenna = U.Contrasenna,
                                                     Correo = U.Correo,
                                                     NombreUsuario = U.NombreUsuario,
                                                     PrimerApellido = U.PrimerApellido,
                                                     SegundoApellido = U.PrimerApellido,
                                                     RolId = U.RolId,
                                                     Telefono = U.Telefono,
                                                     UsuarioLogin = U.Usuario,
                                                     UsuarioId = U.UsuarioId,
                                                     EstadoUsuario = U.Estado,
                                                     Rol = new Rol
                                                     {
                                                         RolId = R.RolId,
                                                         NombreRol = R.NombreRol,
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
                                                             Usuarios = P.Usuarios,
                                                             ProductosBodega = P.ProductosBodega,
                                                             ReporteNC = P.ReporteNC,
                                                             ReporteGT = P.ReporteGT
                                                         }
                                                     }

                                                 }).FirstOrDefault();
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = null;
            }
            return respuesta;
        }
    }
}
