namespace Compilador.Transversal
{
    public class Linea
    {
        public string Contenido { get; private set; }
        public int NumeroLinea { get; private set; }

        public Linea(string contenido, int numeroLinea)
        {
            Contenido = contenido;
            NumeroLinea = numeroLinea;
        }
    }
}