﻿using AdministradorEntidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades
{
    public  class Factura
    {
        public int FacturaId { get; set; }
        public string ProveedorFactura { get; set; }
        public string ConsecutivoFactura { get; set; }
        public decimal MontoFactura { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string EstadoFactura { get; set; }

        public Facturas convertirObjetoInsertar(Factura factura)
        {
            Facturas vFactura = new Facturas();
            try
            {
                vFactura.FacturaId = factura.FacturaId;
                vFactura.ConsecutivoFactura = factura.ConsecutivoFactura;
                vFactura.MontoFactura = factura.MontoFactura;
                vFactura.EstadoFactura = factura.EstadoFactura;
                vFactura.ProveedorFactura = factura.ProveedorFactura;

            }
            catch (Exception oEx)
            {
                vFactura = new Facturas();
            }
            return vFactura;
        }
    }
}
