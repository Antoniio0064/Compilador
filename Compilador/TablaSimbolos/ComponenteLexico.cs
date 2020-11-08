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

        public static ComponenteLexico CrearSimbolo(Categoria categoria, string lexema, int numeroLinea, int posicionInicial, int posicionFinal)
        {
            return new ComponenteLexico(categoria, lexema, numeroLinea, posicionInicial, posicionFinal, TipoComponente.SIMBOLO);
        }

        public static ComponenteLexico CrearDummy(Categoria categoria, string lexema, int numeroLinea, int posicionInicial, int posicionFinal)
        {
            return new ComponenteLexico(categoria, lexema, numeroLinea, posicionInicial, posicionFinal, TipoComponente.DUMMY);
        }

        public static ComponenteLexico CrearPalabraReservada(Categoria categoria, string lexema)
        {
            return new ComponenteLexico(categoria, lexema, -1, -1, -1, TipoComponente.PALABRA_RESERVADA);
        }

        public static ComponenteLexico CrearPalabraReservada(Categoria categoria, string lexema, int numeroLinea, int posicionInicial, int posicionFinal)
        {
            return new ComponenteLexico(categoria, lexema, numeroLinea, posicionInicial, posicionFinal, TipoComponente.PALABRA_RESERVADA);
        }

        public static ComponenteLexico CrearLiteral(Categoria categoria, string lexema, int numeroLinea, int posicionInicial, int posicionFinal)
        {
            return new ComponenteLexico(categoria, lexema, numeroLinea, posicionInicial, posicionFinal, TipoComponente.LITERAL);
        }

        public override string ToString()
        {
            string concatenador = $"Tipo Componente: {Tipo}\n" +
                $"Categoría: {Categoria}\n" +
                $"Lexema: {Lexema}\n" +
                $"Número Línea: {NumeroLinea}\n" +
                $"Posición Inicial: {PosicionInicial}\n" +
                $"Posición Final: {PosicionFinal}\n";

            return concatenador;
        }
    }
}