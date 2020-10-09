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

        private bool CaracterActualEsGuionBajo()
        {
            return "_".Equals(caracterActual);
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

        private bool CaracterActualEsPunto()
        {
            return ".".Equals(caracterActual);
        }

        #endregion Comparaciones

        private void Concatenar()
        {
            lexema += caracterActual;
        }

        public ComponenteLexico FormarComponente()
        {
            ComponenteLexico componente = null;
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
                else if (estadoActual == 1)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsE())
                    {
                        estadoActual = 2;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 7;
                    }
                }
                else if (estadoActual == 2)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsL())
                    {
                        estadoActual = 3;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 7;
                    }
                }
                else if (estadoActual == 3)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsE())
                    {
                        estadoActual = 4;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 7;
                    }
                }
                else if (estadoActual == 4)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsC())
                    {
                        estadoActual = 5;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 7;
                    }
                }
                else if (estadoActual == 5)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsT())
                    {
                        estadoActual = 6;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 7;
                    }
                }
                else if (estadoActual == 6)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.SELECT, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 7)
                {
                }
                else if (estadoActual == 8)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsA())
                    {
                        estadoActual = 9;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 17;
                    }
                }
                else if (estadoActual == 9)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsM())
                    {
                        estadoActual = 10;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 17;
                    }
                }
                else if (estadoActual == 10)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsGuionBajo())
                    {
                        estadoActual = 11;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 17;
                    }
                }
                else if (estadoActual == 11)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsLetraODigito() || CaracterActualEsGuionBajo())
                    {
                        estadoActual = 11;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 12;
                    }
                }
                else if (estadoActual == 12)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.CAMPO, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 13)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsR())
                    {
                        estadoActual = 14;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 18;
                    }
                }
                else if (estadoActual == 14)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsO())
                    {
                        estadoActual = 15;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 18;
                    }
                }
                else if (estadoActual == 15)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsM())
                    {
                        estadoActual = 16;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 18;
                    }
                }
                else if (estadoActual == 16)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.FROM, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 17)
                {
                }
                else if (estadoActual == 18)
                {
                }
                else if (estadoActual == 19)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsA())
                    {
                        estadoActual = 20;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 24;
                    }
                }
                else if (estadoActual == 20)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsB())
                    {
                        estadoActual = 21;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 24;
                    }
                }
                else if (estadoActual == 21)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsGuionBajo())
                    {
                        estadoActual = 22;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 24;
                    }
                }
                else if (estadoActual == 22)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsLetraODigito() || CaracterActualEsGuionBajo())
                    {
                        estadoActual = 22;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 24;
                    }
                }
                else if (estadoActual == 23)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.TABLA, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 24)
                {
                }
                else if (estadoActual == 25)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsH())
                    {
                        estadoActual = 26;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 30;
                    }
                }
                else if (estadoActual == 26)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsE())
                    {
                        estadoActual = 27;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 30;
                    }
                }
                else if (estadoActual == 27)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsR())
                    {
                        estadoActual = 28;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 30;
                    }
                }
                else if (estadoActual == 28)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsE())
                    {
                        estadoActual = 29;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 30;
                    }
                }
                else if (estadoActual == 29)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.WHERE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 30)
                {
                }
                else if (estadoActual == 31)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsComilla())
                    {
                        estadoActual = 32;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 31;
                        Concatenar();
                    }
                }
                else if (estadoActual == 32)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.LITERAL, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 33)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsDigito())
                    {
                        estadoActual = 33;
                        Concatenar();
                    }
                    else if (CaracterActualEsPunto())
                    {
                        estadoActual = 35;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 34;
                    }
                }
                else if (estadoActual == 34)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.NUMERO_ENTERO, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 35)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsDigito())
                    {
                        estadoActual = 36;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 37;
                    }
                }
                else if (estadoActual == 36)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsDigito())
                    {
                        estadoActual = 36;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 38;
                    }
                }
                else if (estadoActual == 37)
                {
                }
                else if (estadoActual == 38)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.NUMERO_DECIMAL, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 39)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsIgualQue())
                    {
                        estadoActual = 44;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 45;
                    }
                }
                else if (estadoActual == 40)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsMayorQue())
                    {
                        estadoActual = 41;
                        Concatenar();
                    }
                    else if (CaracterActualEsIgualQue())
                    {
                        estadoActual = 42;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 43;
                    }
                }
                else if (estadoActual == 41)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.DIFERENTE_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 42)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.MENOR_IGUAL_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 43)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.MENOR_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 44)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.MAYOR_IGUAL_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 45)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.MAYOR_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 46)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.IGUAL_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 47)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsIgualQue())
                    {
                        estadoActual = 48;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 49;
                    }
                }
                else if (estadoActual == 48)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.DIFERENTE_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 49)
                {
                }
                else if (estadoActual == 50)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsN())
                    {
                        estadoActual = 51;
                        Concatenar();
                    }
                    else if (CaracterActualEsS())
                    {
                        estadoActual = 53;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 55;
                    }
                }
                else if (estadoActual == 51)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsD())
                    {
                        estadoActual = 52;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 55;
                    }
                }
                else if (estadoActual == 52)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.CONECTOR_Y, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 53)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsC())
                    {
                        estadoActual = 54;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 55;
                    }
                }
                else if (estadoActual == 54)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.ASCENDENTE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 55)
                {
                }
                else if (estadoActual == 56)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsR())
                    {
                        estadoActual = 57;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 71;
                    }
                }
                else if (estadoActual == 57)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsD())
                    {
                        estadoActual = 65;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 66;
                    }
                }
                else if (estadoActual == 58)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsE())
                    {
                        estadoActual = 59;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 62;
                    }
                }
                else if (estadoActual == 59)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsS())
                    {
                        estadoActual = 60;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 62;
                    }
                }
                else if (estadoActual == 60)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsC())
                    {
                        estadoActual = 61;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 62;
                    }
                }
                else if (estadoActual == 61)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.DESCENDENTE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 62)
                {
                }
                else if (estadoActual == 63)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.FIN_ARCHIVO, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 64)
                {
                    estadoActual = 0;
                    CargarNuevaLinea();
                }
                else if (estadoActual == 65)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsE())
                    {
                        estadoActual = 67;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 72;
                    }
                }
                else if (estadoActual == 66)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.CONECTOR_O, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 67)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsR())
                    {
                        estadoActual = 68;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 72;
                    }
                }
                else if (estadoActual == 68)
                {
                    // Verificar lo del blanco
                    LeerSiguienteCaracter();

                    if (CaracterActualEsB())
                    {
                        estadoActual = 69;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 72;
                    }
                }
                else if (estadoActual == 69)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsY())
                    {
                        estadoActual = 70;
                        Concatenar();
                    }
                    else
                    {
                        estadoActual = 72;
                    }
                }
                else if (estadoActual == 70)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.ORDER_BY, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
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
                    componente = ComponenteLexico.CrearSimbolo(Categoria.COMA, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
            }

            return componente;
        }
    }
}