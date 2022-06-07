using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades
{
    public class Gasto
    {
        public int GastoId { get; set; }
        public string CodigoProveedor { get; set; }  
        public string Consecutivo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Monto { get; set; }
        public string Detalle { get; set; }
        public string CodigoEstado { get; set; }
        public Estado Estado { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
