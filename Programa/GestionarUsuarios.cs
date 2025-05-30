using Bitacora;
using Nucleo;
using BibliotecaMapeado;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Programa
{
    public partial class GestionarUsuarios : Form
    /*La finalidad de este formulario es permitir ver la informacion de todos los usuarios simples y poder modificarla*/
    {
        private readonly string nombreUsuario;//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private readonly FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo
        private readonly IBitacora bitacora = new Bitacora.BitacoraImplementacionPropia();

        public GestionarUsuarios(string pNombreUsuario)//Constructor de la clase
        {
            InitializeComponent();
            nombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = nombreUsuario;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxId_TextChanged(object sender, EventArgs e)
        //este evento se ejecuta cuando se modifica el texto de textBoxId y nos permite buscar un usuario escribiendo su nombre de usuario
        {
            try
            {
                if (textBoxNombreUsuario.Text != null)
                {
                    for (int i = 0; i < dataGridViewUsuarios.Rows.Count - 1; i++)
                    {
                        if (dataGridViewUsuarios.Rows[i].Cells[1].Value.ToString().Contains(textBoxNombreUsuario.Text.ToString()) == false)
                        {
                            dataGridViewUsuarios.Rows[i].Visible = false;
                        }
                        else
                        {
                            dataGridViewUsuarios.Rows[i].Visible = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string texto = "Error textBoxId_TextChanged: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)//este evento se ejecutara cuando se presione el boton botonVolver
        {
            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        private void ConsultarUsuario_FormClosed(object sender, FormClosedEventArgs e)//este evento se ejecutara cuando se cierre el formulario
        {
            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }



        private void ConsultarUsuario_Load(object sender, EventArgs e)
        //carga la tabla de usuarios al iniciar
        {
            try
            {
                ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                string texto = "Error ConsultarUsuario_Load: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }





        public void ObtenerUsuarios()//Este metodo carga la lista de usuario en la tabla
        {
            try
            {
                IEnumerable<UsuarioSimpleDTO> usuarios = interfazNucleo.ObtenerUsuarios();//se le solicita la lista de usuarios al Nucleo del programa y se la almacena
                dataGridViewUsuarios.Rows.Clear();//limpiamos el contenido de la tabla
                foreach (var item in usuarios)//recorremos cada item de la lista y lo agregamos a la tabla
                {
                    int n = dataGridViewUsuarios.Rows.Add();
                    dataGridViewUsuarios.Rows[n].Cells[1].Value = item.NombreUsuario;
                    dataGridViewUsuarios.Rows[n].Cells[2].Value = item.Scoring;
                    dataGridViewUsuarios.Rows[n].Cells[2].Style.Font = new Font(dataGridViewUsuarios.Font, FontStyle.Bold);
                    if (item.Scoring >= 0)
                    {
                        dataGridViewUsuarios.Rows[n].Cells[2].Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        dataGridViewUsuarios.Rows[n].Cells[2].Style.ForeColor = Color.Red;
                    }
                    dataGridViewUsuarios.Rows[n].Cells[3].Value = item.Nombre;
                    dataGridViewUsuarios.Rows[n].Cells[4].Value = item.Apellido;
                    dataGridViewUsuarios.Rows[n].Cells[5].Value = item.FechaNacimiento.ToShortDateString();
                    dataGridViewUsuarios.Rows[n].Cells[6].Value = item.Mail;
                    dataGridViewUsuarios.Rows[n].Cells[7].Value = item.Telefono;
                    dataGridViewUsuarios.Rows[n].Cells[8].Value = item.Baja.ToString();
                    if (item.Baja == true)
                    {
                        dataGridViewUsuarios.Rows[n].DefaultCellStyle.BackColor = Color.Firebrick;
                        dataGridViewUsuarios.Rows[n].DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                string texto = "Error ObtenerUsuarios: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void DataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)//este metodo se ejecuta cuando se hace click a una celda de la tabla
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewCell cell = (DataGridViewCell)dataGridViewUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (cell.Value.ToString() == "Edit")//si le presiona la celda de la fila con el texto edit, se abre una ventana para modificar la informacion de ese usuario
                    {
                        ActualizarUsuario ventana = new ActualizarUsuario(nombreUsuario);
                        ventana.CargarUsuarioExistente(dataGridViewUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridViewUsuarios.Rows[e.RowIndex].Cells[8].Value.ToString());
                        this.Hide();
                        ventana.Show(this);
                    }
                }
            }
            catch (Exception ex)
            {
                string texto = "Error dataGridViewUsuarios_CellContentClick: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void LabelErro_Click(object sender, EventArgs e)
        {

        }



        private void LabelTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
