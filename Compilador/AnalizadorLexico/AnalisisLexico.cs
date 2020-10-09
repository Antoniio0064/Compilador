using Compilador.TablaSimbolos;
using Compilador.Transversal;

namespace Compilador.AnalizadorLexico
{
    public class AnalisisLexico
    {
        private int numeroLineaActual;
        private int puntero;
        private string caracterActual;
        private Linea lineaActual;

        // Cargar nueva linea (CNL)
        private void CargarNuevaLinea()
        {
            numeroLineaActual++;
            lineaActual = Transversal.Cache.ObtenerLinea(numeroLineaActual);

            if (lineaActual.Contenido.Equals("@EOF@"))
            {
                numeroLineaActual = lineaActual.Numero;
            }

            ResetearPuntero();
        }

        private void ResetearPuntero()
        {
            puntero = 1;
        }

        private void AvanzarPuntero()
        {
            puntero++;
        }

        // Devolcer Puntero (DP)
        private void DevolverPuntero()
        {
            puntero--;
        }

        // Leer Siguiente Caracter (LSC)
        private void LeerSiguienteCaracter()
        {
            if (lineaActual.Contenido.Equals("@EOF@"))
            {
                caracterActual = lineaActual.Contenido;
            }
            else if (puntero > lineaActual.Contenido.Length)
            {
                caracterActual = "@FL@";
            }
            else
            {
                caracterActual = lineaActual.Contenido.Substring(puntero, 1);
                AvanzarPuntero();
            }
        }

        private void DevorarEspacios()
        {
            while (caracterActual.Equals(" "))
            {
                LeerSiguienteCaracter();
            }
        }

        public ComponenteLexico FormarComponente()
        {
            ComponenteLexico componente;
            string lexema = "";
            int estadoActual = 0;
            bool continuarAnalisis = true;

            while (continuarAnalisis)
            {
                if (estadoActual == 0)
                {
                    LeerSiguienteCaracter();
                    DevorarEspacios();

                    // Iniciar Analisis
                }
            }

            return null;
            //return componente;
        }
    }
}