using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades
{
    public class Rol
    {
        public int RolId { get; set; }
        public string NombreRol { get; set; }
        public string EstadoRol { get; set; }
        public Permiso Permisos { get; set; }
    }
}
