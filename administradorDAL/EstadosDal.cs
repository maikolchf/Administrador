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
        public Respuesta<List<Estado>> Obtener()
        {
            Respuesta<List<Estado>> respuesta = new Respuesta<List<Estado>>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    respuesta.ObjetoRespuesta = (from x in dbContexto.Estados
                                                 select new Estado
                                                 {
                                                     EstadoCodigo = x.EstadoCodigo,
                                                     EstadoDescripcion = x.EstadoDescripcion,
                                                     EstadoId = x.EstadoId                                                    
                                                 }).ToList();

                    respuesta.HayError = false;
                    respuesta.Mensaje = "Exito";
                }
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new List<Estado>();
            }
            return respuesta;
        }
    }
}
