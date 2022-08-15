using administradorCompartidas;
using administradorDAL;
using AdministradorEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorBL
{
    public class LoginBL
    {
        LoginDAL loginDAL = new LoginDAL();
        FuncionesCompartidas funcionesCompartidas = new FuncionesCompartidas();
        public Respuesta<Usuario> Login(Login login)
        {
            Respuesta<Usuario> respuesta = new Respuesta<Usuario>();
            try
            {


                respuesta = loginDAL.Login(new Login { 
                    Usuario = login.Usuario,
                    Contrasenna = funcionesCompartidas.Encriptar(login.Contrasenna)
                });                
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.ObjetoRespuesta = null;
                respuesta.Mensaje = oEx.Message;
            }
            return respuesta;
        }
    }
}
