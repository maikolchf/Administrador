using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades
{
    public class Producto
    {
        public int idProductoNC { get; set; }
        public int idProducto { get; set; } 
        public int IdNC { get; set; }
        public string Codigo { get; set; }
        public string Nombre {  get; set; }
        public string Destalle { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
