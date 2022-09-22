using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades.Reportes
{
    public class NotasCambioReporte
    {
        public string Consecutivo { get; set; }
        public string Proveedor { get; set; }
        public decimal Monto { get; set; }
        public string Estado { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }
}
