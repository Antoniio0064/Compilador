using Compilador.AnalizadorLexico;
using Compilador.TablaSimbolos;
using Compilador.Transversal;
using Compilador.ManejadorErrores;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Compilador.AnalizadorSintactico;

namespace Compilador
{
    public partial class Form1 : Form
    {
        private const string ARCHIVO_NO_ENCONTRADO_INFORMACION = "Archivo Inexistente en la ruta especificada";
        private const string ARCHIVO_NO_ENCONTRADO_TITULO = "Archivo no encontrado";
        private const string CONSOLA_VACIA_INFORMACION = "Por favor ingresa texto en la consola para poder llevar a cabo el análisis";
        private const string CONSOLA_VACIA_TITULO = "Consola vacía";
        private const string COMPILACION_INCORRECTA_INFORMACION = "Se encontraron errores durante el proceso de compilación";
        private const string COMPILACION_INCORRECTA_TITULO = "Compilación Incorrecta";
        private const string COMPILACION_CORRECTA_INFORMACION = "El proceso de compilación se ha llevado a cabo de manera exitosa";
        private const string COMPILACION_CORRECTA_TITULO = "Compilación Exitosa";

        public Form1()
        {
            InitializeComponent();
        }

        private void rbConsola_CheckedChanged(object sender, EventArgs e)
        {
            if (rbConsola.Checked)
                ActivarControlesBasadoEnCargarArchivos(esCargarArchivo: false);
        }

