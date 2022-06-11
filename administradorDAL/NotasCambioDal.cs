using AdministradorEntidades.Entidades;
using AdministradorEntidades.Modelo;
using System;
using System.Linq;


namespace administradorDAL
{
    public  class NotasCambioDal
    {
        public Respuesta<NotaCambio> Insertar(NotaCambio notaCambioInsertar)
        {
            Respuesta<NotaCambio> respuesta = new Respuesta<NotaCambio>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    NotasCambio notaCambio = new NotasCambio
                    {
                        IdNC = notaCambioInsertar.IdNC,
                        ConsecutivoNC = notaCambioInsertar.ConsecutivoNC,
                        FechaEmisionNC = notaCambioInsertar.FechaEmisionNC,
                        CodProveedorNC = notaCambioInsertar.CodProveedorNC,
                        MontoNC = notaCambioInsertar.MontoNC,
                        EstadoNC = notaCambioInsertar.EstadoNC,
                        IdFacturaAplicada = notaCambioInsertar.IdFacturaAplicada
                    };

                    if (notaCambio.IdNC == 0)
                    {
                        dbContexto.NotasCambio.Add(notaCambio);
                        dbContexto.SaveChanges();
                        respuesta.HayError = false;
                        respuesta.Mensaje = "Resgistrado con exito";
                    }
                    else
                    {
                        respuesta = Modificar(notaCambioInsertar);
                    }
                    respuesta.ObjetoRespuesta = notaCambioInsertar;
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

        private Respuesta<NotaCambio> Modificar(NotaCambio notaCambioMod)
        {
            Respuesta<NotaCambio> respuesta = new Respuesta<NotaCambio>();
            try
            {
                using (AdministradorAzurEntities dbContexto = new AdministradorAzurEntities())
                {
                    NotasCambio notasCambio = (from x in dbContexto.NotasCambio
                                 where x.IdNC == notaCambioMod.IdNC
                                 select x).FirstOrDefault();
                    if (notasCambio != null)
                    {
                        notasCambio.IdNC = notaCambioMod.IdNC;
                        notasCambio.ConsecutivoNC = notaCambioMod.ConsecutivoNC;
                        notasCambio.FechaEmisionNC = notaCambioMod.FechaEmisionNC;
                        notasCambio.CodProveedorNC = notaCambioMod.CodProveedorNC;
                        notasCambio.MontoNC = notaCambioMod.MontoNC;
                        notasCambio.EstadoNC = notaCambioMod.EstadoNC;

                        dbContexto.Entry(notasCambio).CurrentValues.SetValues(notasCambio);
                        dbContexto.SaveChanges();
                    }
                    respuesta.HayError = false;
                    respuesta.Mensaje = "Modificado con exito";
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
