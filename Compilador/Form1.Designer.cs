namespace Compilador
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
            this.txtFuente = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lstEjecuciones = new System.Windows.Forms.ListBox();
            this.lblEjecuciones = new System.Windows.Forms.Label();
            this.gboxOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.Black;
            this.btnCargar.Location = new System.Drawing.Point(237, 300);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 35);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
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
            this.gboxOpciones.Text = "Opción";
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
            // txtFuente
            // 
            this.txtFuente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtFuente.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFuente.Location = new System.Drawing.Point(43, 131);
            this.txtFuente.Multiline = true;
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.Size = new System.Drawing.Size(475, 163);
            this.txtFuente.TabIndex = 0;
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDestino.Enabled = false;
            this.txtDestino.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(524, 469);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(139, 35);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar Consolas";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lstEjecuciones
            // 
            this.lstEjecuciones.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lstEjecuciones.FormattingEnabled = true;
            this.lstEjecuciones.Location = new System.Drawing.Point(543, 160);
            this.lstEjecuciones.Name = "lstEjecuciones";
            this.lstEjecuciones.Size = new System.Drawing.Size(120, 134);
            this.lstEjecuciones.TabIndex = 12;
            this.lstEjecuciones.SelectedIndexChanged += new System.EventHandler(this.lstEjecuciones_SelectedIndexChanged);
            // 
            // lblEjecuciones
            // 
            this.lblEjecuciones.AutoSize = true;
            this.lblEjecuciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjecuciones.Location = new System.Drawing.Point(524, 131);
            this.lblEjecuciones.Name = "lblEjecuciones";
            this.lblEjecuciones.Size = new System.Drawing.Size(154, 16);
            this.lblEjecuciones.TabIndex = 13;
            this.lblEjecuciones.Text = "Ejecuciones Realizadas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(708, 524);
            this.Controls.Add(this.lblEjecuciones);
            this.Controls.Add(this.lstEjecuciones);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtFuente);
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
        private System.Windows.Forms.TextBox txtFuente;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstEjecuciones;
        private System.Windows.Forms.Label lblEjecuciones;
    }
}

