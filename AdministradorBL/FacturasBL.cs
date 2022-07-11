using administradorDAL;
using AdministradorEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorBL
{
    public class FacturasBL
    {
        private FacturasDAL facturasDAL = new FacturasDAL();

        public Respuesta<Factura> InsertarModificar(Factura factura)
        {
            Respuesta<Factura> respuesta = new Respuesta<Factura>();
            respuesta = facturasDAL.InsertarModificar(factura);
            return respuesta;
        }

        public Respuesta<List<Factura>> Obtener(Factura factura)
        {
            Respuesta<List<Factura>> respuesta = new Respuesta<List<Factura>>();
            respuesta = facturasDAL.Obtener(factura);
            return respuesta;
        }
    }
}
