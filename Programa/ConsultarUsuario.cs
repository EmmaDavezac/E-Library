﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Nucleo;

namespace Programa
{
    public partial class ConsultarUsuario : Form
    {
        private string nombre { get; set; }
        private string nombreUsuario { get; set; }
        private InterfazNucleo interfazNucleo = new InterfazNucleo();
       
        public ConsultarUsuario(string pNombreUsuario)
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            nombre = interfazNucleo.ObtenerAdministradorPorNombreOMail(nombreUsuario).Nombre;
            labelNombreUsuario.Text = "Usuario: " + nombre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxNombreUsuario.Text != null && textBoxNombreUsuario.Text != "")
            {
                UsuarioSimple usuarioSimple = interfazNucleo.ObtenerUsuarioPorNombreOMail(textBoxNombreUsuario.Text);
                if (usuarioSimple != null) 
                { 
                buttonBuscarUsuario.Enabled = false; textBoxNombreUsuario.Focus(); 
                dataGridViewUsuarios.Rows.Clear();
                dataGridViewUsuarios.Rows.Add();
                dataGridViewUsuarios.Rows[0].Cells[1].Value = usuarioSimple.NombreUsuario;
                dataGridViewUsuarios.Rows[0].Cells[2].Value = usuarioSimple.Scoring;
                dataGridViewUsuarios.Rows[0].Cells[3].Value = usuarioSimple.Nombre;
                dataGridViewUsuarios.Rows[0].Cells[4].Value = usuarioSimple.Apellido;
                dataGridViewUsuarios.Rows[0].Cells[5].Value = usuarioSimple.FechaNacimiento.ToShortDateString(); 
                dataGridViewUsuarios.Rows[0].Cells[6].Value = usuarioSimple.Mail;
                dataGridViewUsuarios.Rows[0].Cells[7].Value = usuarioSimple.Telefono;
                }
                else
                {
                    labelErro.Text = "Error, el usuario ingresado no existe";
                    buttonBuscarUsuario.Enabled = false;
                    textBoxNombreUsuario.Focus();
                }
            }
            else
            {
                buttonBuscarUsuario.Enabled = false;
                textBoxNombreUsuario.Focus();
            }


        }
        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonBuscarUsuario.Enabled = true;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu2 ventana = new Menu2(nombreUsuario.ToString());
            ventana.Show();
        }

        private void ConsultarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Menu2 ventanaMenu = new Menu2(nombreUsuario);
            ventanaMenu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConsultarUsuario_Load(object sender, EventArgs e)
        {
            ObtenerUsuarios();
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ObtenerUsuarios()
        {
            IEnumerable<UsuarioSimple> usuarios = interfazNucleo.ObtenerUsuarios();
            dataGridViewUsuarios.Rows.Clear();
            foreach (var item in usuarios)
            {
                int n = dataGridViewUsuarios.Rows.Add();
                dataGridViewUsuarios.Rows[n].Cells[1].Value = item.NombreUsuario;
                dataGridViewUsuarios.Rows[n].Cells[2].Value = item.Scoring;
                dataGridViewUsuarios.Rows[n].Cells[3].Value = item.Nombre;
                dataGridViewUsuarios.Rows[n].Cells[4].Value = item.Apellido;
                dataGridViewUsuarios.Rows[n].Cells[5].Value = item.FechaNacimiento.ToShortDateString(); 
                dataGridViewUsuarios.Rows[n].Cells[6].Value = item.Mail;
                dataGridViewUsuarios.Rows[n].Cells[7].Value = item.Telefono;
            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = (DataGridViewCell)dataGridViewUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Edit")
            {
                ActualizarUsuario ventana = new ActualizarUsuario(nombreUsuario);
                ventana.CargarUsuarioExistente(dataGridViewUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString());
                this.Hide();
                ventana.Show();
            }
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            ObtenerUsuarios();
        }

        private void labelErro_Click(object sender, EventArgs e)
        {

        }
    }
}
