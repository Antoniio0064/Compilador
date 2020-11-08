using Compilador.AnalizadorLexico;
using Compilador.ManejadorErrores;
using Compilador.TablaSimbolos;
using System;
using System.Windows.Forms;

namespace Compilador.AnalizadorSintactico
{
    internal class AnalisisSintactico
    {
        private bool depuracionHabilitada = false;
        private AnalisisLexico anaLex = new AnalisisLexico();
        private ComponenteLexico componente;
        private string pilaLlamados = "";

        public void Analizar(bool depurar)
        {
            depuracionHabilitada = depurar;
            pilaLlamados = "";
            PedirComponente();
            Expresion("..");

            if (GestorErrores.HayErrores())
            {
                MessageBox.Show("Hay problemas en el proceso de compilación. Por favor verifica la consola de errores...",
                    "Compilación incorrecta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Categoria.FIN_ARCHIVO.Equals(componente.Categoria))
            {
                MessageBox.Show("El programa se compilo de forma satisfactoria sin errores",
                           "Compilación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Aunque El programa se compilo de forma satisfactoria sin errores, faltaron componentes por evaluar",
                   "Componentes sin evaluar",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PedirComponente()
        {
            componente = anaLex.FormarComponente();
        }

        private void DepurarEntrada(string indentacion, string regla)
        {
            pilaLlamados += $"{indentacion}ENTRANDO A REGLA {regla} con lexema {componente.Lexema}" +
                $" y categoría {componente.Categoria} \n";

            ImprimirTraza();
        }

        private void DepurarSalida(string indentacion, string regla)
        {
            pilaLlamados += $"{indentacion}SALIENDO DE REGLA {regla}\n";

            ImprimirTraza();
        }

        private void DepurarOperacion(string indentacion, double derecho, double izquierdo, string operacion)
        {
            pilaLlamados += $"{indentacion}REALIZANDO OPERACIÓN {izquierdo}{operacion}{derecho}\n";

            ImprimirTraza();
        }

        private void ImprimirTraza()
        {
            if (depuracionHabilitada)
            {
                MessageBox.Show(pilaLlamados);
            }
        }

        // <expresion> := <select><from><where><order>
        private void Expresion(string indentacion)
        {
            DepurarEntrada(indentacion, "<expresion>");
            string indentacionProximoNivel = indentacion + "..";

            Select(indentacionProximoNivel);
            From(indentacionProximoNivel);
            Where(indentacionProximoNivel);
            Order(indentacionProximoNivel);

            DepurarSalida(indentacion, "<expresion>");
        }

        // <select>    := SELECT<campos>
        private void Select(string indentacion)
        {
            DepurarEntrada(indentacion, "<select>");
            string indentacionProximoNivel = indentacion + "..";

            if (Categoria.SELECT.Equals(componente.Categoria))
            {
                PedirComponente();
                Campos(indentacionProximoNivel);
            }
            else
            {
                Error error = Error.CrearErrorSintactico(componente.Lexema, componente.NumeroLinea,
                        componente.PosicionInicial, componente.PosicionFinal, "select no ingresado",
                        $"Leí {componente.Lexema}", "Asegúrese que en esta posición se encuentre la palabra reservada select");

                GestorErrores.Reportar(error);

                throw new Exception("Se ha presentado un error Sintáctico que detiene el proceso. " +
                        "Por favor validar la consola de errores y solucionar el problema para realizar nuevamente el proceso" +
                        "de compilación...");
            }

            DepurarSalida(indentacion, "<select>");
        }

        // <from>	    := FROM<tablas>
        private void From(string indentacion)
        {
            DepurarEntrada(indentacion, "<from>");
            string indentacionProximoNivel = indentacion + "..";

            if (Categoria.FROM.Equals(componente.Categoria))
            {
                PedirComponente();
                Tablas(indentacionProximoNivel);
            }
            else
            {
                Error error = Error.CrearErrorSintactico(componente.Lexema, componente.NumeroLinea,
                        componente.PosicionInicial, componente.PosicionFinal, "from no ingresado",
                        $"Leí {componente.Lexema}", "Asegúrese que en esta posición se encuentre la palabra reservada from");

                GestorErrores.Reportar(error);

                throw new Exception("Se ha presentado un error Sintáctico que detiene el proceso. " +
                        "Por favor validar la consola de errores y solucionar el problema para realizar nuevamente el proceso" +
                        "de compilación...");
            }

            DepurarSalida(indentacion, "<from>");
        }

        // <where>	    := WHERE<condiciones> | EPSILON
        private void Where(string indentacion)
        {
            DepurarEntrada(indentacion, "<where>");
            string indentacionProximoNivel = indentacion + "..";

            if (Categoria.WHERE.Equals(componente.Categoria))
            {
                PedirComponente();
                Condiciones(indentacionProximoNivel);
            }

            DepurarSalida(indentacion, "<where>");
        }

        // <order>     := ORDER BY <ordenadores> | EPSILON
        private void Order(string indentacion)
        {
            DepurarEntrada(indentacion, "<order>");
            string indentacionProximoNivel = indentacion + "..";

            if (Categoria.ORDER.Equals(componente.Categoria))
            {
                PedirComponente();

                if (Categoria.BY.Equals(componente.Categoria))
                {
                    PedirComponente();
                    Ordenadores(indentacionProximoNivel);
                }
                else
                {
                    Error error = Error.CrearErrorSintactico(componente.Lexema, componente.NumeroLinea,
                            componente.PosicionInicial, componente.PosicionFinal, "no se encontró BY",
                            $"Leí {componente.Lexema}", "Asegúrese que en esta posición se encuentre la palabra reservada BY");

                    GestorErrores.Reportar(error);

                    throw new Exception("Se ha presentado un error Sintáctico que detiene el proceso. " +
                            "Por favor validar la consola de errores y solucionar el problema para realizar nuevamente el proceso" +
                            "de compilación...");
                }
            }

            DepurarSalida(indentacion, "<order>");
        }

        // <campos>    := CAMPO | CAMPOCOMA<campos>
        private void Campos(string indentacion)
        {
            DepurarEntrada(indentacion, "<campos>");
            string indentacionProximoNivel = indentacion + "..";

            if (Categoria.CAMPO.Equals(componente.Categoria))
            {
                PedirComponente();

                if (Categoria.COMA.Equals(componente.Categoria))
                {
                    PedirComponente();
                    Campos(indentacionProximoNivel);
                }
            }
            else
            {
                Error error = Error.CrearErrorSintactico(componente.Lexema, componente.NumeroLinea,
                        componente.PosicionInicial, componente.PosicionFinal, "campo no valido",
                        $"Leí {componente.Lexema}", "Asegúrese que en esta posición se encuentre un campo");

                GestorErrores.Reportar(error);

                throw new Exception("Se ha presentado un error Sintáctico que detiene el proceso. " +
                        "Por favor validar la consola de errores y solucionar el problema para realizar nuevamente el proceso" +
                        "de compilación...");
            }

            DepurarSalida(indentacion, "<campos>");
        }

        // <tablas>    := TABLA | TABLA COMA<tablas>
        private void Tablas(string indentacion)
        {
            DepurarEntrada(indentacion, "<tablas>");
            string indentacionProximoNivel = indentacion + "..";

            if (Categoria.TABLA.Equals(componente.Categoria))
            {
                PedirComponente();

                if (Categoria.COMA.Equals(componente.Categoria))
                {
                    PedirComponente();
                    Tablas(indentacionProximoNivel);
                }
            }
            else
            {
                Error error = Error.CrearErrorSintactico(componente.Lexema, componente.NumeroLinea,
                        componente.PosicionInicial, componente.PosicionFinal, "tabla no valida",
                        $"Leí {componente.Lexema}", "Asegúrese que en esta posición se encuentre una tabla");

                GestorErrores.Reportar(error);

                throw new Exception("Se ha presentado un error Sintáctico que detiene el proceso. " +
                        "Por favor validar la consola de errores y solucionar el problema para realizar nuevamente el proceso" +
                        "de compilación...");
            }

            DepurarSalida(indentacion, "<tablas>");
        }

        // <condiciones> := <operando><operador><operando><resto_condiciones>
        private void Condiciones(string indentacion)
        {
            DepurarEntrada(indentacion, "<condiciones>");
            string indentacionProximoNivel = indentacion + "..";

            Operando(indentacionProximoNivel);
            Operador(indentacionProximoNivel);
            Operando(indentacionProximoNivel);
            RestoCondiciones(indentacionProximoNivel);

            DepurarSalida(indentacion, "<condiciones>");
        }

        // <resto_condiciones> := <conector> <condiciones> | EPSILON
        // <resto_condiciones> := CONECTOR O <condiciones> | CONECTOR Y <condiciones> | EPSILON
        private void RestoCondiciones(string indentacion)
        {
            DepurarEntrada(indentacion, "<resto_condiciones>");
            string indentacionProximoNivel = indentacion + "..";

            if (Categoria.CONECTOR_O.Equals(componente.Categoria))
            {
                PedirComponente();
                Condiciones(indentacionProximoNivel);
            }
            else if (Categoria.CONECTOR_Y.Equals(componente.Categoria))
            {
                PedirComponente();
                Condiciones(indentacionProximoNivel);
            }

            DepurarSalida(indentacion, "<resto_condiciones>");
        }

        // <operando>  := CAMPO | LITERAL | NUMERO ENTERO | NUMERO DECIMAL
        private void Operando(string indentacion)
        {
            DepurarEntrada(indentacion, "<operando>");

            if (Categoria.CAMPO.Equals(componente.Categoria))
            {
                PedirComponente();
            }
            else if (Categoria.LITERAL.Equals(componente.Categoria))
            {
                PedirComponente();
            }
            else if (Categoria.NUMERO_ENTERO.Equals(componente.Categoria))
            {
                PedirComponente();
            }
            else if (Categoria.NUMERO_DECIMAL.Equals(componente.Categoria))
            {
                PedirComponente();
            }
            else
            {
                Error error = Error.CrearErrorSintactico(componente.Lexema, componente.NumeroLinea,
                        componente.PosicionInicial, componente.PosicionFinal, "operando no valido",
                        $"Leí {componente.Lexema}", "Asegúrese que en esta posición se encuentre un campo, un literal," +
                        "un número entero o un número decimal");

                GestorErrores.Reportar(error);

                throw new Exception("Se ha presentado un error Sintáctico que detiene el proceso. " +
                        "Por favor validar la consola de errores y solucionar el problema para realizar nuevamente el proceso" +
                        "de compilación...");
            }

            DepurarSalida(indentacion, "<operando>");
        }

        // <operador>  := MAYOR QUE | MENOR QUE | IGUAL QUE | MAYOR O IGUAL QUE | MENOR O IGUAL QUE | DIFERENTE QUE
        private void Operador(string indentacion)
        {
            DepurarEntrada(indentacion, "<operador>");

            if (Categoria.MAYOR_QUE.Equals(componente.Categoria))
            {
                PedirComponente();
            }
            else if (Categoria.MENOR_QUE.Equals(componente.Categoria))
            {
                PedirComponente();
            }
            else if (Categoria.IGUAL_QUE.Equals(componente.Categoria))
            {
                PedirComponente();
            }
            else if (Categoria.MAYOR_IGUAL_QUE.Equals(componente.Categoria))
            {
                PedirComponente();
            }
            else if (Categoria.MENOR_IGUAL_QUE.Equals(componente.Categoria))
            {
                PedirComponente();
            }
            else if (Categoria.DIFERENTE_QUE.Equals(componente.Categoria))
            {
                PedirComponente();
            }
            else
            {
                Error error = Error.CrearErrorSintactico(componente.Lexema, componente.NumeroLinea,
                        componente.PosicionInicial, componente.PosicionFinal, "operador no valido",
                        $"Leí {componente.Lexema}", "Asegúrese que en esta posición se encuentre un mayor que, menor que," +
                        "igual que, mayor o igual que, menor o igual que o diferente que");

                GestorErrores.Reportar(error);

                throw new Exception("Se ha presentado un error Sintáctico que detiene el proceso. " +
                        "Por favor validar la consola de errores y solucionar el problema para realizar nuevamente el proceso" +
                        "de compilación...");
            }

            DepurarSalida(indentacion, "<operador>");
        }

        // <ordenadores> := <campos> <criterio> | <indices> <criterio>
        private void Ordenadores(string indentacion)
        {
            DepurarEntrada(indentacion, "<ordenadores>");
            string indentacionProximoNivel = indentacion + "..";

            if (Categoria.CAMPO.Equals(componente.Categoria))
            {
                Campos(indentacionProximoNivel);
                Criterio(indentacionProximoNivel);
            }
            else if (Categoria.NUMERO_ENTERO.Equals(componente.Categoria))
            {
                Indices(indentacionProximoNivel);
                Criterio(indentacionProximoNivel);
            }
            else
            {
                Error error = Error.CrearErrorSintactico(componente.Lexema, componente.NumeroLinea,
                        componente.PosicionInicial, componente.PosicionFinal, "ordenador no valido",
                        $"Leí {componente.Lexema}", "Asegúrese que en esta posición se encuentre un campo o un indice");

                GestorErrores.Reportar(error);

                throw new Exception("Se ha presentado un error Sintáctico que detiene el proceso. " +
                        "Por favor validar la consola de errores y solucionar el problema para realizar nuevamente el proceso" +
                        "de compilación...");
            }

            DepurarSalida(indentacion, "<ordenadores>");
        }

        // <criterio>  := ASCENDENTE | DESCENDENTE | ASCENDENTECOMA<ordenadores> | DESCENDENTECOMA<ordenadores> | EPSILON
        private void Criterio(string indentacion)
        {
            DepurarEntrada(indentacion, "<criterio>");
            string indentacionProximoNivel = indentacion + "..";

            if (Categoria.ASCENDENTE.Equals(componente.Categoria))
            {
                PedirComponente();

                if (Categoria.COMA.Equals(componente.Categoria))
                {
                    PedirComponente();
                    Ordenadores(indentacionProximoNivel);
                }
            }
            else if (Categoria.DESCENDENTE.Equals(componente.Categoria))
            {
                PedirComponente();

                if (Categoria.COMA.Equals(componente.Categoria))
                {
                    PedirComponente();
                    Ordenadores(indentacionProximoNivel);
                }
            }

            DepurarSalida(indentacion, "<criterio>");
        }

        // <indices>   := NUMERO ENTERO | NUMERO ENTEROCOMA<indices>
        private void Indices(string indentacion)
        {
            DepurarEntrada(indentacion, "<indices>");
            string indentacionProximoNivel = indentacion + "..";

            if (Categoria.NUMERO_ENTERO.Equals(componente.Categoria))
            {
                PedirComponente();

                if (Categoria.COMA.Equals(componente.Categoria))
                {
                    PedirComponente();
                    Indices(indentacionProximoNivel);
                }
            }
            else
            {
                Error error = Error.CrearErrorSintactico(componente.Lexema, componente.NumeroLinea,
                        componente.PosicionInicial, componente.PosicionFinal, "indice no valido",
                        $"Leí {componente.Lexema}", "Asegúrese que en esta posición se encuentre un número entero");

                GestorErrores.Reportar(error);

                throw new Exception("Se ha presentado un error Sintáctico que detiene el proceso. " +
                        "Por favor validar la consola de errores y solucionar el problema para realizar nuevamente el proceso" +
                        "de compilación...");
            }

            DepurarSalida(indentacion, "<indices>");
        }
    }
}