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
            List<ProductosBodega> productosInsertar = new List<ProductosBodega>();
            List<ProductosBodega> productosActualizar = new List<ProductosBodega>();
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

                    var lstProductos = (from prod in dbContexto.ProductosBodega
                                        select prod).ToList();

                    IdentificarProductos(ref productosInsertar, ref productosActualizar, lstProductos, ltsProductoBodega);

                    if (productosInsertar.Count > 0)
                    {
                        dbContexto.ProductosBodega.AddRange(productosInsertar);
                    }

                    if (productosActualizar.Count > 0)
                    {
                        ActualizarCantidadesProductos(lstProductos, ref productosActualizar);
                        dbContexto.Entry(productosActualizar).CurrentValues.SetValues(productosActualizar);
                    }
                    
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
        private void IdentificarProductos(ref List<ProductosBodega> nuevos, ref List<ProductosBodega> actualizar, List<ProductosBodega> lstProductos, List<ProductosBodega> nuevosProductos)
        {            
            foreach (ProductosBodega producto in lstProductos)
            {
                if (nuevosProductos.Exists(x => x.CodigoProducto.Equals(producto.CodigoProducto)))
                {
                    actualizar.Add(producto);
                }                
            }
            
            foreach (ProductosBodega producto in actualizar)
            {                
                 
            }
        }

        private void ActualizarCantidadesProductos(List<ProductosBodega> lstProductos, ref List<ProductosBodega> productosActualizar)
        {
            foreach ( var prod in lstProductos)
            {
                foreach (var prodAct in productosActualizar)
                {
                    if (prod.CodigoProducto == prodAct.CodigoProducto)
                    {
                        if (prod.CantidadProducto > prodAct.CantidadProducto)
                        {
                            int cantNueva = prod.CantidadProducto - prodAct.CantidadProducto;
                            prodAct.CantidadProducto = cantNueva;
                        }

                        if (prod.CantidadProducto < prodAct.CantidadProducto)
                        {
                            int cantNueva = prodAct.CantidadProducto - prod.CantidadProducto;
                            prodAct.CantidadProducto = cantNueva;
                        }
                    }
                }
            }
        }
    }   
}

