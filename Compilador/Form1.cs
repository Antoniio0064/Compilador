using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Compilador.Transversal;

namespace Compilador
{
    public partial class Form1 : Form
    {
        public static List<Linea> lineas = new List<Linea>();
        private int idEjecucion = 0;

        private const string ARCHIVO_NO_ENCONTRADO_INFORMACION = "Archivo Inexistente en la ruta especificada";
        private const string ARCHIVO_NO_ENCONTRADO_TITULO = "Archivo no encontrado";
        private const string CONSOLA_VACIA_INFORMACION = "Por favor ingresa texto en la consola para poder llevar a cabo el análisis";
        private const string CONSOLA_VACIA_TITULO = "Consola vacía";


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
            LimpiarConsolas();
        }

        private void LimpiarConsolas()
        {
            txtFuente.Text = string.Empty;
            txtDestino.Text = string.Empty;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtFuente.Text != string.Empty)
                PasarDeFuenteADestino();
            
            else
                MessageBox.Show(CONSOLA_VACIA_INFORMACION, CONSOLA_VACIA_TITULO, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PasarDeFuenteADestino()
        {
            idEjecucion++;

            CargarEnCache();

            LimpiarConsolas();
            
            EscribirLineaDesdeCache();

            txtDestino.Enabled = true;
            lstEjecuciones.Items.Add($"Ejecución: {idEjecucion}");
        }

        private void CargarEnCache()
        {
            for (int i = 0; i < txtFuente.Lines.Count(); i++)
            {
                int numeroCaracteres = txtFuente.Lines[i].Length;
                string contenido = txtFuente.Lines[i];
                int numeroLinea = i + 1;

                lineas.Add(new Linea(idEjecucion, numeroCaracteres, contenido, numeroLinea));
            }
        }

        private void EscribirLineaDesdeCache()
        {
            var lineasEjecucionActual = lineas.Where(l => (l.IdEjecucion == idEjecucion));

            foreach (Linea linea in lineasEjecucionActual)
            {
                string lineaSinEspacios = linea.Contenido.Trim();

                txtDestino.Text += $"{linea.NumeroLinea}->{lineaSinEspacios} {Environment.NewLine}";
            }

        }

        private void lstEjecuciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            LimpiarConsolas();

            MostrarEnConsolaEjecuionSeleccionada();
        }

        private void MostrarEnConsolaEjecuionSeleccionada()
        {

            var lineasEnEjecucion = lineas.Where(linea => (linea.IdEjecucion - 1) == lstEjecuciones.SelectedIndex);

            foreach (Linea linea in lineasEnEjecucion)
            {
                string lineaSinEspacios = linea.Contenido.Trim();
                txtFuente.Text += lineaSinEspacios + Environment.NewLine;
            }
        }
    }
}
