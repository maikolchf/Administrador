using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades.Reportes
{
    public class GastoReporte
    {
        public string Proveedor  { get; set; }
        public string Consecutivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal Monto { get; set; }
        public string Descriptcion { get; set; }
        public string Estado { get; set; }
    }
}
