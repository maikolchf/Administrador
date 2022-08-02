using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades
{
    public class Permiso
    {
        public int PermisoId { get; set; }
        public int RolId { get; set; }
        public bool Inicio { get; set; }
        public bool Proveedores { get; set; }
        public bool Gastos { get; set; }
        public bool NotasCambio { get; set; }
        public bool Facturas { get; set; }
        public bool Usuarios { get; set; }
        public bool Perfiles { get; set; }

    }
}
