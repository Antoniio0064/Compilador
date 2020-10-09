using System.Collections.Generic;

namespace Compilador.TablaSimbolos
{
    public class TablaMaestra
    {
        public static void Agregar(ComponenteLexico componente)
        {
            if (componente != null)
            {
                switch (componente.Tipo)
                {
                    case TipoComponente.SIMBOLO:
                        TablaSimbolos.Agregar(componente);
                        break;

                    case TipoComponente.PALABRA_RESERVADA:
                        // Sincronizar con tabla palabras reservadas
                        break;

                    default:
                        TablaSimbolos.Agregar(componente);
                        break;
                }
            }
        }

        public static List<ComponenteLexico> ObtenerComponentes(TipoComponente componente)
        {
            switch (componente)
            {
                case TipoComponente.SIMBOLO:
                    return TablaSimbolos.ObtenerTodosSimbolos();
                    break;

                default:
                    return TablaSimbolos.ObtenerTodosSimbolos();
                    break;
            }
        }

        public static void Limpiar()
        {
            TablaSimbolos.Limpiar();
            // Resto de tablas a futuro
        }
    }
}