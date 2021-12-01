﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa
{
    public partial class MenuPrincipal : Form
    {
        private string NombreUsuario { get; set; }
        public MenuPrincipal(string nombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = "Usuario: "+NombreUsuario;
        }
        

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void botonAñadirUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarUsuario ventanaAgregarCliente = new RegistrarUsuario(NombreUsuario);
            ventanaAgregarCliente.Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        { this.Hide();
            Login ventanaLogin = new Login();
            ventanaLogin.Show();
        }

        private void botonVerUsuarios_Click(object sender, EventArgs e)
        {
            VerUsuarios ventana=new VerUsuarios(NombreUsuario);
            this.Hide();
            ventana.Show();
        }

        private void botonBuscarUsuario_Click(object sender, EventArgs e)
        {
            ConsultarUsuario ventana = new ConsultarUsuario();
            this.Hide();
            ventana.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegistrarAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarAdministrador ventana = new RegistrarAdministrador(NombreUsuario);
            ventana.Show();
        }

        private void buttonBuscarAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultarAdministrador ventana = new ConsultarAdministrador();
            ventana.Show();
        }

        private void buttonVerAdministradores_Click(object sender, EventArgs e)
        {
            VerAdministradores ventana = new VerAdministradores(NombreUsuario);
            this.Hide();
            ventana.Show();
        }
    }
}
