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
    
    public partial class Permisos
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
    
        public virtual Roles Roles { get; set; }
    }
}