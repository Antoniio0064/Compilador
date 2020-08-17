using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal
{
    class Linea
    {
        public int IdEjecucion { get; private set; }
        public int NumeroCaracteres { get; private set; }
        public string Contenido { get; private set; }

        public Linea(int idEjecucion, int numeroCaracteres, string contenido)
        {
            IdEjecucion = idEjecucion;
            NumeroCaracteres = numeroCaracteres;
            Contenido = contenido;
        }
    }
}
