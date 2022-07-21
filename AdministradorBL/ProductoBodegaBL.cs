using administradorDAL;
using AdministradorEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorBL
{
    public class ProductoBodegaBL
    {
        private ProductoBodegaDal productoBodegaDAL = new ProductoBodegaDal();
        public Respuesta<ProductoBodega> obtener(ProductoBodega productoBodega)
        {
            Respuesta<ProductoBodega> respuesta = new Respuesta<ProductoBodega>();
            respuesta = productoBodegaDAL.Obtener(productoBodega);            
            return respuesta;
        }

        public Respuesta<List<ProductoBodega>> ObtenerProductos()
        {
            Respuesta<List<ProductoBodega>> respuesta = new Respuesta<List<ProductoBodega>>();
            respuesta = productoBodegaDAL.ObtenerProductos();
            return respuesta;
        }
    }
}