        private void rbCargarArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCargarArchivo.Checked)
                ActivarControlesBasadoEnCargarArchivos(esCargarArchivo: true);
        }

        private void ActivarControlesBasadoEnCargarArchivos(bool esCargarArchivo)
        {
            btnDirectorio.Enabled = esCargarArchivo;
            txtDirectorio.Enabled = esCargarArchivo;
            txtFuente.ReadOnly = esCargarArchivo;
            txtFuente.Text = esCargarArchivo ? string.Empty : txtFuente.Text;
            txtDestino.Text = string.Empty;
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            BuscarArchivoMostrarRuta();
        }

        private void BuscarArchivoMostrarRuta()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDirectorio.Text = openFileDialog1.FileName;

                LeerArchivoTextoPonerEnFuente();
            }
        }

        private void LeerArchivoTextoPonerEnFuente()
        {
            try
            {
                TextReader leer = new StreamReader(openFileDialog1.FileName);
                txtFuente.Text = leer.ReadToEnd();
                leer.Close();
            }
            catch (Exception)
            {
                MessageBox.Show(ARCHIVO_NO_ENCONTRADO_INFORMACION,
                    ARCHIVO_NO_ENCONTRADO_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Inicializar(true);
        }

        private void LimpiarConsolas()
        {
            txtFuente.Text = string.Empty;
            txtDestino.Text = string.Empty;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtFuente.Text.Equals(""))
                MessageBox.Show(CONSOLA_VACIA_INFORMACION, CONSOLA_VACIA_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Compilar();
        }

        private void Compilar()
        {
            Inicializar(false);
            txtDestino.Text = string.Empty;
            CargarEnCache();

            #region Análisis Sintáctico

            AnalisisSintactico analisisSintactico = new AnalisisSintactico();
            //Lectura Bandera de depuración
            bool depuracion = cbxDepuracion.Checked;

            try
            {
                analisisSintactico.Analizar(depuracion);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Excepción presentada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LlenarTodasTablas();
                if (GestorErrores.HayErrores())
                {
                    AgregarErroresTablaErrores();
                }
                else
                {
                    LimpiarConsolas();

                    EscribirLineaDesdeCache();

                    txtDestino.Enabled = true;
                }
            }

            #endregion Análisis Sintáctico

            #region Análisis Léxico

            //AnalisisLexico analisisLexico = new AnalisisLexico();
            //ComponenteLexico componente = null;
            //try
            //{
            //    do
            //    {
            //        componente = analisisLexico.FormarComponente();

            //    } while (!componente.Categoria.Equals(Categoria.FIN_ARCHIVO));

            //    LlenarTodasTablas();

            //    if (GestorErrores.HayErrores())
            //    {
            //        AgregarErroresTablaErrores();

            //        MessageBox.Show(COMPILACION_INCORRECTA_INFORMACION,
            //            COMPILACION_INCORRECTA_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        LimpiarConsolas();

            //        EscribirLineaDesdeCache();

            //        txtDestino.Enabled = true;

            //        MessageBox.Show(COMPILACION_CORRECTA_INFORMACION,
            //            COMPILACION_CORRECTA_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception e)
            //{
            //    LlenarTodasTablas();

            //    if (GestorErrores.HayErrores())
            //    {
            //        AgregarErroresTablaErrores();
            //    }
            //    MessageBox.Show(e.Message, "Excepción Presentada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            #endregion Análisis Léxico
        }

        private void CargarEnCache()
        {
            List<Linea> lineas = new List<Linea>();

            for (int i = 0; i < txtFuente.Lines.Count(); i++)
            {
                string contenido = txtFuente.Lines[i];
                int numeroLinea = i + 1;
                lineas.Add(Linea.Crear(numeroLinea, contenido));
            }

            Cache.Poblar(lineas);
        }

        private void EscribirLineaDesdeCache()
        {
            List<Linea> lineasCache = Cache.ObtenerLineas();

            foreach (Linea linea in lineasCache)
            {
                txtDestino.Text += $"{linea.Numero}->{linea.Contenido} {Environment.NewLine}";
            }
        }

        private void Inicializar(bool incluirConsola)
        {
            TablaMaestra.Limpiar();
            GestorErrores.Limpiar();
            dgvTablaSimbolos.Rows.Clear();
            dgvTablaErrores.Rows.Clear();
            dgvTablaDummys.Rows.Clear();
            dgvTablaLiterales.Rows.Clear();
            dgvTablaPalabrasReservadas.Rows.Clear();

            if (incluirConsola)
                LimpiarConsolas();
        }

        private void AgregarComponentesTablaSimbolos()
        {
            List<ComponenteLexico> componentesSimbolos = TablaMaestra.ObtenerComponentes(TipoComponente.SIMBOLO);

            foreach (ComponenteLexico componente in componentesSimbolos)
            {
                int fila = dgvTablaSimbolos.Rows.Count - 1;

                dgvTablaSimbolos.Rows.Add();
                dgvTablaSimbolos[0, fila].Value = fila + 1;
                dgvTablaSimbolos[1, fila].Value = componente.Lexema;
                dgvTablaSimbolos[2, fila].Value = componente.Categoria;
                dgvTablaSimbolos[3, fila].Value = componente.NumeroLinea;
                dgvTablaSimbolos[4, fila].Value = componente.PosicionInicial;
                dgvTablaSimbolos[5, fila].Value = componente.PosicionFinal;
            }
        }

        private void AgregarComponentesTablaPalabrasReservadas()
        {
            List<ComponenteLexico> componentesPalabraReservada = TablaMaestra.ObtenerComponentes(TipoComponente.PALABRA_RESERVADA);

            foreach (ComponenteLexico componente in componentesPalabraReservada)
            {
                int fila = dgvTablaPalabrasReservadas.Rows.Count - 1;

                dgvTablaPalabrasReservadas.Rows.Add();
                dgvTablaPalabrasReservadas[0, fila].Value = fila + 1;
                dgvTablaPalabrasReservadas[1, fila].Value = componente.Lexema;
                dgvTablaPalabrasReservadas[2, fila].Value = componente.Categoria;
                dgvTablaPalabrasReservadas[3, fila].Value = componente.NumeroLinea;
                dgvTablaPalabrasReservadas[4, fila].Value = componente.PosicionInicial;
                dgvTablaPalabrasReservadas[5, fila].Value = componente.PosicionFinal;
            }
        }

        private void AgregarComponenteTablaLiterales()
        {
            List<ComponenteLexico> componentesLiteral = TablaMaestra.ObtenerComponentes(TipoComponente.LITERAL);

            foreach (ComponenteLexico componente in componentesLiteral)
            {
                int fila = dgvTablaLiterales.Rows.Count - 1;

                dgvTablaLiterales.Rows.Add();
                dgvTablaLiterales[0, fila].Value = fila + 1;
                dgvTablaLiterales[1, fila].Value = componente.Lexema;
                dgvTablaLiterales[2, fila].Value = componente.Categoria;
                dgvTablaLiterales[3, fila].Value = componente.NumeroLinea;
                dgvTablaLiterales[4, fila].Value = componente.PosicionInicial;
                dgvTablaLiterales[5, fila].Value = componente.PosicionFinal;
            }
        }

        private void AgregarComponenteTablaDummys()
        {
            List<ComponenteLexico> componentesDummy = TablaMaestra.ObtenerComponentes(TipoComponente.DUMMY);

            foreach (ComponenteLexico componente in componentesDummy)
            {
                int fila = dgvTablaDummys.Rows.Count - 1;

                dgvTablaDummys.Rows.Add();
                dgvTablaDummys[0, fila].Value = fila + 1;
                dgvTablaDummys[1, fila].Value = componente.Lexema;
                dgvTablaDummys[2, fila].Value = componente.Categoria;
                dgvTablaDummys[3, fila].Value = componente.NumeroLinea;
                dgvTablaDummys[4, fila].Value = componente.PosicionInicial;
                dgvTablaDummys[5, fila].Value = componente.PosicionFinal;
                dgvTablaDummys[6, fila].Value = componente.Tipo;
            }
        }

        private void AgregarErroresTablaErrores()
        {
            List<Error> errores = GestorErrores.ObtenerTodosErrores();

            foreach (Error error in errores)
            {
                int fila = dgvTablaErrores.Rows.Count - 1;

                dgvTablaErrores.Rows.Add();
                dgvTablaErrores[0, fila].Value = fila + 1;
                dgvTablaErrores[1, fila].Value = error.Lexema;
                dgvTablaErrores[2, fila].Value = error.NumeroLinea;
                dgvTablaErrores[3, fila].Value = error.PosicionInicial;
                dgvTablaErrores[4, fila].Value = error.PosicionFinal;
                dgvTablaErrores[5, fila].Value = error.Falla;
                dgvTablaErrores[6, fila].Value = error.Causa;
                dgvTablaErrores[7, fila].Value = error.Solucion;
                dgvTablaErrores[8, fila].Value = error.Tipo;
            }
        }

        private void LlenarTodasTablas()
        {
            AgregarComponentesTablaSimbolos();

            AgregarComponenteTablaDummys();

            AgregarComponentesTablaPalabrasReservadas();

            AgregarComponenteTablaLiterales();
        }
    }
}