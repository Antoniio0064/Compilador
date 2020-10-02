using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.Transversal
{
    public class Cache
    {
        private static List<Linea> Lineas = new List<Linea>();

        public static void Limpiar()
        {
            Lineas.Clear();
        }

        public static void Poblar(List<Linea> lineas)
        {
            Limpiar();

            if(lineas != null && lineas.Count > 0)
            {
                Lineas = lineas;
            }
        }

        public static void Agregar(string contenido)
        {
            if(contenido != null)
            {
                int numeroLinea = Lineas.Count + 1;

                Lineas.Add(Linea.Crear(numeroLinea, contenido));
            }
        }

        public static Linea ObtenerLinea(int numeroLinea)
        {
            Linea lineaRetorno;

            if (ExisteLinea(numeroLinea))
            {
                lineaRetorno = Lineas[numeroLinea - 1];
            }
            else
            {
                lineaRetorno = Linea.Crear(Lineas.Count + 1, "@EOF@");
            }

            return lineaRetorno;
        }

        public static bool ExisteLinea(int numeroLinea)
        {
            return ((numeroLinea > 0) && (numeroLinea <= Lineas.Count));
        }

        public static List<Linea> ObtenerLineas()
        {
            return Lineas;
        }
    }
}
