
namespace Programa
{
    partial class GestionarPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarPrestamos));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.RegistrarDevolucion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IdPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TituloLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRealizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxUsuarioOTituloLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.checkBoxProximosAVencerse = new System.Windows.Forms.CheckBox();
            this.checkBoxRestrasados = new System.Windows.Forms.CheckBox();
            this.checkDevueltos = new System.Windows.Forms.CheckBox();
            this.labelNombreLista = new System.Windows.Forms.Label();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            this.SuspendLayout();
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
            this.panel3.Size = new System.Drawing.Size(1045, 74);
            this.panel3.TabIndex = 72;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(109, 74);
            this.panel4.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-Library";
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
            // dataGridViewPrestamos
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewPrestamos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrestamos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewPrestamos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistrarDevolucion,
            this.IdPrestamo,
            this.NombreUsuario,
            this.TituloLibro,
            this.ISBNLibro,
            this.FechaRealizacion,
            this.FechaVencimiento,
            this.EstadoPrestamo});
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(0, 219);
            this.dataGridViewPrestamos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.RowHeadersWidth = 51;
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(1045, 418);
            this.dataGridViewPrestamos.TabIndex = 77;
            this.dataGridViewPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPrestamos_CellContentClick);
            // 
            // RegistrarDevolucion
            // 
            this.RegistrarDevolucion.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.RegistrarDevolucion.HeaderText = "RegistrarDevolucion";
            this.RegistrarDevolucion.LinkColor = System.Drawing.Color.DodgerBlue;
            this.RegistrarDevolucion.MinimumWidth = 6;
            this.RegistrarDevolucion.Name = "RegistrarDevolucion";
            this.RegistrarDevolucion.ReadOnly = true;
            this.RegistrarDevolucion.Text = "Devolucion";
            this.RegistrarDevolucion.TrackVisitedState = false;
            this.RegistrarDevolucion.UseColumnTextForLinkValue = true;
            this.RegistrarDevolucion.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.RegistrarDevolucion.Width = 110;
            // 
            // IdPrestamo
            // 
            this.IdPrestamo.HeaderText = "IdPrestamo";
            this.IdPrestamo.MinimumWidth = 6;
            this.IdPrestamo.Name = "IdPrestamo";
            this.IdPrestamo.ReadOnly = true;
            this.IdPrestamo.Width = 75;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "NombreUsuario";
            this.NombreUsuario.MinimumWidth = 6;
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 125;
            // 
            // TituloLibro
            // 
            this.TituloLibro.HeaderText = "TituloLibro";
            this.TituloLibro.MinimumWidth = 6;
            this.TituloLibro.Name = "TituloLibro";
            this.TituloLibro.ReadOnly = true;
            this.TituloLibro.Width = 140;
            // 
            // ISBNLibro
            // 
            this.ISBNLibro.HeaderText = "ISBNLibro";
            this.ISBNLibro.MinimumWidth = 6;
            this.ISBNLibro.Name = "ISBNLibro";
            this.ISBNLibro.ReadOnly = true;
            this.ISBNLibro.Width = 120;
            // 
            // FechaRealizacion
            // 
            this.FechaRealizacion.HeaderText = "FechaRealizacion";
            this.FechaRealizacion.MinimumWidth = 6;
            this.FechaRealizacion.Name = "FechaRealizacion";
            this.FechaRealizacion.ReadOnly = true;
            this.FechaRealizacion.Width = 125;
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.HeaderText = "FechaVencimiento";
            this.FechaVencimiento.MinimumWidth = 6;
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.ReadOnly = true;
            this.FechaVencimiento.Width = 125;
            // 
            // EstadoPrestamo
            // 
            this.EstadoPrestamo.HeaderText = "EstadoPrestamo";
            this.EstadoPrestamo.MinimumWidth = 6;
            this.EstadoPrestamo.Name = "EstadoPrestamo";
            this.EstadoPrestamo.ReadOnly = true;
            this.EstadoPrestamo.Width = 125;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(17, 89);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(161, 17);
            this.labelTitulo.TabIndex = 80;
            this.labelTitulo.Text = "Gestor de Prestamos";
            this.labelTitulo.Click += new System.EventHandler(this.LabelTitulo_Click);
            // 
            // textBoxUsuarioOTituloLibro
            // 
            this.textBoxUsuarioOTituloLibro.Location = new System.Drawing.Point(351, 117);
            this.textBoxUsuarioOTituloLibro.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuarioOTituloLibro.Name = "textBoxUsuarioOTituloLibro";
            this.textBoxUsuarioOTituloLibro.Size = new System.Drawing.Size(663, 22);
            this.textBoxUsuarioOTituloLibro.TabIndex = 79;
            this.textBoxUsuarioOTituloLibro.TextChanged += new System.EventHandler(this.TextBoxUsuarioOTituloLibro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "Buscar por Nombre de usuario o Titulo del libro:";
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(912, 647);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(119, 28);
            this.botonVolver.TabIndex = 81;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // checkBoxProximosAVencerse
            // 
            this.checkBoxProximosAVencerse.AutoSize = true;
            this.checkBoxProximosAVencerse.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxProximosAVencerse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxProximosAVencerse.Location = new System.Drawing.Point(793, 154);
            this.checkBoxProximosAVencerse.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxProximosAVencerse.Name = "checkBoxProximosAVencerse";
            this.checkBoxProximosAVencerse.Size = new System.Drawing.Size(97, 20);
            this.checkBoxProximosAVencerse.TabIndex = 82;
            this.checkBoxProximosAVencerse.Text = "A vencerse";
            this.checkBoxProximosAVencerse.UseVisualStyleBackColor = false;
            this.checkBoxProximosAVencerse.CheckedChanged += new System.EventHandler(this.CheckBoxProximosAVencerse_CheckedChanged);
            // 
            // checkBoxRestrasados
            // 
            this.checkBoxRestrasados.AutoSize = true;
            this.checkBoxRestrasados.Location = new System.Drawing.Point(908, 154);
            this.checkBoxRestrasados.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxRestrasados.Name = "checkBoxRestrasados";
            this.checkBoxRestrasados.Size = new System.Drawing.Size(100, 20);
            this.checkBoxRestrasados.TabIndex = 83;
            this.checkBoxRestrasados.Text = "Retrasados";
            this.checkBoxRestrasados.UseVisualStyleBackColor = true;
            this.checkBoxRestrasados.CheckedChanged += new System.EventHandler(this.CheckBoxRestrasados_CheckedChanged);
            // 
            // checkDevueltos
            // 
            this.checkDevueltos.AutoSize = true;
            this.checkDevueltos.Location = new System.Drawing.Point(20, 191);
            this.checkDevueltos.Margin = new System.Windows.Forms.Padding(4);
            this.checkDevueltos.Name = "checkDevueltos";
            this.checkDevueltos.Size = new System.Drawing.Size(203, 20);
            this.checkDevueltos.TabIndex = 84;
            this.checkDevueltos.Text = "Mostrar prestamos devueltos";
            this.checkDevueltos.UseVisualStyleBackColor = true;
            this.checkDevueltos.CheckedChanged += new System.EventHandler(this.CheckDevueltos_CheckedChanged);
            // 
            // labelNombreLista
            // 
            this.labelNombreLista.AutoSize = true;
            this.labelNombreLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreLista.ForeColor = System.Drawing.Color.Black;
            this.labelNombreLista.Location = new System.Drawing.Point(17, 159);
            this.labelNombreLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreLista.Name = "labelNombreLista";
            this.labelNombreLista.Size = new System.Drawing.Size(146, 17);
            this.labelNombreLista.TabIndex = 85;
            this.labelNombreLista.Text = "Prestamos Activos:";
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltrar.ForeColor = System.Drawing.Color.Black;
            this.labelFiltrar.Location = new System.Drawing.Point(605, 155);
            this.labelFiltrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(165, 17);
            this.labelFiltrar.TabIndex = 86;
            this.labelFiltrar.Text = "Filtrar prestamos por:";
            // 
            // GestionarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.labelNombreLista);
            this.Controls.Add(this.checkDevueltos);
            this.Controls.Add(this.checkBoxRestrasados);
            this.Controls.Add(this.checkBoxProximosAVencerse);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxUsuarioOTituloLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPrestamos);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionarPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionarPrestamos_FormClosed);
            this.Load += new System.EventHandler(this.GestionarPrestamos_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.DataGridView dataGridViewPrestamos;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxUsuarioOTituloLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.CheckBox checkBoxProximosAVencerse;
        private System.Windows.Forms.CheckBox checkBoxRestrasados;
        private System.Windows.Forms.CheckBox checkDevueltos;
        private System.Windows.Forms.Label labelNombreLista;
        private System.Windows.Forms.Label labelFiltrar;
        private System.Windows.Forms.DataGridViewLinkColumn RegistrarDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRealizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoPrestamo;
    }
}