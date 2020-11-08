using System.Collections.Generic;
using System.Linq;

namespace Compilador.TablaSimbolos
{
    public class TablaPalabrasReservadas
    {
        private static Dictionary<string, List<ComponenteLexico>> Simbolos = new Dictionary<string, List<ComponenteLexico>>();
        private static Dictionary<string, ComponenteLexico> PalabrasReservadasBase = new Dictionary<string, ComponenteLexico>();
        private static bool TablaInicializada = false;

        private static void Inicializar()
        {
            PalabrasReservadasBase.Add("AND", ComponenteLexico.CrearPalabraReservada(Categoria.CONECTOR_Y, "AND"));
            PalabrasReservadasBase.Add("ASC", ComponenteLexico.CrearPalabraReservada(Categoria.ASCENDENTE, "ASC"));
            PalabrasReservadasBase.Add("BY", ComponenteLexico.CrearPalabraReservada(Categoria.BY, "BY"));
            PalabrasReservadasBase.Add("DESC", ComponenteLexico.CrearPalabraReservada(Categoria.DESCENDENTE, "DESC"));
            PalabrasReservadasBase.Add("FROM", ComponenteLexico.CrearPalabraReservada(Categoria.FROM, "FROM"));
            PalabrasReservadasBase.Add("OR", ComponenteLexico.CrearPalabraReservada(Categoria.CONECTOR_O, "OR"));
            PalabrasReservadasBase.Add("ORDER", ComponenteLexico.CrearPalabraReservada(Categoria.ORDER, "ORDER"));
            PalabrasReservadasBase.Add("SELECT", ComponenteLexico.CrearPalabraReservada(Categoria.SELECT, "SELECT"));
            PalabrasReservadasBase.Add("WHERE", ComponenteLexico.CrearPalabraReservada(Categoria.WHERE, "WHERE"));

            TablaInicializada = true;
        }

        public static ComponenteLexico ComprobarPalabraReservada(ComponenteLexico componente)
        {
            ComponenteLexico retorno = null;

            if (!TablaInicializada)
            {
                Inicializar();
            }

            if (componente != null && componente.Lexema != null && Categoria.IDENTIFICADOR.Equals(componente.Categoria) &&
                PalabrasReservadasBase.ContainsKey(componente.Lexema.ToUpper()))
            {
                retorno = ComponenteLexico.CrearPalabraReservada(PalabrasReservadasBase[componente.Lexema.ToUpper()].Categoria,
                    componente.Lexema, componente.NumeroLinea, componente.PosicionInicial, componente.PosicionFinal);
            }
            else
            {
                retorno = componente;
            }

            return retorno;
        }

        public static void Agregar(ComponenteLexico componente)
        {
            if (componente != null && TipoComponente.PALABRA_RESERVADA.Equals(componente.Tipo))
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