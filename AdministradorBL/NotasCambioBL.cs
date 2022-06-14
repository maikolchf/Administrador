using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            try
            {
                notasCambioDal = new NotasCambioDal();
                respuesta = notasCambioDal.Insertar(notaCambio);
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new NotaCambio();
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
