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
    
    public partial class Gastos
    {
        public int GastoId { get; set; }
        public string Proveedor { get; set; }
        public string Consecutivo { get; set; }
        public System.DateTime FechaVencimiento { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    
        public virtual Estados Estados { get; set; }
        public virtual Proveedores Proveedores { get; set; }
    }
}
