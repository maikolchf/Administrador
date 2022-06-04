using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades
{
    public class Proveedor
    {        
        public int ProveedorId { get; set; }
        
        public string ProveedorNombre { get; set; }
        public string ProveedorCodigo { get; set; }
        
        public string ProveedorCedula { get; set; }
        
        public string ProveedorTelefono { get; set; }
        
        public bool ProveedorGastoFijo { get; set; }
        
        public string ProveedorEstado { get; set; }
        
        public Estado Estado { get; set; }
    }
}
