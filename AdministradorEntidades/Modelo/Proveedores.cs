//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdministradorEntidades.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proveedores
    {
        public int ProveedorId { get; set; }
        public string ProveedorNombre { get; set; }
        public string ProveedorCedula { get; set; }
        public string ProveedorTelefono { get; set; }
        public bool ProveedorGastoFijo { get; set; }
        public string ProveedorEstado { get; set; }
    
        public virtual Estados Estados { get; set; }
    }
}
