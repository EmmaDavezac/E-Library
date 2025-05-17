using Bitacora;
using Nucleo;
using BibliotecaMapeado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class ActualizarLibro : Form
    {
        private readonly FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia de la fachada del nucleo para realizar operaciones dentro del dominio

        private int SumatoriaDeEjemplares { get; set; }//Varible que nos permite guardar las sumatoria de ejemplares que se esta agregando o restando.
        private int IdLibro { get; set; }
        private string NombreUsuario { get; set; }
        private readonly IBitacora bitacora = new Bitacora.BitacoraImplementacionPropia();
        public ActualizarLibro(string nombreUsuario, int pIdLibro)//Inicializamos los datos del administrador actual que se van a mostrar en la interfaz
        {
            InitializeComponent();
            NombreUsuario = nombreUsuario;
            labelNombreUsuario.Text = NombreUsuario;
            IdLibro = pIdLibro;
            SumatoriaDeEjemplares = 0;//Inicializamos en 0.
        }

        private void ActualizarLibro_Load(object sender, EventArgs e)
        //carga la tabla de usuarios al iniciar
        {
            try
            {
                ObtenerEjemplares();
            }
            catch (Exception ex)
            {
                string texto = "ActualizarLibro_Load: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        public void ObtenerEjemplares()//Este metodo carga la lista de ejemplares en la tabla
        {
            try
            {
                IEnumerable<EjemplarDTO> ejemplares = interfazNucleo.ObtenerEjemplaresLibro(IdLibro);//se le solicita la lista de usuarios al Nucleo del programa y se la almacena
                dataGridView1.Rows.Clear();//limpiamos el contenido de la tabla
                foreach (var item in ejemplares)//recorremos cada item de la lista y lo agregamos a la tabla
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[1].Value = item.Id;
                    if (item.Disponible)
                    {
                        dataGridView1.Rows[n].Cells[2].Value = "Disponible";
                    }
                    else
                    {
                        dataGridView1.Rows[n].Cells[2].Value = "Prestado";
                    }


                }
            }
            catch (Exception ex)
            {
                string texto = "Error ObtenerEjemplares: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//este metodo se ejecuta cuando se hace click a una celda de la tabla
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    DataGridViewCell cell = (DataGridViewCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (cell.Value.ToString() == "Eliminar")//si le presiona la celda de la fila con el texto edit, se abre una ventana para modificar la informacion de ese usuario
                    {
                        DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas eliminar el ejemplar?", "Eliminar Ejemplar", MessageBoxButtons.YesNo);//Mensaje de confirmacion para eliminar el ejemplar
                        if (dialogResult == DialogResult.Yes)//Si se confirma la eliminacion se procede a eliminar el ejemplar
                        {
                            interfazNucleo.DarDeBajaEjemplar(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value));
                            ObtenerEjemplares();
                            labelCantidadActual.Text = "Cantidad Actual: " + Convert.ToString(interfazNucleo.ObtenerEjemplaresLibro(IdLibro).Count());//Actualiza la cantidad actual(Explicado en el metodo InicializarLibro)

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string texto = "Error dataGridView1_CellContentClick: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }


        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void ButtonDeshacerCambios_Click(object sender, EventArgs e)
        {
            try
            {
                LibroDTO libro = interfazNucleo.ObtenerLibro(Convert.ToInt32(IdLibro));
                textBoxTitulo.Text = libro.Titulo;
                textBoxAutor.Text = libro.Autor;
                textBoxAñoPublicacion.Text = libro.AñoPublicacion;
                textBoxISBN.Text = libro.ISBN;
                buttonDeshacerCambios.Enabled = false;
                buttonGuardar.Enabled = false;
            }
            catch (Exception ex)
            {
                string texto = "Error buttonDeshacerCambios_Click: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error." + ex.Message + ex.StackTrace);

            }
        }

        private void TextBoxAutor_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void TextBoxTitulo_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void TextBoxISBN_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void TextBoxAñoPublicacion_TextChanged(object sender, EventArgs e)
        {
            buttonDeshacerCambios.Enabled = true;
            buttonGuardar.Enabled = true;
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (interfazNucleo.ObtenerLibro(IdLibro).Baja == false && checkBoxBaja.Checked == true)//En el caso de que el libro no este dado de baja y el checkbox este tildado hace lo siguiente.
                {
                    if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))//Si no hay compos vacios
                    {
                        interfazNucleo.ActualizarLibro(IdLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);//Actualiza el libro
                        interfazNucleo.DarDeBajaUnLibro(IdLibro);//Da de baja el libro.
                        MessageBox.Show("El libro Id:" + IdLibro + " ha sido dado de baja exitosamente!");//Mensaje informativo al administrador
                    }
                    else//En el caso que falte completar algun dato.
                    {
                        MessageBox.Show("Debe completar la informacion");//Mensaje informativo al administrador
                        textBoxTitulo.Focus();
                    }
                }
                else if (interfazNucleo.ObtenerLibro(IdLibro).Baja == true && checkBoxBaja.Checked == false)//En el caso que este dado de baja pero este deschekeado el textbox hace lo siguiente.
                {
                    if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))//Verifica que ningun campo este vacio.
                    {
                        interfazNucleo.DarDeAltaUnLibro(IdLibro);//Da de alta al libro.
                        interfazNucleo.ActualizarLibro(IdLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);//Actualiza el libro

                        MessageBox.Show("El libro Id:" + IdLibro + " a sido dado de alta y se ha actualizado exitosamente!");//Mensaje informativo al administrador
                    }
                    else//En el caso que falte completar algun dato.
                    {
                        MessageBox.Show("Debe completar la informacion");//Mensaje informativo al administrador
                        textBoxTitulo.Focus();
                    }
                }
                else if (interfazNucleo.ObtenerLibro(IdLibro).Baja == false && checkBoxBaja.Checked == false)//En el caso en que no este dado de baja y este checkeado hace lo siguiente.
                {
                    if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))//Verifica que ningun campo este vacio.
                    {
                        interfazNucleo.ActualizarLibro(IdLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);//Actualiza el libro


                        MessageBox.Show("El libro Id:" + IdLibro + " se ha actualizado exitosamente!");//Mensaje informativo al administrador
                    }
                    else//En el caso que falte completar algun dato.
                    {
                        MessageBox.Show("Debe completar la informacion");//Mensaje informativo al administrador
                        textBoxTitulo.Focus();
                    }
                }
                else if (interfazNucleo.ObtenerLibro(IdLibro).Baja == true && checkBoxBaja.Checked == true)//Si el liro esta dado de baja el checkbox esta tildado hace lo siguiente.
                {
                    if (!string.IsNullOrEmpty(textBoxTitulo.Text) && !string.IsNullOrEmpty(textBoxAutor.Text) && !string.IsNullOrEmpty(textBoxISBN.Text) && !string.IsNullOrEmpty(textBoxAñoPublicacion.Text))//Verifica que ningun campo este vacio.
                    {
                        interfazNucleo.ActualizarLibro(IdLibro, textBoxISBN.Text, textBoxTitulo.Text, textBoxAutor.Text, textBoxAñoPublicacion.Text);//Actualiza el libro
                        MessageBox.Show("El libro Id:" + IdLibro + " ha sido actualizado correctamente!");//Mensaje informativo al administrador
                    }
                    else
                    {
                        MessageBox.Show("Debe completar la informacion");//Mensaje informativo al administrador
                        textBoxTitulo.Focus();
                    }
                }
                this.Hide();//Esta ventana se oculta y se muestra el owner(GestionarLibros).
                ((GestionarLibros)this.Owner).ObtenerLibros();
                this.Owner.Show();
            }
            catch (Exception ex)
            {
                string texto = "Error al actualizar libro: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }




        private void ActualizarLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonBusquedaAvanzada_Click(object sender, EventArgs e)//Botton que nos permite ir al buscador por medio de la api libros, permitiendonos modificar de manera mas rapida el libro.
        {
            try
            {
                RegistrarLibro ventana = new RegistrarLibro(NombreUsuario);
                this.Hide();
                ventana.InicializarLibro(IdLibro);//Carga los datos del libro en la nueva ventana.
                ventana.Show(this);
            }
            catch (Exception ex)
            {
                string texto = "Error buttonBusquedaAvanzada_Click: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        public void CargarDatosDeBusquedaAvanzada(string pTitulo, string pAutor, string pAñoPublicacion, string pISBN)//Se encarga traer los datos actualizados de la ventana del metodo anterior.
        {
            textBoxAutor.Text = pAutor;
            textBoxAñoPublicacion.Text = pAñoPublicacion;
            textBoxISBN.Text = pISBN;
            textBoxTitulo.Text = pTitulo;
        }



        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        public void InicializarLibro(string pISBN, string pTitulo, string pAutor, string pAñoPublicacion, string pBaja)//Se encarga de cargar los datos del libro en la ventana actual.
        {
            try
            {
                textBoxTitulo.Text = pTitulo;
                textBoxISBN.Text = pISBN;
                textBoxAutor.Text = pAutor;
                textBoxAñoPublicacion.Text = pAñoPublicacion;
                labelCantidadActual.Text = "Cantidad Actual: " + interfazNucleo.ObtenerEjemplaresDisponiblesLibro(IdLibro).Count().ToString();//Para mostrar la cantidad actual cuenta la cantidad de ejemplares que estan diponibles.(Aquellos en un prestamo no pueden ser eliminados)
                if (pBaja == "True")//Si esta dado de baja se tilda el checkbox
                {
                    checkBoxBaja.Checked = true;
                }
            }
            catch (Exception ex)
            {
                string texto = "Error InicializarLibro: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void ButtonAñadirEjemplares_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxAñadirEjemplares.Text))//Si el textbox relacionado a añadir ejemplares no esta vacio entonces:
                {
                    DialogResult dialogResult = MessageBox.Show("¿Estas seguro que deseas añadir " + Convert.ToInt32(textBoxAñadirEjemplares.Text) + " ejemplares?", "Añadir Ejemplares", MessageBoxButtons.YesNo);//Mensaje de confirmacion para eliminar el ejemplar

                    interfazNucleo.AñadirEjemplares(IdLibro, Convert.ToInt32(textBoxAñadirEjemplares.Text));//Añade los ejemplares al libro.
                    labelCantidadActual.Text = "Cantidad Actual: " + Convert.ToString(interfazNucleo.ObtenerEjemplaresLibro(IdLibro).Count());//Actualiza la cantidad actual(Explicado en el metodo InicializarLibro)
                    textBoxAñadirEjemplares.Text = "";

                    ObtenerEjemplares();
                }
                else
                {
                    MessageBox.Show("Error,campo cantidad vacio");//Label informativo para el administrador.
                }
            }
            catch (Exception ex)
            {
                string texto = "Error buttonAñadirEjemplares_Click: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }


        private void CheckBoxBaja_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxBaja.Checked == true)//Si el checkbox esta tildado entonces hace lo siguiente:
                {
                    if (interfazNucleo.ObtenerEjemplaresDisponiblesLibro(IdLibro).Count() != interfazNucleo.ObtenerEjemplaresLibro(IdLibro).Count() && interfazNucleo.ObtenerEjemplaresDisponiblesLibro(IdLibro).Count() != 0 && interfazNucleo.ObtenerEjemplaresDisponiblesLibro(IdLibro).Count() != 0)//En el caso en que la cantidad disponible sea menor a la cantidad total, no puede darse de baja ya que esto nos quiere decir que hay un prestamo activo.
                    {
                        checkBoxBaja.Checked = false;
                        MessageBox.Show("El libro Id:" + IdLibro + " no puede darse de baja ya que tiene prestamos pendientes!, intentelo mas tarde");//Mensaje informativo para el administrador.
                    }
                    else//En caso contrario descativa todas las opciones de la ventana.
                    {
                        textBoxAutor.Enabled = false;
                        textBoxTitulo.Enabled = false;
                        textBoxISBN.Enabled = false;
                        textBoxAutor.Enabled = false;
                        textBoxAñoPublicacion.Enabled = false;
                        textBoxAñadirEjemplares.Enabled = false;
                        buttonAñadirEjemplares.Enabled = false;
                        buttonDeshacerCambios.Enabled = false;
                        buttonBusquedaAvanzada.Enabled = false;
                        labelCantidadActual.Text = "Cantidad Actual: 0";//Coloca la cantidad actual en 0.
                    }
                }

                else if (checkBoxBaja.Checked == false)//En caso contrario permite acceder a todas las opciones de la ventana.
                {
                    {
                        textBoxAutor.Enabled = true;
                        textBoxTitulo.Enabled = true;
                        textBoxISBN.Enabled = true;
                        textBoxAutor.Enabled = true;
                        textBoxAñoPublicacion.Enabled = true;
                        textBoxAñadirEjemplares.Enabled = true;
                        buttonAñadirEjemplares.Enabled = true;
                        buttonDeshacerCambios.Enabled = true;
                        buttonBusquedaAvanzada.Enabled = true;
                        labelCantidadActual.Text = "Cantidad Actual: " + Convert.ToString(interfazNucleo.ObtenerEjemplaresDisponiblesLibro(IdLibro).Count());
                    }
                }
            }
            catch (Exception ex)
            {
                string texto = "Error checkBoxBaja_CheckedChanged: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }



        private void TextBoxAñadirEjemplares_TextChanged(object sender, EventArgs e)
        {
            labelErrorAñadirEjemplares.Visible = false;
        }

        private void LabelCantidadActual_Click(object sender, EventArgs e)
        {

        }
    }
}

