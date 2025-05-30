using Bitacora;
using Nucleo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{   /// <summary>
    /// Resumen: Este formulario nos permite actualizar los datos de un administrador.
    /// </summary>
    public partial class ActualizarAdministrador : Form
    {
        private readonly FachadaNucleo interfazNucleo = new FachadaNucleo();//Instancia de la fachada del nucleo para realizar operaciones dentro del dominio
        private string contraseñaNueva;//Variable para guardar la contraseña nueva
        private readonly UtilidadesPresentacion utilidades = new UtilidadesPresentacion();
        private readonly IBitacora bitacora = new Bitacora.BitacoraImplementacionPropia();
        private string NombreUsuario { get; set; }

        /// <summary>
        /// Resumen: Constructor de la clase.
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        public ActualizarAdministrador(string pNombreUsuario)//Inicializamos los datos del administrador actual que se van a mostrar en la interfaz
        {
            InitializeComponent();
            NombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = NombreUsuario;
        }

        /// <summary>
        /// Resumen: Este metodo se encarga de volver a la ventana anterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        /// <summary>
        /// Resumen: Este metodo se encarga de guardar los datos del administrador en la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNombre.Text) && textBoxNombre.Text.All(Char.IsLetter))//Verifica si el nombre de usuario no es nulo y que solo contenga letras.
                {
                    if (!string.IsNullOrEmpty(textBoxApellido.Text) && textBoxApellido.Text.All(Char.IsLetter))//Verifica si el apellido de usuario no es nulo y que solo contenga letras.
                    {
                        if (dateTimePickerFechaNacimiento.Value != new DateTime(1900, 1, 1))//Verifica que la fecha sea distinta de 1900/1/1.
                        {
                            if (DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year >= 18 && DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year <= 120)//Verifica que la edad del administrador este entre los 18 y 120 años
                            {
                                if (!string.IsNullOrEmpty(textBoxMail.Text) && utilidades.EsUnEmailValido(textBoxMail.Text))//Verifica que el mail no este vacio y que sea un mail en un formato valido.
                                {
                                    if (!string.IsNullOrEmpty(textBoxTelefono.Text) && textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11)//Verifica que el numero de telefono no este vacio, que todos sus valores sean digitos, y que su longitud este entre 8 y 11 digitos.
                                    {
                                        if (interfazNucleo.ObtenerAdministrador(textBoxNombreUsuario.Text).Baja == false && checkBoxBaja.Checked == true)//Verifica si el administrador esta dado de baja y si el checkbox baja esta checkeado
                                        {
                                            interfazNucleo.ActualizarAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date, textBoxMail.Text, textBoxTelefono.Text);//De ser asi permite actualizar los camops
                                            interfazNucleo.DarDeBajaAdministrador(textBoxNombreUsuario.Text);// Y da de baja al administrador.
                                            MessageBox.Show("Administrador ha sido dado de baja, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);//Mensaje informativo al administrador
                                        }
                                        else if (interfazNucleo.ObtenerAdministrador(textBoxNombreUsuario.Text).Baja == true && checkBoxBaja.Checked == true)//Otra situacion es que el administrador esta dado de baja y ademas el checbox este checkeado
                                        {
                                            interfazNucleo.ActualizarAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date, textBoxMail.Text, textBoxTelefono.Text);//En este caso solo actualiza los datos del administrador
                                            MessageBox.Show("Administrador ha sido dado de baja, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);//Mensaje informativo al administrador
                                        }
                                        else if (interfazNucleo.ObtenerAdministrador(textBoxNombreUsuario.Text).Baja == false && checkBoxBaja.Checked == false)//Otra situacion es que el administrador no este dado de baja y que ademas el checkbox no este checkeado.
                                        {
                                            interfazNucleo.ActualizarAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date, textBoxMail.Text, textBoxTelefono.Text);//En este caso solo actualiza los datos del administrador
                                            MessageBox.Show("Administrador ha sido guardado correctamente, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);//Mensaje informativo al administrador
                                        }
                                        else if (interfazNucleo.ObtenerAdministrador(textBoxNombreUsuario.Text).Baja == true && checkBoxBaja.Checked == false)//Otra situacion es que el administrador este dado de baja y que no este checkeado el checkbox de baja es decir que se de de alta nuevamente.
                                        {
                                            interfazNucleo.ActualizarAdministrador(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date, textBoxMail.Text, textBoxTelefono.Text);//En este caso se actualiza el administrador.
                                            interfazNucleo.DarDeAltaAdministrador(textBoxNombreUsuario.Text);//Y se da de alta nuevamente al administrador.
                                            MessageBox.Show("Administrador ha sido dado de alta y guardado correctamente, el nombre de usuario es: " + textBoxNombreUsuario.Text, "Operacion Exitosa", MessageBoxButtons.OK);//Mensaje informativo al administrador
                                        }
                                        if (contraseñaNueva != null)//Si la contraseña pasada al construtor de la interfaz no es vacio entonces procede a actualizar la contraseña del administrador,
                                        {
                                            interfazNucleo.ActualizarContraseñaAdministrador(textBoxNombreUsuario.Text, contraseñaNueva);
                                        }
                                        this.Hide();//Oculta la ventana actual
                                        ((GestionarAdministradores)Owner).ObtenerAdministradores();//Actualiza el listado de administradores de su owner
                                        this.Owner.Show();//Muestra a su owner(GestionarAdministradores);
                                    }
                                    else//A continuacion todos los else con su correspondiente mensaje de error.
                                    {
                                        this.labelError.Text = "Error,telefono ingresado invalido.Ingrese el numero sin 0 ni 15";
                                        buttonGuardar.Enabled = false;
                                        textBoxTelefono.Focus(); ;
                                    }
                                }
                                else
                                {
                                    this.labelError.Text = "Error, el mail ingresado no es valido";
                                    buttonGuardar.Enabled = false;
                                    textBoxMail.Focus(); ;
                                }
                            }
                            else
                            {
                                if (DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year < 18)
                                {
                                    this.labelError.Text = "Error, el usuario debe ser mayor de 18 años";
                                }
                                else
                                {
                                    this.labelError.Text = "Error, el usuario debe ser menor de 120 años";
                                }
                                buttonGuardar.Enabled = false;
                                textBoxMail.Focus();
                            }
                        }
                        else
                        {
                            this.labelError.Text = "Error, no ha ingresado la fecha de nacimiento";
                            buttonGuardar.Enabled = false;
                            dateTimePickerFechaNacimiento.Focus();
                        }

                    }
                    else
                    {
                        this.labelError.Text = "Error, apellido invalido.No debe contener numeros, espacios ni simbolos";
                        buttonGuardar.Enabled = false;
                        textBoxApellido.Focus(); ;
                    }
                }
                else
                {
                    this.labelError.Text = "Error, nombre invalido.No debe contener numeros, espacios ni simbolos";
                    buttonGuardar.Enabled = false;
                    textBoxNombre.Focus(); ;
                }
            }
            catch (Exception ex)
            {
                string texto = "Error al actualizar el usuario: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error." + ex.Message + ex.StackTrace);
            }
        }

        private void ActualizarAdministrador_Load(object sender, EventArgs e)
        {
        }

        private void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void TextBoxApellido_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }


        private void TextBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void TextBoxMail_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        /// <summary>
        /// Resumen: Este metodo se encarga de volver a la ventana anterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActualizarAdministrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Resumen: Este metodo se encarga de habilitar el boton de guardar cuando se modifica el nombre de usuario.
        private void TextBoxId_TextChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        /// <summary>
        /// Resumen: Este metodo se encarga de cargar los datos del administrador en la ventana.
        /// </summary>
        /// <param name="pNombreUsuario"></param>
        /// <param name="pBaja"></param>
        public void CargarAdministradorExistente(string pNombreUsuario, string pBaja)//Se encarga de inicializar los datos del adminsitrador en la ventana.
        {
            try
            {
                var usuario = interfazNucleo.ObtenerAdministrador(pNombreUsuario);//Obtiene el administrador.
                textBoxNombreUsuario.Text = usuario.NombreUsuario;//Carga los textbox con sus datos correspondientes del administrador.
                textBoxNombre.Text = usuario.Nombre;
                textBoxApellido.Text = usuario.Apellido;
                dateTimePickerFechaNacimiento.Value = usuario.FechaNacimiento;
                textBoxMail.Text = usuario.Mail;
                textBoxTelefono.Text = usuario.Telefono;
                if (pBaja == "True")//Verifica si el administrador esta dado de baja.
                {
                    checkBoxBaja.Checked = true;//Si es asi checkea el checkbox de baja.
                }
            }
            catch (Exception ex)
            {
                string texto = "Error al Cargar Administrador Existente: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        /// <summary>
        /// Resumen: Este metodo se encarga de modificar la contraseña del administrador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModificarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                ModificarContraseña ventana = new ModificarContraseña(textBoxNombreUsuario.Text);
                ventana.ShowDialog(this);
            }
            catch (Exception ex)
            {
                string texto = "Error button Modificar Contraseña: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        /// <summary>
        /// Resumen: Este metodo se encarga de cargar la contraseña nueva del administrador.
        /// </summary>
        /// <param name="contraseña"></param>
        public void CargarContraseña(string contraseña)
        {
            contraseñaNueva = contraseña;
        }

        private void DateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        /// <summary>
        /// Resumen: Este metodo se encarga de dar de baja o alta a un administrador.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxBaja_CheckedChanged(object sender, EventArgs e)//Checkbox que nos permite dar de baja o alta a un administrador
        {
            try
            {
                if (checkBoxBaja.Checked == true)//Si esta checkeado se fija que el administrador pueda darse de baja
                {
                    interfazNucleo.DarDeBajaAdministrador(textBoxNombreUsuario.Text);//Si devuelve falso quiere decir que se trata del adminsitrador principal por lo tanto no puede darse de baja.


                    textBoxNombre.Enabled = false;
                    textBoxApellido.Enabled = false;
                    dateTimePickerFechaNacimiento.Enabled = false;
                    textBoxTelefono.Enabled = false;
                    textBoxMail.Enabled = false;

                }

                else if (checkBoxBaja.Checked == false)//En el caso de que no este checekado permite utilizar las opciones de la ventana.
                {
                    textBoxNombre.Enabled = true;
                    textBoxApellido.Enabled = true;
                    dateTimePickerFechaNacimiento.Enabled = true;
                    textBoxTelefono.Enabled = true;
                    textBoxMail.Enabled = true;
                }
            }
            catch (Exception ex)

            {
                string texto = "Error checkBoxBaja_CheckedChanged: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void Label11_Click(object sender, EventArgs e)
        {
        }

        private void Label6_Click(object sender, EventArgs e)
        {
        }
    }
}
