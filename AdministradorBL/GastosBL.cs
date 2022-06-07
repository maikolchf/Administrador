using administradorDAL;
using AdministradorEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorBL
{
    public  class GastosBL
    {
        private GastosDal gastosDal;
        public Respuesta<Gasto> Insertar(Gasto gasto)
        {
            Respuesta<Gasto> respuesta = new Respuesta<Gasto>();
            try
            {
                gastosDal = new GastosDal();
                respuesta = gastosDal.Insertar(gasto);
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new Gasto();
            }
            return respuesta;
        }

        public Respuesta<List<Gasto>> Obtener()
        {
            Respuesta<List<Gasto>> respuesta = new Respuesta<List<Gasto>>();
            try
            {
                gastosDal = new GastosDal();
                respuesta = gastosDal.Obtener();
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<Gasto>();
            }
            return respuesta;
        }
    }
}
