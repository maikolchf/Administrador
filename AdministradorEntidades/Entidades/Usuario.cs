using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public int RolId { get; set; }
        public string NombreUsuario { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Contrasenna { get; set; }
        public string UsuarioLogin { get; set; }
        public string EstadoUsuario { get; set; }

        public DateTime FechaGeneraToken { get; set; }

        public string Token { get; set; }

        public Estado Estado { get; set; }

        public Rol Rol { get; set; }

        public bool modificarContrasenna { get; set; }
    }
}
