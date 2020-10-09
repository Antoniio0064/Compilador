using Compilador.TablaSimbolos;
using Compilador.Transversal;

namespace Compilador.AnalizadorLexico
{
    public class AnalisisLexico
    {
        private int numeroLineaActual;
        private int puntero;
        private string lexema = "";
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

        #region Comparaciones
        private bool CaracterActualEsLetra()
        {
            return char.IsLetter(caracterActual, 0);
        }

        private bool CaracterActualEsDigito()
        {
            return char.IsDigit(caracterActual, 0);
        }

        private bool CaracterActualEsLetraODigito()
        {
            return char.IsLetterOrDigit(caracterActual, 0);
        }

        private bool CaracterActualEsSignoPesos()
        {
            return "$".Equals(caracterActual);
        }

        private bool CaracterActualEsGuionBajo()
        {
            return "_".Equals(caracterActual);
        }

        private bool CaracterActualEsSuma()
        {
            return "+".Equals(caracterActual);
        }

        private bool CaracterActualEsResta()
        {
            return "-".Equals(caracterActual);
        }

        private bool CaracterActualEsMultiplicacion()
        {
            return "*".Equals(caracterActual);
        }

        private bool CaracterActualEsDivision()
        {
            return "/".Equals(caracterActual);
        }

        private bool CaracterActualEsModulo()
        {
            return "%".Equals(caracterActual);
        }

        private bool CaracterActualEsParentesisAbre()
        {
            return "(".Equals(caracterActual);
        }

        private bool CaracterActualEsParentesisCierra()
        {
            return ")".Equals(caracterActual);
        }

        private bool CaracterActualEsIgualQue()
        {
            return "=".Equals(caracterActual);
        }

        private bool CaracterActualEsMayorQue()
        {
            return ">".Equals(caracterActual);
        }

        private bool CaracterActualEsMenorQue()
        {
            return "<".Equals(caracterActual);
        }

        private bool CaracterActualEsDosPuntos()
        {
            return ":".Equals(caracterActual);
        }

        private bool CaracterActualEsDiferteQue()
        {
            return "!".Equals(caracterActual);
        }

        private bool CaracterActualEsFinLinea()
        {
            return "@FL@".Equals(caracterActual);
        }

        private bool CaracterActualEsFinArchivo()
        {
            return "@EOF@".Equals(caracterActual);
        }

        private bool CaracterActualEsComa()
        {
            return ",".Equals(caracterActual);
        }

        private bool CaracterActualEsS()
        {
            return ("s".Equals(caracterActual) || "S".Equals(caracterActual));
        }

        private bool CaracterActualEsE()
        {
            return ("e".Equals(caracterActual) || "E".Equals(caracterActual));
        }

        private bool CaracterActualEsL()
        {
            return ("l".Equals(caracterActual) || "L".Equals(caracterActual));
        }

        private bool CaracterActualEsC()
        {
            return ("c".Equals(caracterActual) || "C".Equals(caracterActual));
        }

        private bool CaracterActualEsT()
        {
            return ("t".Equals(caracterActual) || "T".Equals(caracterActual));
        }

        private bool CaracterActualEsA()
        {
            return ("a".Equals(caracterActual) || "A".Equals(caracterActual));
        }

        private bool CaracterActualEsM()
        {
            return ("m".Equals(caracterActual) || "M".Equals(caracterActual));
        }

        private bool CaracterActualEsF()
        {
            return ("f".Equals(caracterActual) || "F".Equals(caracterActual));
        }

        private bool CaracterActualEsR()
        {
            return ("r".Equals(caracterActual) || "R".Equals(caracterActual));
        }

        private bool CaracterActualEsO()
        {
            return ("o".Equals(caracterActual) || "O".Equals(caracterActual));
        }

        private bool CaracterActualEsB()
        {
            return ("b".Equals(caracterActual) || "B".Equals(caracterActual));
        }

        private bool CaracterActualEsW()
        {
            return ("w".Equals(caracterActual) || "W".Equals(caracterActual));
        }

        private bool CaracterActualEsH()
        {
            return ("h".Equals(caracterActual) || "H".Equals(caracterActual));
        }

        private bool CaracterActualEsN()
        {
            return ("n".Equals(caracterActual) || "N".Equals(caracterActual));
        }

        private bool CaracterActualEsD()
        {
            return ("d".Equals(caracterActual) || "D".Equals(caracterActual));
        }

        private bool CaracterActualEsY()
        {
            return ("y".Equals(caracterActual) || "Y".Equals(caracterActual));
        }
        private bool CaracterActualEsComilla()
        {
            return "'".Equals(caracterActual);
        } 
        #endregion

        private void Concatenar()
        {
            lexema += caracterActual;
        }

