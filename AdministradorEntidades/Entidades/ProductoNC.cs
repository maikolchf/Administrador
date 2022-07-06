using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades
{
    public  class ProductoNC
    {
        public int IdProductoNC { get; set; }
        public int IdNC { get; set; }
        public int IdProducto { get; set; }
        public int CantidadProdNC { get; set; }
        public string DescripcionProdNC { get; set; }
        public decimal PrecioProdNC { get; set; }
        public ProductoBodega ProductoBodega { get; set; }
    }
}
