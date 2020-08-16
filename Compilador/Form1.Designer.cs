namespace Prueba02
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.gboxOpciones = new System.Windows.Forms.GroupBox();
            this.rbCargarArchivo = new System.Windows.Forms.RadioButton();
            this.rbConsola = new System.Windows.Forms.RadioButton();
            this.txtFunte = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gboxOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(238, 300);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Enabled = false;
            this.txtDirectorio.Location = new System.Drawing.Point(135, 83);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.ReadOnly = true;
            this.txtDirectorio.Size = new System.Drawing.Size(383, 20);
            this.txtDirectorio.TabIndex = 5;
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Enabled = false;
            this.btnDirectorio.Location = new System.Drawing.Point(43, 81);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(86, 23);
            this.btnDirectorio.TabIndex = 6;
            this.btnDirectorio.Text = "Buscar";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // gboxOpciones
            // 
            this.gboxOpciones.Controls.Add(this.rbCargarArchivo);
            this.gboxOpciones.Controls.Add(this.rbConsola);
            this.gboxOpciones.Location = new System.Drawing.Point(43, 12);
            this.gboxOpciones.Name = "gboxOpciones";
            this.gboxOpciones.Size = new System.Drawing.Size(286, 63);
            this.gboxOpciones.TabIndex = 7;
            this.gboxOpciones.TabStop = false;
            this.gboxOpciones.Text = "Opcion";
            // 
            // rbCargarArchivo
            // 
            this.rbCargarArchivo.AutoSize = true;
            this.rbCargarArchivo.Location = new System.Drawing.Point(161, 19);
            this.rbCargarArchivo.Name = "rbCargarArchivo";
            this.rbCargarArchivo.Size = new System.Drawing.Size(108, 17);
            this.rbCargarArchivo.TabIndex = 1;
            this.rbCargarArchivo.Text = "Cargar archivo txt";
            this.rbCargarArchivo.UseVisualStyleBackColor = true;
            this.rbCargarArchivo.CheckedChanged += new System.EventHandler(this.rbCargarArchivo_CheckedChanged);
            // 
            // rbConsola
            // 
            this.rbConsola.AutoSize = true;
            this.rbConsola.Checked = true;
            this.rbConsola.Location = new System.Drawing.Point(58, 19);
            this.rbConsola.Name = "rbConsola";
            this.rbConsola.Size = new System.Drawing.Size(63, 17);
            this.rbConsola.TabIndex = 0;
            this.rbConsola.TabStop = true;
            this.rbConsola.Text = "Consola";
            this.rbConsola.UseVisualStyleBackColor = true;
            this.rbConsola.CheckedChanged += new System.EventHandler(this.rbConsola_CheckedChanged);
            // 
            // txtFunte
            // 
            this.txtFunte.Location = new System.Drawing.Point(43, 131);
            this.txtFunte.Multiline = true;
            this.txtFunte.Name = "txtFunte";
            this.txtFunte.Size = new System.Drawing.Size(475, 163);
            this.txtFunte.TabIndex = 8;
            // 
            // txtDestino
            // 
            this.txtDestino.Enabled = false;
            this.txtDestino.Location = new System.Drawing.Point(43, 341);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(475, 163);
            this.txtDestino.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "miArchivo";
            this.openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(524, 271);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar Consola";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 516);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtFunte);
            this.Controls.Add(this.gboxOpciones);
            this.Controls.Add(this.btnDirectorio);
            this.Controls.Add(this.txtDirectorio);
            this.Controls.Add(this.btnCargar);
            this.Name = "Form1";
            this.Text = "Compilador";
            this.gboxOpciones.ResumeLayout(false);
            this.gboxOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.GroupBox gboxOpciones;
        private System.Windows.Forms.RadioButton rbCargarArchivo;
        private System.Windows.Forms.RadioButton rbConsola;
        private System.Windows.Forms.TextBox txtFunte;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

