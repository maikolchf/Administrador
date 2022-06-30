﻿using AdministradorEntidades.Entidades;
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
                    notaCambio.ltsProductos.ForEach(item =>
                    {
                        ProductosNC productoNC = new ProductosNC
                        {
                            CantidadProdNC = item.Cantidad,
                            DescripcionProdNC = item.Destalle,
                            IdNC = notaCambio.IdNC,
                            IdProducto = item.idProducto,
                            PrecioProdNC = item.Precio                            
                        };
                        ltsProductosNC.Add(productoNC);
                    });

                    dbContexto.ProductosNC.AddRange(ltsProductosNC);
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
                    respuesta.Mensaje = "Resgistrado con exito";
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

    }
}