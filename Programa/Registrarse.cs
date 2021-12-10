﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nucleo;

namespace Programa
{
    public partial class Registrarse : Form
    {
       InterfazNucleo InterfazNucleo = new InterfazNucleo();
        public Registrarse()
        {
            InitializeComponent();
        }

        private void buttonRegistrarAdministrador_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty( textBoxNombre.Text) && textBoxNombre.Text.All(Char.IsLetter))
            {
                if (!string.IsNullOrEmpty(textBoxApellido.Text) && textBoxApellido.Text.All(Char.IsLetter))
                {
                    if (dateTimePickerFechaNacimiento.Value.Date != new DateTime(1900, 1, 1))
                    {
                        if (!string.IsNullOrEmpty(textBoxMail.Text) && InterfazNucleo.EsUnEmailValido(textBoxMail.Text))
                        {
                            if ( !string.IsNullOrEmpty(textBoxTelefono.Text)&&textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11 )
                            {
                                if (!string.IsNullOrEmpty(textBoxContraseña.Text)&&textBoxContraseña.Text.Length >= 4)
                                {
                                    InterfazNucleo.AñadirAdministrador(textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value, textBoxMail.Text, textBoxContraseña.Text, textBoxTelefono.Text);
                                    MessageBox.Show("La cuenta de administrador ha sido creada, su id de accceso es: " + InterfazNucleo.ObtenerUltimoIdAdministrador(), "Operacion Exitosa", MessageBoxButtons.OK);
                                    this.Hide();
                                    Login ventana = new Login();
                                    ventana.Show();
                                    
                                }
                                else
                                {
                                    this.labelError.Text = "Error,la contraseña debe tener al menos 4 digitos";
                                    buttonRegistrarAdministrador.Enabled = false;
                                    textBoxTelefono.Focus(); ;
                                }
                            }
                            else
                            {
                                this.labelError.Text = "Error,telefono ingresado invalido.Ingrese el numero sin 0 ni 15";
                                buttonRegistrarAdministrador.Enabled = false;
                                textBoxTelefono.Focus(); ;
                            }
                        }
                        else
                        {
                            this.labelError.Text = "Error, el mail ingresado no es valido";
                            buttonRegistrarAdministrador.Enabled = false;
                            textBoxMail.Focus(); ;
                        }
                    }
                    else
                    {
                        this.labelError.Text = "Error, no ha ingresado la fecha de nacimiento";
                        buttonRegistrarAdministrador.Enabled = false;
                        dateTimePickerFechaNacimiento.Focus(); ;
                    }

                }
                else
                {
                    this.labelError.Text = "Error, apellido invalido.No debe contener numeros, espacios ni simbolos";
                    buttonRegistrarAdministrador.Enabled = false;
                    textBoxApellido.Focus(); ;
                }
            }
            else
            {
                this.labelError.Text = "Error, nombre invalido.No debe contener numeros, espacios ni simbolos";
                buttonRegistrarAdministrador.Enabled = false;
                textBoxNombre.Focus(); ;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ventanaMenu = new Login();
            ventanaMenu.Show();
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registrarse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Registrarse_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void dateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void labelContraseña_Click(object sender, EventArgs e)
        {
            buttonRegistrarAdministrador.Enabled = true;
            labelError.Text = "";
        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelMail_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }
    }
}
