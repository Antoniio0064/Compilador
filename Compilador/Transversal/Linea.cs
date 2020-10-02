namespace Compilador.Transversal
{
    public class Linea
    {
        private int numero;
        private string contenido;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Contenido
        {
            get { return contenido; }
            set 
            {
                if (value == null)
                    contenido = "";
                else
                    contenido = value;

            }
        }

        private Linea(int numero, string contenido)
        {
            Numero = numero;
            Contenido = contenido;
        }

        public static Linea Crear(int numero, string contenido)
        {
            return new Linea(numero, contenido);
        }
    }
}