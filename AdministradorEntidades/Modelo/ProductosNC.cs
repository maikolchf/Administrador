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
    
    public partial class ProductosNC
    {
        public int IdProductoNC { get; set; }
        public int IdNC { get; set; }
        public int IdProducto { get; set; }
        public int CantidadProdNC { get; set; }
        public string DescripcionProdNC { get; set; }
        public decimal PrecioProdNC { get; set; }
    
        public virtual NotasCambio NotasCambio { get; set; }
        public virtual ProductosBodega ProductosBodega { get; set; }
    }
}
