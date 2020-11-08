using System.Collections.Generic;
using System.Linq;

namespace Compilador.ManejadorErrores
{
    public class GestorErrores
    {
        private static Dictionary<TipoError, List<Error>> Errores = new Dictionary<TipoError, List<Error>>();

        public static void Limpiar()
        {
            Errores.Clear();
        }

        public static List<Error> ObtenerErrores(TipoError tipo)
        {
            if (!Errores.ContainsKey(tipo))
            {
                Errores.Add(tipo, new List<Error>());
            }

            return Errores[tipo];
        }

        public static void Reportar(Error error)
        {
            if (error != null)
            {
                ObtenerErrores(error.Tipo).Add(error);
            }
        }

        public static bool HayErrores(TipoError tipo)
        {
            return ObtenerErrores(tipo).Count > 0;
        }

        public static bool HayErrores()
        {
            return HayErrores(TipoError.LEXICO) || HayErrores(TipoError.SINTACTICO) || HayErrores(TipoError.SEMANTICO);
        }

        public static List<Error> ObtenerTodosErrores()
        {
            return Errores.Values.SelectMany(e => e).ToList();
        }
    }
}