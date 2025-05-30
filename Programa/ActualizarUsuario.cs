using Bitacora;
using Nucleo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Programa
{
    public partial class ActualizarUsuario : Form
    {
        private readonly FachadaNucleo interfazNucleo = new FachadaNucleo();
        private string NombreUsuario { get; set; }

        private readonly UtilidadesPresentacion utilidades = new UtilidadesPresentacion();
        private readonly IBitacora bitacora = new Bitacora.BitacoraImplementacionPropia();
        public ActualizarUsuario(string pNombreUsuario)
        {
            InitializeComponent();
            NombreUsuario = pNombreUsuario;
            labelNombreUsuario.Text = NombreUsuario;
        }


        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxNombre.Text) && textBoxNombre.Text.All(Char.IsLetter))
                {
                    if (!string.IsNullOrEmpty(textBoxApellido.Text) && textBoxApellido.Text.All(Char.IsLetter))
                    {
                        if (dateTimePickerFechaNacimiento.Value != new DateTime(1900, 1, 1))
                        {
                            if (DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year >= 12 && DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year <= 120)
                            {
                                if (!string.IsNullOrEmpty(textBoxMail.Text) && utilidades.EsUnEmailValido(textBoxMail.Text))
                                {
                                    if (!string.IsNullOrEmpty(textBoxTelefono.Text) && textBoxTelefono.Text.All(Char.IsDigit) && textBoxTelefono.Text.Length >= 8 && textBoxTelefono.Text.Length <= 11)
                                    {
                                        if (interfazNucleo.ObtenerUsuario(textBoxNombreUsuario.Text).Baja == false && checkBoxBaja.Checked == true)
                                        {
                                            interfazNucleo.ActualizarUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date, textBoxMail.Text, textBoxTelefono.Text);
                                            
                                            interfazNucleo.DarDeBajaUsuario(textBoxNombreUsuario.Text);
                                            MessageBox.Show("Usuario ha sido dado de baja y guardado correctamente: ", "Operacion Exitosa", MessageBoxButtons.OK);
                                        }
                                      
                                        else if (interfazNucleo.ObtenerUsuario(textBoxNombreUsuario.Text).Baja == checkBoxBaja.Checked )
                                        {
                                            interfazNucleo.ActualizarUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date, textBoxMail.Text, textBoxTelefono.Text);
                                            MessageBox.Show("La información ha sido guardada correctamente.", "Operacion Exitosa", MessageBoxButtons.OK);
                                        }
                                        else if (interfazNucleo.ObtenerUsuario(textBoxNombreUsuario.Text).Baja == true && checkBoxBaja.Checked == false)
                                        {
                                            interfazNucleo.ActualizarUsuario(textBoxNombreUsuario.Text, textBoxNombre.Text, textBoxApellido.Text, dateTimePickerFechaNacimiento.Value.Date, textBoxMail.Text, textBoxTelefono.Text);
                                            interfazNucleo.DarDeAltaUsuario(textBoxNombreUsuario.Text);
                                            MessageBox.Show("Usuario ha sido dado de alta y guardado correctamente", "Operacion Exitosa", MessageBoxButtons.OK);
                                        }
                                        this.Hide();
                                        ((GestionarUsuarios)Owner).ObtenerUsuarios();
                                        this.Owner.Show();
                                    }
                                    else
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
                                if (DateTime.Now.Year - dateTimePickerFechaNacimiento.Value.Date.Year < 12)
                                {
                                    this.labelError.Text = "Error, el usuario debe ser mayor de 12 años";
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
                            dateTimePickerFechaNacimiento.Focus(); ;
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
                string texto = "Error buttonGuardar_Click: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }

        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void LabelNombre_Click(object sender, EventArgs e)
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

        private void ActualizarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        public void CargarUsuarioExistente(string pNombreUsuario, string pBaja)
        {
            try
            {
                var usuario = interfazNucleo.ObtenerUsuario(pNombreUsuario);
                textBoxNombreUsuario.Text = usuario.NombreUsuario;
                textBoxNombre.Text = usuario.Nombre;
                textBoxApellido.Text = usuario.Apellido;
                dateTimePickerFechaNacimiento.Value = usuario.FechaNacimiento;
                textBoxMail.Text = usuario.Mail;
                textBoxTelefono.Text = usuario.Telefono;
                if (pBaja == "True")
                {
                    checkBoxBaja.Checked = true;
                }
            }
            catch (Exception ex)
            {
                string texto = "Error CargarUsuarioExistente: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(texto);
                MessageBox.Show(texto, "Ha ocurrido un error");
            }
        }


        private void BotonVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void DateTimePickerFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            buttonGuardar.Enabled = true;
        }

        private void CheckBoxBaja_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxBaja.Checked == true)
                {
                    interfazNucleo.DarDeBajaUsuario(textBoxNombreUsuario.Text);

                    textBoxNombre.Enabled = false;
                    textBoxApellido.Enabled = false;
                    dateTimePickerFechaNacimiento.Enabled = false;
                    textBoxTelefono.Enabled = false;
                    textBoxMail.Enabled = false;

                }

                else if (checkBoxBaja.Checked == false)
                {
                    {
                        textBoxNombre.Enabled = true;
                        textBoxApellido.Enabled = true;
                        dateTimePickerFechaNacimiento.Enabled = true;
                        textBoxTelefono.Enabled = true;
                        textBoxMail.Enabled = true;
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
    }
}
