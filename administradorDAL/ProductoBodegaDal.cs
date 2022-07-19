using AdministradorEntidades.Entidades;
using AdministradorEntidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
                            CantidadProducto = item.Cantidad,
                            IdProducto = item.idProducto
                        };
                        ltsProductoBodega.Add(productoBodega);
                    }

                    var lstProductos = (from prod in dbContexto.ProductosBodega
                                        select prod).ToList();

                    IdentificarProductos(ref productosInsertar, 
                        ref productosActualizar, 
                        lstProductos, 
                        ltsProductoBodega, 
                        notaCambio.IdFacturaAplicada.Equals(0) ? false : true);

                    if (productosInsertar.Count > 0)
                    {
                        dbContexto.ProductosBodega.AddRange(productosInsertar);
                    }

                    if (productosActualizar.Count > 0)
                    {
                        ActualizarCantidadesProductos(ltsProductoBodega, 
                            ref productosActualizar,
                            notaCambio.IdFacturaAplicada.Equals(0) ? false : true);
                        productosActualizar.ForEach(item =>
                        {
                            dbContexto.Entry(item).CurrentValues.SetValues(item);
                        });
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

        public Respuesta<ProductoBodega> Obtener(ProductoBodega productoBodega)
        {
            Respuesta<ProductoBodega> respuesta = new Respuesta<ProductoBodega>();

            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from item in dbContexto.ProductosBodega
                                                 select new ProductoBodega
                                                 {
                                                     CantidadProducto = item.CantidadProducto,
                                                     CodigoProducto = item.CodigoProducto,
                                                     IdProducto = item.IdProducto,
                                                     NombreProducto = item.NombreProducto                                                      
                                                 }).Where(e => (productoBodega.CodigoProducto.Equals(null)
                                                   || (e.CodigoProducto.Equals(productoBodega.CodigoProducto))))
                                                   .FirstOrDefault();
                    respuesta.HayError = false;
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
            }

            return respuesta;
        }
        private void IdentificarProductos(ref List<ProductosBodega> nuevos, ref List<ProductosBodega> actualizar,
            List<ProductosBodega> lstProductos, List<ProductosBodega> nuevosProductos, bool facturaAPlicada = false)
        {
            foreach (ProductosBodega producto in lstProductos)
            {
                if (nuevosProductos.Exists(x => x.CodigoProducto.Equals(producto.CodigoProducto)))
                {
                    actualizar.Add(producto);
                }
            }

            foreach (ProductosBodega producto in nuevosProductos)
            {
                if (actualizar.Count > 0)
                {
                    if (producto.IdProducto.Equals(0))
                    {
                        if (facturaAPlicada)
                            producto.CantidadProducto = 0;

                        nuevos.Add(producto);
                    }
                }
                else
                {
                    if (facturaAPlicada)
                        producto.CantidadProducto = 0;
                    nuevos.Add(producto);
                }

            }
        }

        private void ActualizarCantidadesProductos(List<ProductosBodega> lstProductos, ref List<ProductosBodega> productosActualizar, bool facturaAplicada = false)
        {
            foreach (var prod in lstProductos)
            {
                foreach (var prodAct in productosActualizar)
                {
                    if (prod.CodigoProducto == prodAct.CodigoProducto)
                    {
                        if (facturaAplicada)
                        {
                            prodAct.CantidadProducto = 0;
                        }else
                        {
                            if (prod.CantidadProducto > prodAct.CantidadProducto)
                            {
                                int cantNueva = prod.CantidadProducto - prodAct.CantidadProducto;
                                prodAct.CantidadProducto = prodAct.CantidadProducto + cantNueva;
                            }

                            if (prod.CantidadProducto < prodAct.CantidadProducto)
                            {
                                int cantNueva = prodAct.CantidadProducto - prod.CantidadProducto;
                                prodAct.CantidadProducto = prodAct.CantidadProducto - cantNueva;
                            }
                        }                       
                    }
                }
            }
        }
    }
}

