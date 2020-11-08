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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtFuente = new System.Windows.Forms.TextBox();
            this.gboxOpciones = new System.Windows.Forms.GroupBox();
            this.rbCargarArchivo = new System.Windows.Forms.RadioButton();
            this.rbConsola = new System.Windows.Forms.RadioButton();
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTablaDummys = new System.Windows.Forms.DataGridView();
            this.txtIdentificadorDummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLexemaDummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoriaDummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNLineaDummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPosInicialDummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPosFinalDummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipoComponente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTablaSimbolos = new System.Windows.Forms.DataGridView();
            this.txtIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPosInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPosFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvTablaErrores = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCausa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvTablaPalabrasReservadas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvTablaLiterales = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDepuracion = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gboxOpciones.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDummys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaErrores)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPalabrasReservadas)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaLiterales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "miArchivo";
            this.openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 572);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.txtDestino);
            this.tabPage1.Controls.Add(this.txtFuente);
            this.tabPage1.Controls.Add(this.gboxOpciones);
            this.tabPage1.Controls.Add(this.btnDirectorio);
            this.tabPage1.Controls.Add(this.txtDirectorio);
            this.tabPage1.Controls.Add(this.btnCargar);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(746, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(302, 501);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(139, 35);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Restablecer";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtDestino.Enabled = false;
            this.txtDestino.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestino.Location = new System.Drawing.Point(57, 332);
            this.txtDestino.Multiline = true;
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDestino.Size = new System.Drawing.Size(630, 163);
            this.txtDestino.TabIndex = 16;
            // 
            // txtFuente
            // 
            this.txtFuente.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtFuente.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuente.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtFuente.Location = new System.Drawing.Point(57, 122);
            this.txtFuente.Multiline = true;
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFuente.Size = new System.Drawing.Size(630, 163);
            this.txtFuente.TabIndex = 11;
            // 
            // gboxOpciones
            // 
            this.gboxOpciones.BackColor = System.Drawing.Color.Transparent;
            this.gboxOpciones.Controls.Add(this.rbCargarArchivo);
            this.gboxOpciones.Controls.Add(this.rbConsola);
            this.gboxOpciones.Location = new System.Drawing.Point(96, 8);
            this.gboxOpciones.Name = "gboxOpciones";
            this.gboxOpciones.Size = new System.Drawing.Size(286, 63);
            this.gboxOpciones.TabIndex = 15;
            this.gboxOpciones.TabStop = false;
            this.gboxOpciones.Text = "Opción";
            // 
            // rbCargarArchivo
            // 
            this.rbCargarArchivo.AutoSize = true;
            this.rbCargarArchivo.Location = new System.Drawing.Point(161, 19);
            this.rbCargarArchivo.Name = "rbCargarArchivo";
            this.rbCargarArchivo.Size = new System.Drawing.Size(126, 17);
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
            this.rbConsola.Size = new System.Drawing.Size(70, 17);
            this.rbConsola.TabIndex = 0;
            this.rbConsola.TabStop = true;
            this.rbConsola.Text = "Consola";
            this.rbConsola.UseVisualStyleBackColor = true;
            this.rbConsola.CheckedChanged += new System.EventHandler(this.rbConsola_CheckedChanged);
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.AllowDrop = true;
            this.btnDirectorio.Enabled = false;
            this.btnDirectorio.Location = new System.Drawing.Point(96, 77);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(86, 23);
            this.btnDirectorio.TabIndex = 14;
            this.btnDirectorio.Text = "Buscar";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Enabled = false;
            this.txtDirectorio.Location = new System.Drawing.Point(188, 79);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.ReadOnly = true;
            this.txtDirectorio.Size = new System.Drawing.Size(383, 20);
            this.txtDirectorio.TabIndex = 13;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCargar.Location = new System.Drawing.Point(333, 291);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(79, 35);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Compilar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvTablaDummys);
            this.tabPage2.Controls.Add(this.dgvTablaSimbolos);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Componentes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "DUMMIES";
            // 
            // dgvTablaDummys
            // 
            this.dgvTablaDummys.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaDummys.BackgroundColor = System.Drawing.Color.Black;
            this.dgvTablaDummys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaDummys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdentificadorDummy,
            this.txtLexemaDummy,
            this.txtCategoriaDummy,
            this.txtNLineaDummy,
            this.txtPosInicialDummy,
            this.txtPosFinalDummy,
            this.txtTipoComponente});
            this.dgvTablaDummys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTablaDummys.Location = new System.Drawing.Point(3, 290);
            this.dgvTablaDummys.Name = "dgvTablaDummys";
            this.dgvTablaDummys.Size = new System.Drawing.Size(740, 250);
            this.dgvTablaDummys.TabIndex = 1;
            // 
            // txtIdentificadorDummy
            // 
            this.txtIdentificadorDummy.HeaderText = "Identificador";
            this.txtIdentificadorDummy.Name = "txtIdentificadorDummy";
            // 
            // txtLexemaDummy
            // 
            this.txtLexemaDummy.HeaderText = "Lexema";
            this.txtLexemaDummy.Name = "txtLexemaDummy";
            // 
            // txtCategoriaDummy
            // 
            this.txtCategoriaDummy.HeaderText = "Categoría";
            this.txtCategoriaDummy.Name = "txtCategoriaDummy";
            // 
            // txtNLineaDummy
            // 
            this.txtNLineaDummy.HeaderText = "Número Línea";
            this.txtNLineaDummy.Name = "txtNLineaDummy";
            // 
            // txtPosInicialDummy
            // 
            this.txtPosInicialDummy.HeaderText = "Posición Inicial";
            this.txtPosInicialDummy.Name = "txtPosInicialDummy";
            // 
            // txtPosFinalDummy
            // 
            this.txtPosFinalDummy.HeaderText = "Posición Final";
            this.txtPosFinalDummy.Name = "txtPosFinalDummy";
            // 
            // txtTipoComponente
            // 
            this.txtTipoComponente.HeaderText = "Tipo Componente";
            this.txtTipoComponente.Name = "txtTipoComponente";
            // 
            // dgvTablaSimbolos
            // 
            this.dgvTablaSimbolos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaSimbolos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvTablaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdentificador,
            this.txtLexema,
            this.txtCategoria,
            this.txtNLinea,
            this.txtPosInicial,
            this.txtPosFinal});
            this.dgvTablaSimbolos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTablaSimbolos.Location = new System.Drawing.Point(3, 3);
            this.dgvTablaSimbolos.Name = "dgvTablaSimbolos";
            this.dgvTablaSimbolos.Size = new System.Drawing.Size(740, 250);
            this.dgvTablaSimbolos.TabIndex = 0;
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.HeaderText = "Identificador";
            this.txtIdentificador.Name = "txtIdentificador";
            // 
            // txtLexema
            // 
            this.txtLexema.HeaderText = "Lexema";
            this.txtLexema.Name = "txtLexema";
            // 
            // txtCategoria
            // 
            this.txtCategoria.HeaderText = "Categoría";
            this.txtCategoria.Name = "txtCategoria";
            // 
            // txtNLinea
            // 
            this.txtNLinea.HeaderText = "#Línea";
            this.txtNLinea.Name = "txtNLinea";
            // 
            // txtPosInicial
            // 
            this.txtPosInicial.HeaderText = "Posición Inicial";
            this.txtPosInicial.Name = "txtPosInicial";
            // 
            // txtPosFinal
            // 
            this.txtPosFinal.HeaderText = "Posición Final";
            this.txtPosFinal.Name = "txtPosFinal";
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.dgvTablaErrores);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(746, 543);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Errores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvTablaErrores
            // 
            this.dgvTablaErrores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaErrores.BackgroundColor = System.Drawing.Color.Black;
            this.dgvTablaErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.txtFalla,
            this.txtCausa,
            this.txtSolucion,
            this.txtTipo});
            this.dgvTablaErrores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaErrores.Location = new System.Drawing.Point(0, 0);
            this.dgvTablaErrores.Name = "dgvTablaErrores";
            this.dgvTablaErrores.Size = new System.Drawing.Size(744, 541);
            this.dgvTablaErrores.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Número Línea";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Posición Inicial";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Posición Final";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // txtFalla
            // 
            this.txtFalla.HeaderText = "Falla";
            this.txtFalla.Name = "txtFalla";
            // 
            // txtCausa
            // 
            this.txtCausa.HeaderText = "Causa";
            this.txtCausa.Name = "txtCausa";
            // 
            // txtSolucion
            // 
            this.txtSolucion.HeaderText = "Solución";
            this.txtSolucion.Name = "txtSolucion";
            // 
            // txtTipo
            // 
            this.txtTipo.HeaderText = "Tipo";
            this.txtTipo.Name = "txtTipo";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvTablaPalabrasReservadas);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(746, 543);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Palabras Reservada";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvTablaPalabrasReservadas
            // 
            this.dgvTablaPalabrasReservadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaPalabrasReservadas.BackgroundColor = System.Drawing.Color.Black;
            this.dgvTablaPalabrasReservadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaPalabrasReservadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvTablaPalabrasReservadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaPalabrasReservadas.Location = new System.Drawing.Point(0, 0);
            this.dgvTablaPalabrasReservadas.Name = "dgvTablaPalabrasReservadas";
            this.dgvTablaPalabrasReservadas.Size = new System.Drawing.Size(746, 543);
            this.dgvTablaPalabrasReservadas.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "#Línea";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Posición Inicial";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Posición Final";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvTablaLiterales);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(746, 543);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Literales";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvTablaLiterales
            // 
            this.dgvTablaLiterales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaLiterales.BackgroundColor = System.Drawing.Color.Black;
            this.dgvTablaLiterales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaLiterales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.dgvTablaLiterales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaLiterales.Location = new System.Drawing.Point(0, 0);
            this.dgvTablaLiterales.Name = "dgvTablaLiterales";
            this.dgvTablaLiterales.Size = new System.Drawing.Size(746, 543);
            this.dgvTablaLiterales.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "#Línea";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Posición Inicial";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Posición Final";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDepuracion);
            this.groupBox1.Location = new System.Drawing.Point(458, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 63);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depuración";
            // 
            // cbxDepuracion
            // 
            this.cbxDepuracion.AutoSize = true;
            this.cbxDepuracion.Location = new System.Drawing.Point(40, 19);
            this.cbxDepuracion.Name = "cbxDepuracion";
            this.cbxDepuracion.Size = new System.Drawing.Size(73, 17);
            this.cbxDepuracion.TabIndex = 0;
            this.cbxDepuracion.Text = "Habilitar";
            this.cbxDepuracion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(754, 572);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Compilador";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gboxOpciones.ResumeLayout(false);
            this.gboxOpciones.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaDummys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaErrores)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPalabrasReservadas)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaLiterales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtFuente;
        private System.Windows.Forms.GroupBox gboxOpciones;
        private System.Windows.Forms.RadioButton rbCargarArchivo;
        private System.Windows.Forms.RadioButton rbConsola;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvTablaSimbolos;
        private System.Windows.Forms.DataGridView dgvTablaErrores;
        private System.Windows.Forms.DataGridView dgvTablaDummys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdentificadorDummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLexemaDummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoriaDummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNLineaDummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPosInicialDummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPosFinalDummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipoComponente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPosInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPosFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCausa;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipo;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvTablaPalabrasReservadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvTablaLiterales;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxDepuracion;
    }
}

