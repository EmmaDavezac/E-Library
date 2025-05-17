
namespace Programa
{
    partial class ActualizarLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarLibro));
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxAñoPublicacion = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonDeshacerCambios = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.labelResultados = new System.Windows.Forms.Label();
            this.buttonBusquedaAvanzada = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAñadirEjemplares = new System.Windows.Forms.Button();
            this.textBoxAñadirEjemplares = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxBaja = new System.Windows.Forms.CheckBox();
            this.labelCantidadActual = new System.Windows.Forms.Label();
            this.labelErrorAñadirEjemplares = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Eiminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(411, 246);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(359, 22);
            this.textBoxISBN.TabIndex = 38;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.TextBoxISBN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "ISBN";
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(789, 647);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(119, 28);
            this.botonVolver.TabIndex = 35;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonGuardar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGuardar.Enabled = false;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGuardar.Location = new System.Drawing.Point(915, 647);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(119, 28);
            this.buttonGuardar.TabIndex = 34;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // textBoxAñoPublicacion
            // 
            this.textBoxAñoPublicacion.Location = new System.Drawing.Point(411, 214);
            this.textBoxAñoPublicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAñoPublicacion.Name = "textBoxAñoPublicacion";
            this.textBoxAñoPublicacion.Size = new System.Drawing.Size(359, 22);
            this.textBoxAñoPublicacion.TabIndex = 31;
            this.textBoxAñoPublicacion.TextChanged += new System.EventHandler(this.TextBoxAñoPublicacion_TextChanged);
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(411, 182);
            this.textBoxAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(359, 22);
            this.textBoxAutor.TabIndex = 30;
            this.textBoxAutor.TextChanged += new System.EventHandler(this.TextBoxAutor_TextChanged);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(411, 150);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(359, 22);
            this.textBoxTitulo.TabIndex = 29;
            this.textBoxTitulo.TextChanged += new System.EventHandler(this.TextBoxTitulo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Año publicacion";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(248, 292);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 45;
            // 
            // buttonDeshacerCambios
            // 
            this.buttonDeshacerCambios.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonDeshacerCambios.Enabled = false;
            this.buttonDeshacerCambios.FlatAppearance.BorderSize = 0;
            this.buttonDeshacerCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeshacerCambios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeshacerCambios.Location = new System.Drawing.Point(409, 311);
            this.buttonDeshacerCambios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeshacerCambios.Name = "buttonDeshacerCambios";
            this.buttonDeshacerCambios.Size = new System.Drawing.Size(100, 28);
            this.buttonDeshacerCambios.TabIndex = 46;
            this.buttonDeshacerCambios.Text = "Deshacer";
            this.buttonDeshacerCambios.UseVisualStyleBackColor = false;
            this.buttonDeshacerCambios.Click += new System.EventHandler(this.ButtonDeshacerCambios_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 74);
            this.panel3.TabIndex = 72;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 74);
            this.panel4.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(16, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "E-Library";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.libro_abierto;
            this.pictureBox2.Location = new System.Drawing.Point(21, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.labelNombreUsuario);
            this.panel5.Location = new System.Drawing.Point(755, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 74);
            this.panel5.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Presentacion.Properties.Resources.perfil_del_usuario;
            this.pictureBox4.Location = new System.Drawing.Point(207, 12);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 49);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.Location = new System.Drawing.Point(11, 30);
            this.labelNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 0, 7, 0);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(109, 16);
            this.labelNombreUsuario.TabIndex = 0;
            this.labelNombreUsuario.Text = "Nombre Apellido";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelResultados
            // 
            this.labelResultados.AutoSize = true;
            this.labelResultados.ForeColor = System.Drawing.Color.Red;
            this.labelResultados.Location = new System.Drawing.Point(17, 343);
            this.labelResultados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultados.Name = "labelResultados";
            this.labelResultados.Size = new System.Drawing.Size(0, 16);
            this.labelResultados.TabIndex = 84;
            // 
            // buttonBusquedaAvanzada
            // 
            this.buttonBusquedaAvanzada.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBusquedaAvanzada.FlatAppearance.BorderSize = 0;
            this.buttonBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBusquedaAvanzada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBusquedaAvanzada.Location = new System.Drawing.Point(807, 150);
            this.buttonBusquedaAvanzada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBusquedaAvanzada.Name = "buttonBusquedaAvanzada";
            this.buttonBusquedaAvanzada.Size = new System.Drawing.Size(163, 25);
            this.buttonBusquedaAvanzada.TabIndex = 87;
            this.buttonBusquedaAvanzada.Text = "Buscar Información";
            this.buttonBusquedaAvanzada.UseVisualStyleBackColor = false;
            this.buttonBusquedaAvanzada.Click += new System.EventHandler(this.ButtonBusquedaAvanzada_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Actualizar información del Libro";
            this.label4.Click += new System.EventHandler(this.Label4_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 382);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 89;
            this.label8.Text = "Ejemplares";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // buttonAñadirEjemplares
            // 
            this.buttonAñadirEjemplares.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonAñadirEjemplares.FlatAppearance.BorderSize = 0;
            this.buttonAñadirEjemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAñadirEjemplares.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAñadirEjemplares.Location = new System.Drawing.Point(616, 582);
            this.buttonAñadirEjemplares.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAñadirEjemplares.Name = "buttonAñadirEjemplares";
            this.buttonAñadirEjemplares.Size = new System.Drawing.Size(159, 25);
            this.buttonAñadirEjemplares.TabIndex = 90;
            this.buttonAñadirEjemplares.Text = "Añadir";
            this.buttonAñadirEjemplares.UseVisualStyleBackColor = false;
            this.buttonAñadirEjemplares.Click += new System.EventHandler(this.ButtonAñadirEjemplares_Click);
            // 
            // textBoxAñadirEjemplares
            // 
            this.textBoxAñadirEjemplares.Location = new System.Drawing.Point(317, 582);
            this.textBoxAñadirEjemplares.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAñadirEjemplares.Name = "textBoxAñadirEjemplares";
            this.textBoxAñadirEjemplares.Size = new System.Drawing.Size(308, 22);
            this.textBoxAñadirEjemplares.TabIndex = 91;
            this.textBoxAñadirEjemplares.TextChanged += new System.EventHandler(this.TextBoxAñadirEjemplares_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 586);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 92;
            this.label9.Text = "Cantidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 324);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 96;
            this.label11.Text = "Dar de baja";
            this.label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // checkBoxBaja
            // 
            this.checkBoxBaja.AutoSize = true;
            this.checkBoxBaja.Location = new System.Drawing.Point(248, 345);
            this.checkBoxBaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxBaja.Name = "checkBoxBaja";
            this.checkBoxBaja.Size = new System.Drawing.Size(57, 20);
            this.checkBoxBaja.TabIndex = 97;
            this.checkBoxBaja.Text = "Baja";
            this.checkBoxBaja.UseVisualStyleBackColor = true;
            this.checkBoxBaja.CheckedChanged += new System.EventHandler(this.CheckBoxBaja_CheckedChanged);
            // 
            // labelCantidadActual
            // 
            this.labelCantidadActual.AutoSize = true;
            this.labelCantidadActual.Location = new System.Drawing.Point(248, 386);
            this.labelCantidadActual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantidadActual.Name = "labelCantidadActual";
            this.labelCantidadActual.Size = new System.Drawing.Size(104, 16);
            this.labelCantidadActual.TabIndex = 98;
            this.labelCantidadActual.Text = "Cantidad Actual:";
            this.labelCantidadActual.Click += new System.EventHandler(this.LabelCantidadActual_Click);
            // 
            // labelErrorAñadirEjemplares
            // 
            this.labelErrorAñadirEjemplares.AutoSize = true;
            this.labelErrorAñadirEjemplares.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAñadirEjemplares.Location = new System.Drawing.Point(324, 610);
            this.labelErrorAñadirEjemplares.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorAñadirEjemplares.Name = "labelErrorAñadirEjemplares";
            this.labelErrorAñadirEjemplares.Size = new System.Drawing.Size(35, 16);
            this.labelErrorAñadirEjemplares.TabIndex = 100;
            this.labelErrorAñadirEjemplares.Text = "error";
            this.labelErrorAñadirEjemplares.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(807, 130);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 16);
            this.label13.TabIndex = 103;
            this.label13.Text = "¿No conoces los datos?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eiminar,
            this.ID,
            this.Disponible});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.Location = new System.Drawing.Point(248, 415);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(525, 142);
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Eiminar
            // 
            this.Eiminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eiminar.HeaderText = "Acciones";
            this.Eiminar.MinimumWidth = 6;
            this.Eiminar.Name = "Eiminar";
            this.Eiminar.ReadOnly = true;
            this.Eiminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eiminar.Text = "Eliminar";
            this.Eiminar.UseColumnTextForLinkValue = true;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Disponible
            // 
            this.Disponible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Disponible.HeaderText = "Disponible";
            this.Disponible.MinimumWidth = 6;
            this.Disponible.Name = "Disponible";
            this.Disponible.ReadOnly = true;
            this.Disponible.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 565);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 105;
            this.label6.Text = "Añadir";
            // 
            // ActualizarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1043, 681);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelErrorAñadirEjemplares);
            this.Controls.Add(this.labelCantidadActual);
            this.Controls.Add(this.checkBoxBaja);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAñadirEjemplares);
            this.Controls.Add(this.buttonAñadirEjemplares);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBusquedaAvanzada);
            this.Controls.Add(this.labelResultados);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonDeshacerCambios);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxAñoPublicacion);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 728);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "ActualizarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActualizarLibro_FormClosed);
            this.Load += new System.EventHandler(this.ActualizarLibro_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxAñoPublicacion;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
       // private System.Windows.Forms.DataGridViewTextBoxColumn AñoPublicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonDeshacerCambios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Label labelResultados;
        private System.Windows.Forms.Button buttonBusquedaAvanzada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAñadirEjemplares;
        private System.Windows.Forms.TextBox textBoxAñadirEjemplares;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxBaja;
        private System.Windows.Forms.Label labelCantidadActual;
        private System.Windows.Forms.Label labelErrorAñadirEjemplares;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewLinkColumn Eiminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponible;
    }
}