using administradorDAL;
using AdministradorEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorBL
{
    public class ProveedoresBL
    {
        private ProveedoresDal proveedoresDal;
        public Respuesta<Proveedor> Insertar(Proveedor proveedor)
        {
            Respuesta<Proveedor> respuesta = new Respuesta<Proveedor>();
            try
            {
                proveedoresDal = new ProveedoresDal();
                respuesta = proveedoresDal.Insertar(proveedor);
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = new Proveedor();
            }
            return respuesta;
        }

        public Respuesta<List<Proveedor>> Obtener()
        {
            Respuesta<List<Proveedor>> respuesta = new Respuesta<List<Proveedor>>();
            try
            {
                proveedoresDal = new ProveedoresDal();
                respuesta = proveedoresDal.Obtener();
            }
            catch (Exception oEx)
            {
                respuesta.HayError = true;
                respuesta.Mensaje = oEx.Message;
                respuesta.ObjetoRespuesta = null;
            }
            return respuesta;
        }
    }
}
