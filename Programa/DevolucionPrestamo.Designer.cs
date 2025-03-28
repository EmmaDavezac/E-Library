﻿
namespace Programa
{
    partial class DevolucionPrestamo
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
            this.botonRegistrarDevolucion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEstadoEjemplar = new System.Windows.Forms.ComboBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelLibro = new System.Windows.Forms.Label();
            this.labelFechaVencimiento = new System.Windows.Forms.Label();
            this.labelEstadoPrestamo = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelScoringDevolucion = new System.Windows.Forms.Label();
            this.dateTimePickerFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.labelScoringActual = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.labelScoring = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // botonRegistrarDevolucion
            // 
            this.botonRegistrarDevolucion.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonRegistrarDevolucion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            this.botonRegistrarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRegistrarDevolucion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonRegistrarDevolucion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonRegistrarDevolucion.Location = new System.Drawing.Point(684, 526);
            this.botonRegistrarDevolucion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonRegistrarDevolucion.Name = "botonRegistrarDevolucion";
            this.botonRegistrarDevolucion.Size = new System.Drawing.Size(89, 23);
            this.botonRegistrarDevolucion.TabIndex = 82;
            this.botonRegistrarDevolucion.Text = "Guardar";
            this.botonRegistrarDevolucion.UseVisualStyleBackColor = false;
            this.botonRegistrarDevolucion.Click += new System.EventHandler(this.botonRegistrarDevolucion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Seleccione el estado del ejemplar devuelto:";
            // 
            // comboBoxEstadoEjemplar
            // 
            this.comboBoxEstadoEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstadoEjemplar.FormattingEnabled = true;
            this.comboBoxEstadoEjemplar.Items.AddRange(new object[] {
            "Bueno",
            "Malo"});
            this.comboBoxEstadoEjemplar.Location = new System.Drawing.Point(429, 289);
            this.comboBoxEstadoEjemplar.Name = "comboBoxEstadoEjemplar";
            this.comboBoxEstadoEjemplar.Size = new System.Drawing.Size(127, 21);
            this.comboBoxEstadoEjemplar.TabIndex = 84;
            this.comboBoxEstadoEjemplar.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstadoEjemplar_SelectedIndexChanged);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(429, 136);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(50, 13);
            this.labelUsuario.TabIndex = 85;
            this.labelUsuario.Text = "Usuario";
            this.labelUsuario.Click += new System.EventHandler(this.labelUsuario_Click);
            // 
            // labelLibro
            // 
            this.labelLibro.AutoSize = true;
            this.labelLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibro.Location = new System.Drawing.Point(429, 169);
            this.labelLibro.Name = "labelLibro";
            this.labelLibro.Size = new System.Drawing.Size(35, 13);
            this.labelLibro.TabIndex = 86;
            this.labelLibro.Text = "Libro";
            this.labelLibro.Click += new System.EventHandler(this.labelLibro_Click);
            // 
            // labelFechaVencimiento
            // 
            this.labelFechaVencimiento.AutoSize = true;
            this.labelFechaVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaVencimiento.Location = new System.Drawing.Point(429, 231);
            this.labelFechaVencimiento.Name = "labelFechaVencimiento";
            this.labelFechaVencimiento.Size = new System.Drawing.Size(111, 13);
            this.labelFechaVencimiento.TabIndex = 87;
            this.labelFechaVencimiento.Text = "FechaVencimiento";
            this.labelFechaVencimiento.Click += new System.EventHandler(this.labelFechaVencimiento_Click);
            // 
            // labelEstadoPrestamo
            // 
            this.labelEstadoPrestamo.AutoSize = true;
            this.labelEstadoPrestamo.Location = new System.Drawing.Point(211, 202);
            this.labelEstadoPrestamo.Name = "labelEstadoPrestamo";
            this.labelEstadoPrestamo.Size = new System.Drawing.Size(87, 13);
            this.labelEstadoPrestamo.TabIndex = 88;
            this.labelEstadoPrestamo.Text = "EstadoPrestamo:";
            this.labelEstadoPrestamo.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(429, 202);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(46, 13);
            this.labelEstado.TabIndex = 89;
            this.labelEstado.Text = "Estado";
            this.labelEstado.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelScoringDevolucion
            // 
            this.labelScoringDevolucion.AutoSize = true;
            this.labelScoringDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoringDevolucion.Location = new System.Drawing.Point(429, 351);
            this.labelScoringDevolucion.Name = "labelScoringDevolucion";
            this.labelScoringDevolucion.Size = new System.Drawing.Size(50, 13);
            this.labelScoringDevolucion.TabIndex = 90;
            this.labelScoringDevolucion.Text = "Scoring";
            this.labelScoringDevolucion.Visible = false;
            // 
            // dateTimePickerFechaDevolucion
            // 
            this.dateTimePickerFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaDevolucion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerFechaDevolucion.Location = new System.Drawing.Point(429, 260);
            this.dateTimePickerFechaDevolucion.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaDevolucion.Name = "dateTimePickerFechaDevolucion";
            this.dateTimePickerFechaDevolucion.Size = new System.Drawing.Size(127, 20);
            this.dateTimePickerFechaDevolucion.TabIndex = 91;
            this.dateTimePickerFechaDevolucion.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 92;
            this.label8.Text = "FechaDevolucion:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelScoringActual
            // 
            this.labelScoringActual.AutoSize = true;
            this.labelScoringActual.Location = new System.Drawing.Point(211, 324);
            this.labelScoringActual.Name = "labelScoringActual";
            this.labelScoringActual.Size = new System.Drawing.Size(79, 13);
            this.labelScoringActual.TabIndex = 93;
            this.labelScoringActual.Text = "Scoring Actual:";
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonVolver.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonVolver.Location = new System.Drawing.Point(591, 526);
            this.botonVolver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 23);
            this.botonVolver.TabIndex = 143;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // labelScoring
            // 
            this.labelScoring.AutoSize = true;
            this.labelScoring.BackColor = System.Drawing.Color.White;
            this.labelScoring.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoring.Location = new System.Drawing.Point(429, 324);
            this.labelScoring.Name = "labelScoring";
            this.labelScoring.Size = new System.Drawing.Size(50, 13);
            this.labelScoring.TabIndex = 144;
            this.labelScoring.Text = "Scoring";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 145;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 146;
            this.label3.Text = "Libro:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 147;
            this.label4.Text = "FechaVencimiento:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 148;
            this.label5.Text = "Scoring luego de la devolucion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 149;
            this.label6.Text = "Registrar devolución:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 60);
            this.panel3.TabIndex = 150;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(82, 60);
            this.panel4.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(12, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "E-Library";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.libro_abierto;
            this.pictureBox2.Location = new System.Drawing.Point(16, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Controls.Add(this.labelNombreUsuario);
            this.panel5.Location = new System.Drawing.Point(566, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(207, 60);
            this.panel5.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Presentacion.Properties.Resources.perfil_del_usuario;
            this.pictureBox4.Location = new System.Drawing.Point(155, 10);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.AutoSize = true;
            this.labelNombreUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreUsuario.Location = new System.Drawing.Point(8, 24);
            this.labelNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 5, 0);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(84, 13);
            this.labelNombreUsuario.TabIndex = 0;
            this.labelNombreUsuario.Text = "Nombre Apellido";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DevolucionPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelScoring);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.labelScoringActual);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerFechaDevolucion);
            this.Controls.Add(this.labelScoringDevolucion);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelEstadoPrestamo);
            this.Controls.Add(this.labelFechaVencimiento);
            this.Controls.Add(this.labelLibro);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.comboBoxEstadoEjemplar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonRegistrarDevolucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DevolucionPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Library";
            this.Load += new System.EventHandler(this.DevolucionPrestamo_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRegistrarDevolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEstadoEjemplar;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelLibro;
        private System.Windows.Forms.Label labelFechaVencimiento;
        private System.Windows.Forms.Label labelEstadoPrestamo;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelScoringDevolucion;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDevolucion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelScoringActual;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label labelScoring;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelNombreUsuario;
    }
}