namespace Pensum_Sistemas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_horario = new System.Windows.Forms.TabPage();
            this.grid_Semestre = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_Creditos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grid_Filtro = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_CursosAprobados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Semestre = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_Aprobados = new System.Windows.Forms.DataGridView();
            this.SELECCIONADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_FiltrarCursos = new System.Windows.Forms.Button();
            this.tab_Cursos = new System.Windows.Forms.TabPage();
            this.grid_Cursos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEMESTRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREREQUISITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREDITOS_NECESARIOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_todos = new System.Windows.Forms.CheckBox();
            this.cb_seleccionSemestre = new System.Windows.Forms.ComboBox();
            this.check_semestre = new System.Windows.Forms.CheckBox();
            this.txt_Curso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tab_horario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Semestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Filtro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Aprobados)).BeginInit();
            this.tab_Cursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Cursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_horario);
            this.tabControl1.Controls.Add(this.tab_Cursos);
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_horario
            // 
            this.tab_horario.Controls.Add(this.grid_Semestre);
            this.tab_horario.Controls.Add(this.button3);
            this.tab_horario.Controls.Add(this.lb_Creditos);
            this.tab_horario.Controls.Add(this.label4);
            this.tab_horario.Controls.Add(this.grid_Filtro);
            this.tab_horario.Controls.Add(this.button1);
            this.tab_horario.Controls.Add(this.label1);
            this.tab_horario.Controls.Add(this.bt_CursosAprobados);
            this.tab_horario.Controls.Add(this.label2);
            this.tab_horario.Controls.Add(this.cb_Semestre);
            this.tab_horario.Controls.Add(this.panel1);
            this.tab_horario.Controls.Add(this.bt_FiltrarCursos);
            this.tab_horario.Location = new System.Drawing.Point(4, 22);
            this.tab_horario.Name = "tab_horario";
            this.tab_horario.Size = new System.Drawing.Size(827, 624);
            this.tab_horario.TabIndex = 0;
            this.tab_horario.Text = "HORARIO";
            this.tab_horario.UseVisualStyleBackColor = true;
            // 
            // grid_Semestre
            // 
            this.grid_Semestre.AllowUserToAddRows = false;
            this.grid_Semestre.AllowUserToDeleteRows = false;
            this.grid_Semestre.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grid_Semestre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Semestre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.grid_Semestre.Location = new System.Drawing.Point(0, 82);
            this.grid_Semestre.Name = "grid_Semestre";
            this.grid_Semestre.RowHeadersVisible = false;
            this.grid_Semestre.Size = new System.Drawing.Size(533, 209);
            this.grid_Semestre.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "CODIGO";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn12.Width = 60;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "CREDITOS";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn13.Width = 70;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "CURSO";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 200;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "OBLIGATORIO";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "SELECCIONAR";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(615, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 34);
            this.button3.TabIndex = 12;
            this.button3.Text = "Borrar Seleccionado";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lb_Creditos
            // 
            this.lb_Creditos.AutoSize = true;
            this.lb_Creditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Creditos.Location = new System.Drawing.Point(787, 592);
            this.lb_Creditos.Name = "lb_Creditos";
            this.lb_Creditos.Size = new System.Drawing.Size(16, 16);
            this.lb_Creditos.TabIndex = 11;
            this.lb_Creditos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(711, 592);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Creditos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // grid_Filtro
            // 
            this.grid_Filtro.AllowUserToAddRows = false;
            this.grid_Filtro.AllowUserToDeleteRows = false;
            this.grid_Filtro.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grid_Filtro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Filtro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.grid_Filtro.Location = new System.Drawing.Point(0, 415);
            this.grid_Filtro.Name = "grid_Filtro";
            this.grid_Filtro.ReadOnly = true;
            this.grid_Filtro.RowHeadersVisible = false;
            this.grid_Filtro.Size = new System.Drawing.Size(533, 209);
            this.grid_Filtro.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "CODIGO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CREDITOS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "CURSO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "OBLIGATORIO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "SEMESTRE";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(542, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Borrar Todo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtro De Cursos Aprobados";
            // 
            // bt_CursosAprobados
            // 
            this.bt_CursosAprobados.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_CursosAprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CursosAprobados.ForeColor = System.Drawing.Color.White;
            this.bt_CursosAprobados.Location = new System.Drawing.Point(151, 294);
            this.bt_CursosAprobados.Name = "bt_CursosAprobados";
            this.bt_CursosAprobados.Size = new System.Drawing.Size(219, 34);
            this.bt_CursosAprobados.TabIndex = 5;
            this.bt_CursosAprobados.Text = "Agregar Cursos Aprobados";
            this.bt_CursosAprobados.UseVisualStyleBackColor = false;
            this.bt_CursosAprobados.Click += new System.EventHandler(this.bt_CursosAprobados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "SEMESTRE:";
            // 
            // cb_Semestre
            // 
            this.cb_Semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Semestre.FormattingEnabled = true;
            this.cb_Semestre.Items.AddRange(new object[] {
            "Primer Semestre",
            "Segundo Semestre",
            "Tercer Semestre",
            "Cuarto Semestre",
            "Quinto Semestre",
            "Sexto Semestre",
            "Septimo Semestre",
            "Octavo Semestre",
            "Noveno Semestre",
            "Decimo Semestre"});
            this.cb_Semestre.Location = new System.Drawing.Point(100, 52);
            this.cb_Semestre.Name = "cb_Semestre";
            this.cb_Semestre.Size = new System.Drawing.Size(174, 24);
            this.cb_Semestre.TabIndex = 2;
            this.cb_Semestre.Text = "Seleccione un semestre..";
            this.cb_Semestre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.grid_Aprobados);
            this.panel1.Location = new System.Drawing.Point(542, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 533);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "CURSOS APROBADOS";
            // 
            // grid_Aprobados
            // 
            this.grid_Aprobados.AllowUserToAddRows = false;
            this.grid_Aprobados.AllowUserToDeleteRows = false;
            this.grid_Aprobados.BackgroundColor = System.Drawing.Color.White;
            this.grid_Aprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Aprobados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECCIONADO,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.grid_Aprobados.Location = new System.Drawing.Point(4, 57);
            this.grid_Aprobados.Name = "grid_Aprobados";
            this.grid_Aprobados.RowHeadersVisible = false;
            this.grid_Aprobados.Size = new System.Drawing.Size(278, 472);
            this.grid_Aprobados.TabIndex = 7;
            // 
            // SELECCIONADO
            // 
            this.SELECCIONADO.HeaderText = "";
            this.SELECCIONADO.Name = "SELECCIONADO";
            this.SELECCIONADO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SELECCIONADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SELECCIONADO.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Creditos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // bt_FiltrarCursos
            // 
            this.bt_FiltrarCursos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_FiltrarCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_FiltrarCursos.ForeColor = System.Drawing.Color.White;
            this.bt_FiltrarCursos.Location = new System.Drawing.Point(151, 375);
            this.bt_FiltrarCursos.Name = "bt_FiltrarCursos";
            this.bt_FiltrarCursos.Size = new System.Drawing.Size(219, 34);
            this.bt_FiltrarCursos.TabIndex = 1;
            this.bt_FiltrarCursos.Text = "Filtrar Cursos Disponibles";
            this.bt_FiltrarCursos.UseVisualStyleBackColor = false;
            this.bt_FiltrarCursos.Click += new System.EventHandler(this.bt_FiltrarCursos_Click);
            // 
            // tab_Cursos
            // 
            this.tab_Cursos.Controls.Add(this.grid_Cursos);
            this.tab_Cursos.Controls.Add(this.pictureBox1);
            this.tab_Cursos.Controls.Add(this.button2);
            this.tab_Cursos.Controls.Add(this.groupBox1);
            this.tab_Cursos.Controls.Add(this.txt_Curso);
            this.tab_Cursos.Controls.Add(this.label5);
            this.tab_Cursos.Location = new System.Drawing.Point(4, 22);
            this.tab_Cursos.Name = "tab_Cursos";
            this.tab_Cursos.Size = new System.Drawing.Size(827, 624);
            this.tab_Cursos.TabIndex = 1;
            this.tab_Cursos.Text = "CURSOS";
            this.tab_Cursos.UseVisualStyleBackColor = true;
            // 
            // grid_Cursos
            // 
            this.grid_Cursos.AllowUserToAddRows = false;
            this.grid_Cursos.AllowUserToDeleteRows = false;
            this.grid_Cursos.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Cursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Cursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.SEMESTRE,
            this.PREREQUISITO,
            this.CREDITOS_NECESARIOS});
            this.grid_Cursos.Location = new System.Drawing.Point(19, 124);
            this.grid_Cursos.Name = "grid_Cursos";
            this.grid_Cursos.RowHeadersVisible = false;
            this.grid_Cursos.Size = new System.Drawing.Size(792, 472);
            this.grid_Cursos.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "CODIGO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.Frozen = true;
            this.dataGridViewTextBoxColumn9.HeaderText = "CREDITOS";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn9.Width = 70;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.Frozen = true;
            this.dataGridViewTextBoxColumn10.HeaderText = "CURSO";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.Frozen = true;
            this.dataGridViewTextBoxColumn11.HeaderText = "OBLIGATORIO";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SEMESTRE
            // 
            this.SEMESTRE.Frozen = true;
            this.SEMESTRE.HeaderText = "SEMESTRE";
            this.SEMESTRE.Name = "SEMESTRE";
            this.SEMESTRE.ReadOnly = true;
            // 
            // PREREQUISITO
            // 
            this.PREREQUISITO.Frozen = true;
            this.PREREQUISITO.HeaderText = "PREREQUISITO";
            this.PREREQUISITO.Name = "PREREQUISITO";
            this.PREREQUISITO.ReadOnly = true;
            this.PREREQUISITO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CREDITOS_NECESARIOS
            // 
            this.CREDITOS_NECESARIOS.Frozen = true;
            this.CREDITOS_NECESARIOS.HeaderText = "CREDITOS_NECESARIOS";
            this.CREDITOS_NECESARIOS.Name = "CREDITOS_NECESARIOS";
            this.CREDITOS_NECESARIOS.ReadOnly = true;
            this.CREDITOS_NECESARIOS.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pensum_Sistemas.Properties.Resources.document;
            this.pictureBox1.Location = new System.Drawing.Point(240, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(601, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_todos);
            this.groupBox1.Controls.Add(this.cb_seleccionSemestre);
            this.groupBox1.Controls.Add(this.check_semestre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 105);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro:";
            // 
            // check_todos
            // 
            this.check_todos.AutoSize = true;
            this.check_todos.Checked = true;
            this.check_todos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_todos.Location = new System.Drawing.Point(6, 21);
            this.check_todos.Name = "check_todos";
            this.check_todos.Size = new System.Drawing.Size(67, 20);
            this.check_todos.TabIndex = 7;
            this.check_todos.Text = "Todos";
            this.check_todos.UseVisualStyleBackColor = true;
            this.check_todos.CheckedChanged += new System.EventHandler(this.check_todos_CheckedChanged);
            // 
            // cb_seleccionSemestre
            // 
            this.cb_seleccionSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_seleccionSemestre.FormattingEnabled = true;
            this.cb_seleccionSemestre.Items.AddRange(new object[] {
            "Primer Semestre",
            "Segundo Semestre",
            "Tercer Semestre",
            "Cuarto Semestre",
            "Quinto Semestre",
            "Sexto Semestre",
            "Septimo Semestre",
            "Octavo Semestre",
            "Noveno Semestre",
            "Decimo Semestre"});
            this.cb_seleccionSemestre.Location = new System.Drawing.Point(24, 73);
            this.cb_seleccionSemestre.Name = "cb_seleccionSemestre";
            this.cb_seleccionSemestre.Size = new System.Drawing.Size(174, 24);
            this.cb_seleccionSemestre.TabIndex = 5;
            this.cb_seleccionSemestre.Text = "Seleccione un semestre..";
            this.cb_seleccionSemestre.Visible = false;
            // 
            // check_semestre
            // 
            this.check_semestre.AutoSize = true;
            this.check_semestre.Location = new System.Drawing.Point(6, 47);
            this.check_semestre.Name = "check_semestre";
            this.check_semestre.Size = new System.Drawing.Size(109, 20);
            this.check_semestre.TabIndex = 0;
            this.check_semestre.Text = "Por Semestre";
            this.check_semestre.UseVisualStyleBackColor = true;
            this.check_semestre.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txt_Curso
            // 
            this.txt_Curso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Curso.Location = new System.Drawing.Point(282, 55);
            this.txt_Curso.Name = "txt_Curso";
            this.txt_Curso.Size = new System.Drawing.Size(313, 22);
            this.txt_Curso.TabIndex = 0;
            this.txt_Curso.TextChanged += new System.EventHandler(this.txt_Curso_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Buscar Cursos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarUsuarioToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.crearUsuarioToolStripMenuItem.Text = "SESION";
            // 
            // cargarUsuarioToolStripMenuItem
            // 
            this.cargarUsuarioToolStripMenuItem.Name = "cargarUsuarioToolStripMenuItem";
            this.cargarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.cargarUsuarioToolStripMenuItem.Text = "CARGAR";
            this.cargarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cargarUsuarioToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.guardarToolStripMenuItem.Text = "GUARDAR";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CODIGO.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 680);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pensum Sistemas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_horario.ResumeLayout(false);
            this.tab_horario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Semestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Filtro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Aprobados)).EndInit();
            this.tab_Cursos.ResumeLayout(false);
            this.tab_Cursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Cursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_horario;
        private System.Windows.Forms.Button bt_FiltrarCursos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_CursosAprobados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Semestre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid_Filtro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView grid_Aprobados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_Creditos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.TabPage tab_Cursos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Curso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cb_seleccionSemestre;
        private System.Windows.Forms.CheckBox check_todos;
        private System.Windows.Forms.CheckBox check_semestre;
        private System.Windows.Forms.DataGridView grid_Cursos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECCIONADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEMESTRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREREQUISITO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREDITOS_NECESARIOS;
        private System.Windows.Forms.DataGridView grid_Semestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn16;
    }
}

