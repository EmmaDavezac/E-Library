using Bitacora;
using Nucleo;
using BibliotecaMapeado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Programa
{
    public partial class RegistrarLibro : Form//La finalidad de este formulario es la de permitir registrar un nuevo libro
    {
        private string NombreUsuario { get; set; }//Aqui se almacena el nombre de usuario del administrador que esta usando el programa
        private readonly FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia del nucleo del programa que nos permite acceder a las funciones del mismo

        private readonly UtilidadesPresentacion utilidades = new UtilidadesPresentacion();
        private readonly IBitacora bitacora = new Bitacora.BitacoraImplementacionPropia();
        public RegistrarLibro(string pNombreUsuario)//Constructor de la clase
        {
            InitializeComponent();
            NombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = "Usuario: " + NombreUsuario;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//se ejecuta cuando se pselecciona un libro  de la tabla de libros
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridViewTituloYAutor.CurrentRow.Cells[0].Value != null)//se verifica que la fila seleccionada no este vacia
                {
                    textBoxTitulo.Text = dataGridViewTituloYAutor.CurrentRow.Cells[0].Value.ToString();//se muestra en pantalla el titulo del libro seleccionado
                    textBoxAutor.Text = dataGridViewTituloYAutor.CurrentRow.Cells[1].Value.ToString();//se muestra en pantalla el nombre del autor del libro seleccionado
                    textBoxAñoPublicacion.Text = dataGridViewTituloYAutor.CurrentRow.Cells[2].Value.ToString();

                    buttonBorrarDatos.Enabled = true;//se activa el boton borrar datos


                }
            }
            catch (Exception ex)
            {
                string texto = "dataGridView1_CellContentClick: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error." + ex.Message + ex.StackTrace);

            }
        }

        private void BuscarLibrosAPI_Load(object sender, EventArgs e)
        {
            VerificarVentanaPadre();
        }

        private void Button1_Click(object sender, EventArgs e)//este men todo se ejecutara cuando se presione button1, nos permite hacer una consulta a open library y obtener una lista de libros
        {
            try
            {

                if (textBoxBuscar.Text != null && textBoxBuscar.Text != "")//se verifica que el cuadro de busqueda no este vacio
                {
                    int resultado = 0;
                    dataGridViewTituloYAutor.Rows.Clear();//se limpia la tabla de libros
                    List<LibroDTO> resultados = interfazNucleo.ListarLibrosDeAPIPorCoincidencia(textBoxBuscar.Text);//se realiza la consulta a Open Library y se almacena la lista de libros
                    foreach (var item in resultados)//se carga cada uno de los resultados en la tabla de libros
                    {
                        int n = dataGridViewTituloYAutor.Rows.Add();
                        dataGridViewTituloYAutor.Rows[n].Cells[0].Value = item.Titulo;
                        dataGridViewTituloYAutor.Rows[n].Cells[1].Value = utilidades.SacarAutorDeLaLista(item.Autor);
                        dataGridViewTituloYAutor.Rows[n].Cells[2].Value = item.AñoPublicacion;
                        resultado += 1;
                    }

                    if (resultado == 0)
                    {
                        MessageBox.Show("No se encontraron resultados");
                    }//en el caso de no encontrarse resultados , se muestra un mensaje en pantalla y se desabilita en boton buscar
                    else
                    {
                        labelResultados.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("No ingresó un termino de busqueda");
                }
                textBoxBuscar.Focus(); //enfocamos el cuadro de busqueda
                buttonBuscar.Enabled = false; //se desabilita el boton buscar
            }
            catch (Exception ex)
            {

                string texto = "Error button1_click: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error." + ex.Message + ex.StackTrace);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)//activa el boton buscar cuando se modifica el texto de textBox1
        {
            buttonBuscar.Enabled = true;

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAñadirLibro_Click(object sender, EventArgs e)
        //se ejecuta cuando se presiona el boton añadir libro, registra el libro en el caso de que se haya ingresado toda la informacion del libro y posea el formato correcto
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
                //se verifica que se haya ingresado toda la informacion necesaria
                {
                    interfazNucleo.AñadirLibro(textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);

                    MessageBox.Show("Libro registrado con exito! ");//se muestra el mensaje en pantalla
                }
                else
                {
                    MessageBox.Show("Debe completar la informacion");//se muestra el mensaje en pantalla
                    textBoxTitulo.Focus();
                    //se  enfoca el cuadro de texto del titulo
                }
            }
            catch (Exception ex)
            {
                string texto = "Error buttonAñadirLibro_Click: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error." + ex.Message + ex.StackTrace);
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)//se ejecuta cuando se presiona el boton volver
        {
            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        private void BuscarLibrosAPI_FormClosed(object sender, FormClosedEventArgs e)//se ejecuta cuando se cierra la ventana
        {
            this.Hide();//la ventana se oculta
            this.Owner.Show();//se muestra la ventana padre
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ButtonBorrarDatos_Click(object sender, EventArgs e)
        //borra el contenido de los textbox con la informacion del libro a registrar cuando se presiona el boton  borrar datos
        {
            textBoxAutor.Clear();
            textBoxAñoPublicacion.Clear();
            textBoxISBN.Clear();
            textBoxTitulo.Clear();
            //borra los datos de los textboxs

        }

        private void LabelIngreseISBN_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxBuscarPorISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonBuscarPorISBN_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }






        private void LabelSeleccionarAño_Click(object sender, EventArgs e)
        {

        }

        public void VerificarVentanaPadre()//este metodo identifica la ventana padre y a partir de esto muestra u oculta funciones 
        {
            try
            {
                if (this.Owner.Name == "MenuPrincipal")
                {
                    botonAñadirLibro.Visible = true;
                    buttonActualizar.Visible = false;
                }
                else if (this.Owner.Name == "ActualizarLibro")
                {
                    buttonActualizar.Visible = true;
                    botonAñadirLibro.Visible = false;

                }
            }
            catch (Exception ex)
            {
                string texto = "Error VerificarVentanaPadre: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error." + ex.Message + ex.StackTrace);
            }
        }

        public void InicializarLibro(int idLibro)//carga los textbox con los datos del libro pasado como parametro
        {
            try
            {
                var libro = interfazNucleo.ObtenerLibro(idLibro);
                textBoxAutor.Text = libro.Autor;
                textBoxAñoPublicacion.Text = libro.AñoPublicacion;
                textBoxISBN.Text = libro.ISBN;
                textBoxTitulo.Text = libro.Titulo;
                textBoxBuscar.Text = libro.Titulo;
                Button1_Click(this, null);
            }
            catch (Exception ex)
            {
                string texto = "Error InicializarLibro: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error." + ex.Message + ex.StackTrace);
            }
        }
        private void ButtonActualizar_Click_1(object sender, EventArgs e)
        //se ejecuta cuando se presiona el boton actualizar
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))
                {

                    ((ActualizarLibro)this.Owner).CargarDatosDeBusquedaAvanzada(textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text, textBoxISBN.Text);
                    MessageBox.Show("Informacion actualizadacon exito");
                    this.Hide();
                    this.Owner.Show();
                }
                else
                {
                    MessageBox.Show("Debe completar la informacion");
                    textBoxTitulo.Focus();
                }
            }
            catch (Exception ex)
            {
                string texto = "Error buttonActualizar_Click1: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }



        private void TextBoxCantidadEjemplares_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
