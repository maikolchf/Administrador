﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades
{
    public  class NotaCambio
    {
        public int IdNC { get; set; }
        public string ConsecutivoNC { get; set; }
        public System.DateTime FechaEmisionNC { get; set; }
        public string CodProveedorNC { get; set; }
        public decimal MontoNC { get; set; }
        public int IdFacturaAplicada { get; set; }
        public string EstadoNC { get; set; }
        public List<ProductoNC> ltsProductoNC { get; set; } 
    }
}
