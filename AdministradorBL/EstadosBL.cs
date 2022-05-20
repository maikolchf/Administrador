using administradorDAL;
using AdministradorEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorBL
{
    public class EstadosBL
    {
        private EstadosDal estadosDal = new EstadosDal();
        public Respuesta<List<Combobox>> Obtener()
        {
            Respuesta<List<Combobox>> respuesta = new Respuesta<List<Combobox>>();
            respuesta =  estadosDal.Obtener();
            return respuesta;
        }
    }
}
