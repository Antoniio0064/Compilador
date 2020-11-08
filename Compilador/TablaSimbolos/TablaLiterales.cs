using System.Collections.Generic;
using System.Linq;

namespace Compilador.TablaSimbolos
{
    public class TablaLiterales
    {
        private static Dictionary<string, List<ComponenteLexico>> Simbolos = new Dictionary<string, List<ComponenteLexico>>();

        public static void Agregar(ComponenteLexico componente)
        {
            if (componente != null && TipoComponente.LITERAL.Equals(componente.Tipo))
            {
                ObtenerSimbolo(componente.Lexema).Add(componente);
            }
        }

        public static ComponenteLexico ComprobarLiteral(ComponenteLexico componente)
        {
            if (componente.Tipo.Equals(TipoComponente.DUMMY))
                return componente;

            ComponenteLexico retorno = null;

            if (componente != null && (Categoria.NUMERO_DECIMAL.Equals(componente.Categoria) || Categoria.NUMERO_ENTERO.Equals(componente.Categoria) || Categoria.LITERAL.Equals(componente.Categoria)))
            {
                retorno = ComponenteLexico.CrearLiteral(componente.Categoria, componente.Lexema, componente.NumeroLinea, componente.PosicionInicial,
                    componente.PosicionFinal);
            }
            else
            {
                retorno = componente;
            }

            return retorno;
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