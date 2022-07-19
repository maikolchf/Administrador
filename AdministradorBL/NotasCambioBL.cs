using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using administradorDAL;
using AdministradorEntidades.Entidades;

namespace AdministradorBL
{
    public  class NotasCambioBL
    {
        private NotasCambioDal notasCambioDal;
        public Respuesta<NotaCambio> Insertar(NotaCambio notaCambio)
        {
            Respuesta<NotaCambio> respuesta = new Respuesta<NotaCambio>();
            using (TransactionScope transaccion = new TransactionScope())
            {
                try
                {
                    notasCambioDal = new NotasCambioDal();
                    respuesta = notasCambioDal.Insertar(notaCambio);

                    if (!respuesta.HayError)
                    {
                        notaCambio.ltsProductos.ForEach(x =>
                        {
                            x.IdNC = notaCambio.IdNC;
                        });                                                

                        ProductoBodegaDal productoBodegaDal = new ProductoBodegaDal();
                        var resProductoBodega = productoBodegaDal.Insertar(notaCambio);

                        if (!resProductoBodega.HayError)
                        {                            
                            ProductoNCDal productoNCDal = new ProductoNCDal();
                            respuesta = productoNCDal.Insertar(notaCambio);
                        }

                    }
                    if (!respuesta.HayError)
                    {
                        transaccion.Complete();
                    }
                    else
                    {
                        transaccion.Dispose();
                    }
                }
                catch (Exception oEx)
                {
                    respuesta.HayError = true;
                    respuesta.Mensaje = oEx.Message;
                    respuesta.ObjetoRespuesta = new NotaCambio();
                    transaccion.Dispose();
                }
            }                
            return respuesta;
        }

        public Respuesta<List<NotaCambio>> Obtener()
        {
            Respuesta<List<NotaCambio>> respuesta = new Respuesta<List<NotaCambio>>();
            try
            {
                notasCambioDal = new NotasCambioDal();
                respuesta = notasCambioDal.Obtener();
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<NotaCambio>();
            }
            return respuesta;
        }
    }
}
