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

namespace Prueba02
{
    public partial class Form1 : Form
    {
        List<string> cadenas = new List<string>();

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
            txtFunte.ReadOnly = esConsola;
            txtFunte.Text = string.Empty;
            txtDestino.Text = string.Empty;
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDirectorio.Text = openFileDialog1.FileName;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            txtDestino.Text = string.Empty;
            if (rbConsola.Checked)
            {
                DarFromatoFuenteADestino();
            }
            else if (rbCargarArchivo.Checked)
            {
                if (txtDirectorio.Text != string.Empty)
                {
                    try
                    {
                        TextReader leer = new StreamReader(openFileDialog1.FileName);
                        txtFunte.Text = leer.ReadToEnd();
                        leer.Close();
                        DarFromatoFuenteADestino();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Archivo Inexistente en la ruta especificada");
                    }
                }
            }
            txtDestino.Enabled = true;
        }

        private void DarFromatoFuenteADestino()
        {
            cadenas.Add(txtFunte.Text);
            for (int i = 0; i < txtFunte.Lines.Count(); i++)
            {
                txtDestino.Text += $"Linea{i+1}-> {txtFunte.Lines[i]} {Environment.NewLine}";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtFunte.Text = string.Empty;
        }

    }
}
