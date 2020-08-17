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
        List<Linea> lineas = new List<Linea>();
        int idEjecucion = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void rbConsola_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbConsola.Checked)
                CambiarEstadoControlesBasadoEnConsola(esConsola: true);

        }

        private void rbCargarArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbCargarArchivo.Checked)
                CambiarEstadoControlesBasadoEnConsola(esConsola: false);
        }

        private void CambiarEstadoControlesBasadoEnConsola(bool esConsola)
        {
            btnDirectorio.Enabled = esConsola;
            txtDirectorio.Enabled = esConsola;
            txtFuente.ReadOnly = esConsola;
            txtFuente.Text = esConsola ? string.Empty : txtFuente.Text;
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
                MessageBox.Show("Archivo Inexistente en la ruta especificada");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFuente.Text = string.Empty;
            txtDestino.Text = string.Empty;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            txtDestino.Text = string.Empty;

            if (txtFuente.Text != string.Empty)
            {
                PasarDeFuenteADestino();
            }
            else
                MessageBox.Show("No es posible analizar un texto sin contenido");
        }

        private void PasarDeFuenteADestino()
        {
            idEjecucion++;

            if (rbConsola.Checked)
            {
                EnumerarLinea();
                AlmacenarLineasEnLista(idEjecucion);
            }
            else if (rbCargarArchivo.Checked)
            {
                EnumerarLinea();
                AlmacenarLineasEnLista(idEjecucion);
            }

            txtFuente.Text = string.Empty;
            txtDestino.Enabled = true;
            lstEjecuciones.Items.Add($"Ejecución: {idEjecucion}");
        }

        private void EnumerarLinea()
        {
            for (int i = 0; i < txtFuente.Lines.Count(); i++)
            {
                txtDestino.Text += $"Linea{i + 1}-> {txtFuente.Lines[i]} {Environment.NewLine}";
            }
        }

        private void AlmacenarLineasEnLista(int idEjecucion)
        {
            for (int i = 0; i < txtFuente.Lines.Count(); i++)
            {
                int numeroCaracteres = txtFuente.Lines[i].Length;
                string contenido = txtFuente.Lines[i];

                lineas.Add(new Linea(idEjecucion, numeroCaracteres, contenido));
            }
        }

        private void lstEjecuciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFuente.Text = string.Empty;
            txtDestino.Text = string.Empty;

            CargarEjecuionSeleccionada();
        }

        private void CargarEjecuionSeleccionada()
        {

            var lineasEnEjecucion = lineas.Where(l => (l.IdEjecucion - 1) == lstEjecuciones.SelectedIndex);

            foreach (Linea linea in lineasEnEjecucion)
            {
                txtFuente.Text += linea.Contenido + Environment.NewLine;
            }
        }

    }
}
