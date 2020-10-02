using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador.TablaSimbolos
{
    public class ComponenteLexico
    {
        public Categoria Categoria { get; private set; }
        public string Lexema { get; private set; }
        public int NumeroLinea { get; private set; }
        public int PosicionInicial { get; private set; }
        public int PosicionFinal { get; private set; }
        public TipoComponente Tipo { get; private set; }

        private ComponenteLexico(Categoria categoria, string lexema, int numeroLinea, int posicionInicial, int posicionFinal, TipoComponente tipo)
        {
            Categoria = categoria;
            Lexema = (lexema == null) ? "" : lexema;
            NumeroLinea = numeroLinea;
            PosicionInicial = posicionInicial;
            PosicionFinal = posicionFinal;
            Tipo = tipo;
        }

        private static ComponenteLexico CrearSimbolo(Categoria categoria, string lexema, int numeroLinea, int posicionInicial, int posicionFinal)
        {
            return new ComponenteLexico(categoria, lexema, numeroLinea, posicionInicial, posicionFinal, TipoComponente.SIMBOLO);
        }
    }
}
