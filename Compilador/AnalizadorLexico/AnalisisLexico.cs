using Compilador.ManejadorErrores;
using Compilador.TablaSimbolos;
using Compilador.Transversal;
using System;

namespace Compilador.AnalizadorLexico
{
    public class AnalisisLexico
    {
        private int numeroLineaActual;
        private int puntero;
        private string lexema = "";
        private string caracterActual;
        private Linea lineaActual;

        public AnalisisLexico()
        {
            CargarNuevaLinea();
        }

        // Cargar nueva linea (CNL)
        private void CargarNuevaLinea()
        {
            numeroLineaActual++;
            lineaActual = Cache.ObtenerLinea(numeroLineaActual);

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

        // Devolver Puntero (DP)
        private void DevolverPuntero()
        {
            puntero--;
        }

        // Leer Siguiente Carácter (LSC)
        private void LeerSiguienteCaracter()
        {
            if (lineaActual.Contenido.Equals("@EOF@"))
            {
                caracterActual = lineaActual.Contenido;
            }
            else if (puntero > lineaActual.Contenido.Length)
            {
                caracterActual = "@FL@";
                AvanzarPuntero();
            }
            else
            {
                caracterActual = lineaActual.Contenido.Substring(puntero - 1, 1);
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

        private string validarCaracterActual(string caracterActual)
        {
            caracterActual = caracterActual.Equals(" ") ? "espacio en blanco" : caracterActual;
            return caracterActual;
        }

        public ComponenteLexico FormarComponente()
        {
            ComponenteLexico componente = null;
            int estadoActual = 0;
            bool continuarAnalisis = true;
            lexema = "";

            while (continuarAnalisis)
            {
                if (estadoActual == 0)
                {
                    LeerSiguienteCaracter();
                    DevorarEspacios();

                    // Iniciar Análisis
                    if (CaracterActualEsLetra() && !CaracterActualEsC() && !CaracterActualEsT())
                    {
                        estadoActual = 1;
                        Concatenar();
                    }
                    else if (CaracterActualEsC())
                    {
                        Concatenar();
                        estadoActual = 3;
                    }
                    else if (CaracterActualEsComa())
                    {
                        Concatenar();
                        estadoActual = 9;
                    }
                    else if (CaracterActualEsT())
                    {
                        Concatenar();
                        estadoActual = 10;
                    }
                    else if (CaracterActualEsComilla())
                    {
                        Concatenar();
                        estadoActual = 16;
                    }
                    else if (CaracterActualEsDigito())
                    {
                        Concatenar();
                        estadoActual = 19;
                    }
                    else if (CaracterActualEsMenorQue())
                    {
                        Concatenar();
                        estadoActual = 25;
                    }
                    else if (CaracterActualEsMayorQue())
                    {
                        Concatenar();
                        estadoActual = 29;
                    }
                    else if (CaracterActualEsIgualQue())
                    {
                        Concatenar();
                        estadoActual = 32;
                    }
                    else if (CaracterActualEsDiferteQue())
                    {
                        Concatenar();
                        estadoActual = 33;
                    }
                    else if (CaracterActualEsFinArchivo())
                    {
                        Concatenar();
                        estadoActual = 36;
                    }
                    else if (CaracterActualEsFinLinea())
                    {
                        estadoActual = 37;
                    }
                    else
                    {
                        estadoActual = 38;
                    }
                }
                else if (estadoActual == 1)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsLetra())
                    {
                        Concatenar();
                        estadoActual = 1;
                    }
                    else
                    {
                        estadoActual = 2;
                    }
                }
                else if (estadoActual == 2)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.IDENTIFICADOR, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    componente = TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 3)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsA())
                    {
                        Concatenar();
                        estadoActual = 4;
                    }
                    else
                    {
                        estadoActual = 8;
                    }
                }
                else if (estadoActual == 4)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsM())
                    {
                        Concatenar();
                        estadoActual = 5;
                    }
                    else
                    {
                        estadoActual = 8;
                    }
                }
                else if (estadoActual == 5)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsGuionBajo())
                    {
                        Concatenar();
                        estadoActual = 6;
                    }
                    else
                    {
                        estadoActual = 8;
                    }
                }
                else if (estadoActual == 6)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsLetraODigito() || CaracterActualEsGuionBajo())
                    {
                        Concatenar();
                        estadoActual = 39;
                    }
                    else
                    {
                        estadoActual = 8;
                    }
                }
                else if (estadoActual == 39)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsLetraODigito() || CaracterActualEsGuionBajo())
                    {
                        Concatenar();
                        estadoActual = 39;
                    }
                    else
                    {
                        estadoActual = 7;
                    }
                }
                else if (estadoActual == 7)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.CAMPO, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 8)
                {
                    DevolverPuntero();

                    Error error = Error.CrearErrorLexico(lexema, numeroLineaActual, (puntero - lexema.Length),
                        (puntero - 1), "Estructura de campo no valida", $"la estructura del campo actual es {lexema}",
                        "Asegúrese que la estructura de un campo esta dada por cam_");

                    GestorErrores.Reportar(error);

                    // Crear DUMMY
                    componente = ComponenteLexico.CrearDummy(Categoria.CAMPO, "CAM_X", numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 9)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.COMA, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 10)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsA())
                    {
                        Concatenar();
                        estadoActual = 11;
                    }
                    else
                    {
                        estadoActual = 15;
                    }
                }
                else if (estadoActual == 11)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsB())
                    {
                        Concatenar();
                        estadoActual = 12;
                    }
                    else
                    {
                        estadoActual = 15;
                    }
                }
                else if (estadoActual == 12)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsGuionBajo())
                    {
                        Concatenar();
                        estadoActual = 13;
                    }
                    else
                    {
                        estadoActual = 15;
                    }
                }
                else if (estadoActual == 13)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsLetraODigito() || CaracterActualEsGuionBajo())
                    {
                        Concatenar();
                        estadoActual = 40;
                    }
                    else
                    {
                        estadoActual = 15;
                    }
                }
                else if (estadoActual == 40)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsLetraODigito() || CaracterActualEsGuionBajo())
                    {
                        Concatenar();
                        estadoActual = 40;
                    }
                    else
                    {
                        estadoActual = 14;
                    }
                }
                else if (estadoActual == 14)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.TABLA, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 15)
                {
                    DevolverPuntero();

                    Error error = Error.CrearErrorLexico(lexema, numeroLineaActual, (puntero - lexema.Length),
                        (puntero - 1), "Estructura de tabla no valida", $"la estructura de la tabla actual es {lexema}",
                        "Asegúrese que la estructura de una tabla esta dada por tab_");

                    GestorErrores.Reportar(error);

                    // Crear DUMMY
                    componente = ComponenteLexico.CrearDummy(Categoria.TABLA, "TAB_X", numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 16)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsComilla())
                    {
                        Concatenar();
                        estadoActual = 17;
                    }
                    else if (CaracterActualEsFinLinea() || CaracterActualEsFinArchivo())
                    {
                        estadoActual = 18;
                    }
                    else
                    {
                        Concatenar();
                        estadoActual = 16;
                    }
                }
                else if (estadoActual == 17)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.LITERAL, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 18)
                {
                    Error error = Error.CrearErrorLexico(lexema, numeroLineaActual, (puntero - 1),
                        puntero - 1, "Literal no cerrado correctamente", $"leí {caracterActual}",
                        "Asegúrese de poner la comilla simple al final de un literal");

                    GestorErrores.Reportar(error);

                    throw new Exception("Se ha presentado un error léxico que detiene el proceso. " +
                        "Por favor validar la consola de errores y solucionar el problema para realizar nuevamente el proceso" +
                        "de compilación...");
                }
                else if (estadoActual == 19)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsDigito())
                    {
                        Concatenar();
                        estadoActual = 19;
                    }
                    else if (CaracterActualEsPunto())
                    {
                        Concatenar();
                        estadoActual = 21;
                    }
                    else
                    {
                        estadoActual = 20;
                    }
                }
                else if (estadoActual == 20)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.NUMERO_ENTERO, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 21)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsDigito())
                    {
                        Concatenar();
                        estadoActual = 22;
                    }
                    else
                    {
                        estadoActual = 24;
                    }
                }
                else if (estadoActual == 22)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsDigito())
                    {
                        Concatenar();
                        estadoActual = 22;
                    }
                    else
                    {
                        estadoActual = 23;
                    }
                }
                else if (estadoActual == 23)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.NUMERO_DECIMAL, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 24)
                {
                    DevolverPuntero();
                    Error error = Error.CrearErrorLexico(lexema, numeroLineaActual, (puntero - lexema.Length),
                        puntero - 1, "Número Decimal No Válido",
                        $"Después del separador decimal leí {validarCaracterActual(caracterActual)}",
                        "Asegúrese de que luego del separador decimal se encuentre un dígito del 0 al 9");

                    GestorErrores.Reportar(error);

                    // Crear Componente DUMMY
                    componente = ComponenteLexico.CrearDummy(Categoria.NUMERO_DECIMAL, lexema + "0", numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 25)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsMayorQue())
                    {
                        Concatenar();
                        estadoActual = 26;
                    }
                    else if (CaracterActualEsIgualQue())
                    {
                        Concatenar();
                        estadoActual = 27;
                    }
                    else
                    {
                        estadoActual = 28;
                    }
                }
                else if (estadoActual == 26)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.DIFERENTE_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 27)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.MENOR_IGUAL_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 28)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.MENOR_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 29)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsIgualQue())
                    {
                        Concatenar();
                        estadoActual = 30;
                    }
                    else
                    {
                        estadoActual = 31;
                    }
                }
                else if (estadoActual == 30)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.MAYOR_IGUAL_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 31)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.MAYOR_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 32)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.IGUAL_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 33)
                {
                    LeerSiguienteCaracter();

                    if (CaracterActualEsIgualQue())
                    {
                        Concatenar();
                        estadoActual = 34;
                    }
                    else
                    {
                        estadoActual = 35;
                    }
                }
                else if (estadoActual == 34)
                {
                    componente = ComponenteLexico.CrearSimbolo(Categoria.DIFERENTE_QUE, lexema, numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 35)
                {
                    DevolverPuntero();
                    Error error = Error.CrearErrorLexico(lexema, numeroLineaActual, (puntero - lexema.Length),
                        puntero - 1, "Diferente Que No Valido",
                        $"Después del signo de admiración(!) leí {validarCaracterActual(caracterActual)}",
                        "Asegúrese de que luego del signo de admiración(!) este el signo igual(=)");

                    GestorErrores.Reportar(error);

                    // Crear Componente DUMMY
                    componente = ComponenteLexico.CrearDummy(Categoria.DIFERENTE_QUE, lexema + "=", numeroLineaActual,
                        (puntero - lexema.Length), (puntero - 1));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 36)
                {
                    DevolverPuntero();

                    componente = ComponenteLexico.CrearSimbolo(Categoria.FIN_ARCHIVO, lexema, numeroLineaActual,
                        (puntero + 1), (puntero + lexema.Length));

                    TablaMaestra.Agregar(componente);

                    continuarAnalisis = false;
                }
                else if (estadoActual == 37)
                {
                    estadoActual = 0;
                    CargarNuevaLinea();
                }
                else if (estadoActual == 38)
                {
                    Error error = Error.CrearErrorLexico(lexema, numeroLineaActual, (puntero - 1),
                        puntero - 1, "Símbolo No Válido", $"leí {caracterActual}",
                        "Asegúrese que los símbolos ingresados sean válidos");

                    GestorErrores.Reportar(error);

                    throw new Exception("Se ha presentado un error léxico que detiene el proceso. " +
                        "Por favor validar la consola de errores y solucionar el problema para realizar nuevamente el proceso" +
                        "de compilación...");
                }
            }

            return componente;
        }
    }
}