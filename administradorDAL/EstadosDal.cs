using AdministradorEntidades.Entidades;
using AdministradorEntidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administradorDAL
{
    public class EstadosDal
    {
        public Respuesta<List<Combobox>> Obtener()
        {
            Respuesta<List<Combobox>> respuesta = new Respuesta<List<Combobox>>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from x in dbContexto.Estados
                                                 select new Combobox
                                                 {
                                                     index = x.EstadoCodigo,
                                                     texto = x.EstadoDescripcion
                                                 }).ToList();

                    respuesta.HayError = false;
                    respuesta.Mensaje = "Exito";
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<Combobox>();
            }
            return respuesta;
        }
    }
}
