
namespace Programa
{
    partial class RegistrarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarLibro));
            this.dataGridViewTituloYAutor = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxAñoPublicacion = new System.Windows.Forms.TextBox();
            this.labelIngreseTitulo = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.labelResultados = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonAñadirLibro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBorrarDatos = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTituloYAutor)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTituloYAutor
            // 
            this.dataGridViewTituloYAutor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTituloYAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTituloYAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.Column1});
            this.dataGridViewTituloYAutor.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTituloYAutor.Location = new System.Drawing.Point(3, 191);
            this.dataGridViewTituloYAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewTituloYAutor.Name = "dataGridViewTituloYAutor";
            this.dataGridViewTituloYAutor.RowHeadersWidth = 51;
            this.dataGridViewTituloYAutor.Size = new System.Drawing.Size(624, 224);
            this.dataGridViewTituloYAutor.TabIndex = 0;
            this.dataGridViewTituloYAutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridViewTituloYAutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 6;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Autor
            // 
            this.Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Primer año publicacion";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(192, 158);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(200, 22);
            this.textBoxBuscar.TabIndex = 1;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBuscar.Location = new System.Drawing.Point(392, 158);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(95, 25);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Año publicacion:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(664, 230);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(349, 22);
            this.textBoxTitulo.TabIndex = 6;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(664, 282);
            this.textBoxAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(349, 22);
            this.textBoxAutor.TabIndex = 7;
            // 
            // textBoxAñoPublicacion
            // 
            this.textBoxAñoPublicacion.Location = new System.Drawing.Point(664, 383);
            this.textBoxAñoPublicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAñoPublicacion.Name = "textBoxAñoPublicacion";
            this.textBoxAñoPublicacion.Size = new System.Drawing.Size(349, 22);
            this.textBoxAñoPublicacion.TabIndex = 8;
            this.textBoxAñoPublicacion.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // labelIngreseTitulo
            // 
            this.labelIngreseTitulo.AutoSize = true;
            this.labelIngreseTitulo.Location = new System.Drawing.Point(32, 162);
            this.labelIngreseTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIngreseTitulo.Name = "labelIngreseTitulo";
            this.labelIngreseTitulo.Size = new System.Drawing.Size(140, 16);
            this.labelIngreseTitulo.TabIndex = 9;
            this.labelIngreseTitulo.Text = "Ingrese el titulo o autor";
            this.labelIngreseTitulo.Click += new System.EventHandler(this.Label4_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(785, 647);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(119, 28);
            this.botonVolver.TabIndex = 13;
            this.botonVolver.Text = "Cancelar";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // labelResultados
            // 
            this.labelResultados.AutoSize = true;
            this.labelResultados.ForeColor = System.Drawing.Color.Red;
            this.labelResultados.Location = new System.Drawing.Point(188, 138);
            this.labelResultados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultados.Name = "labelResultados";
            this.labelResultados.Size = new System.Drawing.Size(0, 16);
            this.labelResultados.TabIndex = 14;
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(664, 330);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(349, 22);
            this.textBoxISBN.TabIndex = 16;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "ISBN:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // botonAñadirLibro
            // 
            this.botonAñadirLibro.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonAñadirLibro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonAñadirLibro.FlatAppearance.BorderSize = 0;
            this.botonAñadirLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAñadirLibro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonAñadirLibro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonAñadirLibro.Location = new System.Drawing.Point(911, 647);
            this.botonAñadirLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonAñadirLibro.Name = "botonAñadirLibro";
            this.botonAñadirLibro.Size = new System.Drawing.Size(119, 28);
            this.botonAñadirLibro.TabIndex = 12;
            this.botonAñadirLibro.Text = "Guardar";
            this.botonAñadirLibro.UseVisualStyleBackColor = false;
            this.botonAñadirLibro.Click += new System.EventHandler(this.ButtonAñadirLibro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Consultar en pagina de libros:";
            this.label4.Click += new System.EventHandler(this.Label4_Click_1);
            // 
            // buttonBorrarDatos
            // 
            this.buttonBorrarDatos.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBorrarDatos.FlatAppearance.BorderSize = 0;
            this.buttonBorrarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrarDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBorrarDatos.Location = new System.Drawing.Point(664, 420);
            this.buttonBorrarDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBorrarDatos.Name = "buttonBorrarDatos";
            this.buttonBorrarDatos.Size = new System.Drawing.Size(81, 25);
            this.buttonBorrarDatos.TabIndex = 21;
            this.buttonBorrarDatos.Text = "Borrar datos";
            this.buttonBorrarDatos.UseVisualStyleBackColor = false;
            this.buttonBorrarDatos.Click += new System.EventHandler(this.ButtonBorrarDatos_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(660, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cargar datos manualmente:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(660, 471);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 30;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonActualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonActualizar.FlatAppearance.BorderSize = 0;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonActualizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonActualizar.Location = new System.Drawing.Point(911, 615);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(119, 28);
            this.buttonActualizar.TabIndex = 72;
            this.buttonActualizar.Text = "Guardar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.ButtonActualizar_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Registrar Libro";
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
            this.panel3.TabIndex = 71;
            // 
            // RegistrarLibro
            // 
            this.AcceptButton = this.buttonBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1043, 681);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBorrarDatos);
            this.Controls.Add(this.textBoxISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelResultados);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonAñadirLibro);
            this.Controls.Add(this.labelIngreseTitulo);
            this.Controls.Add(this.textBoxAñoPublicacion);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.dataGridViewTituloYAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 728);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "RegistrarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BuscarLibrosAPI_FormClosed);
            this.Load += new System.EventHandler(this.BuscarLibrosAPI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTituloYAutor)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTituloYAutor;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxAñoPublicacion;
        private System.Windows.Forms.Label labelIngreseTitulo;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label labelResultados;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonAñadirLibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBorrarDatos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}