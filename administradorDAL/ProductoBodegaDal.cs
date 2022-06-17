using AdministradorEntidades.Entidades;
using AdministradorEntidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administradorDAL
{
    public class ProductoBodegaDal
    {
        public Respuesta<List<Producto>> Insertar(NotaCambio notaCambio)
        {
            Respuesta<List<Producto>> respuesta = new Respuesta<List<Producto>>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    List<ProductosBodega> ltsProductoBodega = new List<ProductosBodega>();
                    List<Producto> ltsProductos = notaCambio.ltsProductos;
                    foreach (Producto item in ltsProductos)
                    {
                        ProductosBodega productoBodega = new ProductosBodega
                        {
                            CodigoProducto = item.Codigo,
                            NombreProducto = item.Nombre,
                            CantidadProducto = item.Cantidad
                        };
                        ltsProductoBodega.Add(productoBodega);
                    }                    
                    dbContexto.ProductosBodega.AddRange(ltsProductoBodega);
                    dbContexto.SaveChanges();

                    ltsProductos.ForEach(produc =>
                    {
                        ltsProductoBodega.ForEach(producBode =>
                        {
                            if (produc.Codigo == producBode.CodigoProducto)
                            {
                                produc.idProducto = producBode.IdProducto;
                            }
                        });
                    });

                    respuesta.HayError = false;
                    respuesta.Mensaje = "Exito";
                    respuesta.ObjetoRespuesta = ltsProductos;
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<Producto>();
            }
            return respuesta;
        }
    }
}

