namespace Compilador.Transversal
{
    public class Linea
    {
        public int IdEjecucion { get; private set; }
        public string Contenido { get; private set; }
        public int NumeroLinea { get; private set; }

        public Linea(int idEjecucion, string contenido, int numeroLinea)
        {
            IdEjecucion = idEjecucion;
            Contenido = contenido;
            NumeroLinea = numeroLinea;
        }
    }
}