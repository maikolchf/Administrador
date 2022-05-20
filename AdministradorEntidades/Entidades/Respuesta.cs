using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorEntidades.Entidades
{
    public class Respuesta<T>
    {
        public bool HayError { get; set; }
        public string Mensaje { get; set; }
        public T ObjetoRespuesta { get; set; }

    }
}
