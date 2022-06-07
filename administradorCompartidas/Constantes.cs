using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administradorCompartidas
{
    public class Constantes
    {
        public struct valores
        {
            public const string Si = "Sí";
            public const string No = "No";
        }

        public struct EstadosGastos
        {
            public const string Pendiente = "P";
            public const string Cancelado = "C";
        } 
        
        public struct EstadosDefaul
        {
            public const string Activo = "A";
            public const string Eliminado = "E";
        }
        
    }
}