        public ComponenteLexico FormarComponente()
        {
            ComponenteLexico componente;
            lexema = "";
            int estadoActual = 0;
            bool continuarAnalisis = true;

            while (continuarAnalisis)
            {
                if (estadoActual == 0)
                {
                    LeerSiguienteCaracter();
                    DevorarEspacios();

                    // Iniciar Analisis
                    if (CaracterActualEsS())
                    {
                        estadoActual = 1;
                        Concatenar();
                    }
                    else if (CaracterActualEsC())
                    {
                        estadoActual = 8;
                        Concatenar();
                    }
                    else if (CaracterActualEsComa())
                    {
                        estadoActual = 74;
                        Concatenar();
                    }
                    else if (CaracterActualEsF())
                    {
                        estadoActual = 13;
                        Concatenar();
                    }
                    else if (CaracterActualEsT())
                    {
                        estadoActual = 19;
                        Concatenar();
                    }
                    else if (CaracterActualEsW())
                    {
                        estadoActual = 25;
                        Concatenar();
                    }
                    else if (CaracterActualEsComilla())
                    {
                        estadoActual = 31;
                        Concatenar();
                    }
                    else if (CaracterActualEsDigito())
                    {
                        estadoActual = 33;
                        Concatenar();
                    }
                    else if (CaracterActualEsMenorQue())
                    {
                        estadoActual = 40;
                        Concatenar();
                    }
                    else if (CaracterActualEsMayorQue())
                    {
                        estadoActual = 39;
                        Concatenar();
                    }
                    else if (CaracterActualEsIgualQue())
                    {
                        estadoActual = 46;
                        Concatenar();
                    }
                    else if (CaracterActualEsDiferteQue())
                    {
                        estadoActual = 47;
                        Concatenar();
                    }
                    else if (CaracterActualEsA())
                    {
                        estadoActual = 50;
                        Concatenar();
                    }
                    else if (CaracterActualEsO())
                    {
                        estadoActual = 56;
                        Concatenar();
                    }
                    else if (CaracterActualEsD())
                    {
                        estadoActual = 58;
                        Concatenar();
                    }
                    else if (CaracterActualEsFinArchivo())
                    {
                        estadoActual = 63;
                        Concatenar();
                    }
                    else if (CaracterActualEsFinLinea())
                    {
                        estadoActual = 64;
                    }
                    else
                    {
                        estadoActual = 73;
                    }
                }
                else if(estadoActual == 1)
                {

                }
                else if (estadoActual == 2)
                {

                }
                else if (estadoActual == 3)
                {

                }
                else if (estadoActual == 4)
                {

                }
                else if (estadoActual == 5)
                {

                }
                else if (estadoActual == 6)
                {

                }
                else if (estadoActual == 7)
                {

                }
                else if (estadoActual == 8)
                {

                }
                else if (estadoActual == 9)
                {

                }
                else if (estadoActual == 10)
                {

                }
                else if (estadoActual == 11)
                {

                }
                else if (estadoActual == 12)
                {

                }
                else if (estadoActual == 13)
                {

                }
                else if (estadoActual == 14)
                {

                }
                else if (estadoActual == 15)
                {

                }
                else if (estadoActual == 16)
                {

                }
                else if (estadoActual == 17)
                {

                }
                else if (estadoActual == 18)
                {

                }
                else if (estadoActual == 19)
                {

                }
                else if (estadoActual == 20)
                {

                }
                else if (estadoActual == 21)
                {

                }
                else if (estadoActual == 22)
                {

                }
                else if (estadoActual == 23)
                {

                }
                else if (estadoActual == 24)
                {

                }
                else if (estadoActual == 25)
                {

                }
                else if (estadoActual == 26)
                {

                }
                else if (estadoActual == 27)
                {

                }
                else if (estadoActual == 28)
                {

                }
                else if (estadoActual == 29)
                {

                }
                else if (estadoActual == 30)
                {

                }
                else if (estadoActual == 31)
                {

                }
                else if (estadoActual == 32)
                {

                }
                else if (estadoActual == 33)
                {

                }
                else if (estadoActual == 34)
                {

                }
                else if (estadoActual == 35)
                {

                }
                else if (estadoActual == 36)
                {

                }
                else if (estadoActual == 37)
                {

                }
                else if (estadoActual == 38)
                {

                }
                else if (estadoActual == 39)
                {

                }
                else if (estadoActual == 40)
                {

                }
                else if (estadoActual == 41)
                {

                }
                else if (estadoActual == 42)
                {

                }
                else if (estadoActual == 43)
                {

                }
                else if (estadoActual == 44)
                {

                }
                else if (estadoActual == 45)
                {

                }
                else if (estadoActual == 46)
                {

                }
                else if (estadoActual == 47)
                {

                }
                else if (estadoActual == 48)
                {

                }
                else if (estadoActual == 49)
                {

                }
                else if (estadoActual == 50)
                {

                }
                else if (estadoActual == 51)
                {

                }
                else if (estadoActual == 52)
                {

                }
                else if (estadoActual == 53)
                {

                }
                else if (estadoActual == 54)
                {

                }
                else if (estadoActual == 55)
                {

                }
                else if (estadoActual == 56)
                {

                }
                else if (estadoActual == 57)
                {

                }
                else if (estadoActual == 58)
                {

                }
                else if (estadoActual == 59)
                {

                }
                else if (estadoActual == 60)
                {

                }
                else if (estadoActual == 61)
                {

                }
                else if (estadoActual == 62)
                {

                }
                else if (estadoActual == 63)
                {

                }
                else if (estadoActual == 64)
                {

                }
                else if (estadoActual == 65)
                {

                }
                else if (estadoActual == 66)
                {

                }
                else if (estadoActual == 67)
                {

                }
                else if (estadoActual == 68)
                {

                }
                else if (estadoActual == 69)
                {

                }
                else if (estadoActual == 70)
                {

                }
                else if (estadoActual == 71)
                {

                }
                else if (estadoActual == 72)
                {

                }
                else if (estadoActual == 73)
                {

                }
                else if (estadoActual == 74)
                {

                }
            }

            return null;
            //return componente;
        }
    }
}