using System;
using System.Collections.Generic;

namespace Compilador.TablaSimbolos
{
    public class TablaMaestra
    {
        public static ComponenteLexico Agregar(ComponenteLexico componente)
        {
            if (componente != null)
            {
                componente = TablaPalabrasReservadas.ComprobarPalabraReservada(componente);
                componente = TablaLiterales.ComprobarLiteral(componente);

                switch (componente.Tipo)
                {
                    case TipoComponente.SIMBOLO:
                        TablaSimbolos.Agregar(componente);
                        break;

                    case TipoComponente.DUMMY:
                        TablaDummys.Agregar(componente);
                        break;

                    case TipoComponente.PALABRA_RESERVADA:
                        TablaPalabrasReservadas.Agregar(componente);
                        break;

                    case TipoComponente.LITERAL:
                        TablaLiterales.Agregar(componente);
                        break;

                    default:
                        throw new Exception("Tipo de componente léxico no soportado!");
                }
            }
            return componente;
        }

        public static List<ComponenteLexico> ObtenerComponentes(TipoComponente componente)
        {
            switch (componente)
            {
                case TipoComponente.SIMBOLO:
                    return TablaSimbolos.ObtenerTodosSimbolos();

                case TipoComponente.DUMMY:
                    return TablaDummys.ObtenerTodosSimbolos();

                case TipoComponente.PALABRA_RESERVADA:
                    return TablaPalabrasReservadas.ObtenerTodosSimbolos();

                case TipoComponente.LITERAL:
                    return TablaLiterales.ObtenerTodosSimbolos();

                default:
                    throw new Exception("Tipo de componente léxico no soportado!");
            }
        }

        public static void Limpiar()
        {
            TablaSimbolos.Limpiar();
            TablaDummys.Limpiar();
            TablaLiterales.Limpiar();
            TablaPalabrasReservadas.Limpiar();
        }
    }
}