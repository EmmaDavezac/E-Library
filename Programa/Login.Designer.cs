﻿
namespace Programa
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBoxNombreUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelIdAdministrador = new System.Windows.Forms.Label();
            this.labelConstraseña = new System.Windows.Forms.Label();
            this.botonIniciarSesion = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombreUsuario
            // 
            this.textBoxNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreUsuario.Location = new System.Drawing.Point(385, 432);
            this.textBoxNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            this.textBoxNombreUsuario.Size = new System.Drawing.Size(277, 26);
            this.textBoxNombreUsuario.TabIndex = 0;
            this.textBoxNombreUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(385, 497);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(199, 26);
            this.textBoxContraseña.TabIndex = 4;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // labelIdAdministrador
            // 
            this.labelIdAdministrador.AutoSize = true;
            this.labelIdAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdAdministrador.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIdAdministrador.Location = new System.Drawing.Point(381, 409);
            this.labelIdAdministrador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdAdministrador.Name = "labelIdAdministrador";
            this.labelIdAdministrador.Size = new System.Drawing.Size(154, 20);
            this.labelIdAdministrador.TabIndex = 5;
            this.labelIdAdministrador.Text = "Nombre de Usuario";
            this.labelIdAdministrador.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelConstraseña
            // 
            this.labelConstraseña.AutoSize = true;
            this.labelConstraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConstraseña.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConstraseña.Location = new System.Drawing.Point(381, 474);
            this.labelConstraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConstraseña.Name = "labelConstraseña";
            this.labelConstraseña.Size = new System.Drawing.Size(95, 20);
            this.labelConstraseña.TabIndex = 6;
            this.labelConstraseña.Text = "Contraseña";
            this.labelConstraseña.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // botonIniciarSesion
            // 
            this.botonIniciarSesion.BackColor = System.Drawing.SystemColors.Highlight;
            this.botonIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonIniciarSesion.Enabled = false;
            this.botonIniciarSesion.FlatAppearance.BorderSize = 0;
            this.botonIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIniciarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.botonIniciarSesion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botonIniciarSesion.Location = new System.Drawing.Point(385, 567);
            this.botonIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonIniciarSesion.Name = "botonIniciarSesion";
            this.botonIniciarSesion.Size = new System.Drawing.Size(277, 37);
            this.botonIniciarSesion.TabIndex = 7;
            this.botonIniciarSesion.Text = "Iniciar Sesion";
            this.botonIniciarSesion.UseVisualStyleBackColor = false;
            this.botonIniciarSesion.Click += new System.EventHandler(this.botonIniciarSesion_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Black;
            this.labelError.Location = new System.Drawing.Point(381, 530);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 20);
            this.labelError.TabIndex = 33;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMostrar.FlatAppearance.BorderSize = 0;
            this.buttonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMostrar.Location = new System.Drawing.Point(593, 497);
            this.buttonMostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(69, 27);
            this.buttonMostrar.TabIndex = 34;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = false;
            this.buttonMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(409, 199);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Por favor inicie sesión";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(372, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 69);
            this.label2.TabIndex = 39;
            this.label2.Text = "E-Library";
            // 
            // Login
            // 
            this.AcceptButton = this.botonIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1043, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.botonIniciarSesion);
            this.Controls.Add(this.labelConstraseña);
            this.Controls.Add(this.labelIdAdministrador);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxNombreUsuario);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 728);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "Login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBoxNombreUsuario;
        internal System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelIdAdministrador;
        private System.Windows.Forms.Label labelConstraseña;
        private System.Windows.Forms.Button botonIniciarSesion;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}