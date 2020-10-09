using System.Collections.Generic;
using System.Linq;

namespace Compilador.TablaSimbolos
{
    public class TablaSimbolos
    {
        private static Dictionary<string, List<ComponenteLexico>> Simbolos = new Dictionary<string, List<ComponenteLexico>>();

        public static void Agregar(ComponenteLexico componente)
        {
            if (componente != null && TipoComponente.SIMBOLO.Equals(componente.Tipo))
            {
                ObtenerSimbolo(componente.Lexema).Add(componente);
            }
        }

        public static List<ComponenteLexico> ObtenerSimbolo(string lexema)
        {
            if (!Simbolos.ContainsKey(lexema))
            {
                Simbolos.Add(lexema, new List<ComponenteLexico>());
            }

            return Simbolos[lexema];
        }

        public static List<ComponenteLexico> ObtenerTodosSimbolos()
        {
            return Simbolos.Values.SelectMany(componente => componente).ToList();
        }

        public static void Limpiar()
        {
            Simbolos.Clear();
        }
    }
}