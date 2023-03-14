using administradorDAL;
using AdministradorEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorBL
{
    public class UsuarioBL
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();
        public Respuesta<Usuario> InsertarModificar(Usuario usuario)
        {
            return usuarioDAL.InsertarModificar(usuario);
        }

        public Respuesta<List<Usuario>> Obtener(Usuario filtro)
        {
            return usuarioDAL.Obtener(filtro);
        }
    }
}
