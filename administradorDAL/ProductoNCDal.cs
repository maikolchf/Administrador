using AdministradorEntidades.Entidades;
using AdministradorEntidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administradorDAL
{
    public class ProductoNCDal
    {
        public Respuesta<NotaCambio> Insertar(NotaCambio notaCambio)
        {
            Respuesta<NotaCambio> respuesta = new Respuesta<NotaCambio>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    List<ProductosNC> ltsProductosNC = new List<ProductosNC>();
                    List<ProductosNC> ltsProductosNCNuevos = new List<ProductosNC>();
                    List<ProductosNC> ltsProductosNCActualizar = new List<ProductosNC>();

                    notaCambio.ltsProductos.ForEach(item =>
                    {
                        ProductosNC productoNC = new ProductosNC
                        {
                            CantidadProdNC = item.Cantidad,
                            DescripcionProdNC = item.Destalle,
                            IdNC = notaCambio.IdNC,
                            IdProducto = item.idProducto,
                            PrecioProdNC = item.Precio,
                            IdProductoNC = item.idProductoNC
                        };
                        ltsProductosNC.Add(productoNC);
                    });                    

                    IdentificarProdcutosNC(ref ltsProductosNCNuevos, ref ltsProductosNCActualizar, ltsProductosNC);

                    if (ltsProductosNCNuevos.Count > 0)
                    {
                        dbContexto.ProductosNC.AddRange(ltsProductosNCNuevos);
                    }

                    if (ltsProductosNCActualizar.Count > 0)
                    {
                        ltsProductosNCActualizar.ForEach(item =>
                        {
                            ProductosNC prod = (from p in dbContexto.ProductosNC
                                                where p.IdProductoNC.Equals(item.IdProductoNC)
                                                select p).FirstOrDefault();
                            prod.CantidadProdNC = item.CantidadProdNC;
                            prod.PrecioProdNC = item.PrecioProdNC;

                            dbContexto.Entry<ProductosNC>(prod).CurrentValues.SetValues(prod);
                        });
                    }

                    dbContexto.SaveChanges();

                    List<ProductoNC> productoNCs = new List<ProductoNC>();
                    ltsProductosNC.ForEach(item =>
                    {
                        ProductoNC productoNC = new ProductoNC
                        {
                            CantidadProdNC = item.CantidadProdNC,
                            DescripcionProdNC = item.DescripcionProdNC,
                            IdNC = item.IdNC,
                            IdProducto = item.IdProducto,
                            IdProductoNC = item.IdProductoNC,
                            PrecioProdNC = item.PrecioProdNC                            
                        };
                        productoNCs.Add(productoNC);
                    });

                    notaCambio.ltsProductoNC = productoNCs;

                    respuesta.HayError = false;
                    respuesta.Mensaje = "Registrado con exito";
                    respuesta.ObjetoRespuesta = notaCambio;                                        
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new NotaCambio();
            }
            return respuesta;
        }

        private void IdentificarProdcutosNC(ref List<ProductosNC> productosInsertar, ref List<ProductosNC> productosActualizar, List<ProductosNC> productosNC)
        {
            foreach(ProductosNC item in productosNC)
            {
                if (item.IdProductoNC.Equals(0))
                {
                    productosInsertar.Add(item);
                }
                else
                {
                    productosActualizar.Add(item);
                }
            };
        }
    }
}
