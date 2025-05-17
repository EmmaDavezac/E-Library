using System;

namespace Nucleo.DTOs
{
    public class UsuarioDTO
    {   ///<summary>
        ///Resumen: Nombre o nombres del usuario
        ///</summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Resumen: Apellido o Apellidos del usuario
        /// </summary>
        public string Apellido { get; set; }
        /// <summary>   
        /// Resumen: Fecha de nacimiento del usuario.
        /// </summary>
        public DateTime FechaNacimiento { get; set; }
        /// <summary>
        /// Resumen: Email del usuario
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Resumen: Telefono del usuario
        /// </summary>
        public string Telefono { get; set; }
        /// <summary>
        /// Resumen: Nombre de usuario, nos permite diferenciar a los usuarios.
        /// </summary>

        public string nombreUsuario { get; set; }
        /// <summary>
        /// Resumen: Campo para dar una baja logica al usuario
        /// </summary>
        public bool Baja { get; set; }
        /// <summary>
        /// Resumen: Constructor de la clase
        /// </summary>
        /// <param name="nombre">Nombre o nombres del usuario</param>
        /// <param name="apellido">Apellido o apelidos del usuario</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del usuario</param>
        /// <param name="mail">Email del usuario</param>
        /// <param name="telefono">Telefono del usuario</param>
        /// <param name="pNombreUsuario">Nombre de usuario</param>
        public UsuarioDTO(string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono, string pNombreUsuario,bool baja)//constructor de la clase
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Mail = mail;
            Telefono = telefono;
            nombreUsuario = pNombreUsuario;
            Baja = baja;
        }
        /// <summary>
        /// Resumen: Constructor de la clase sin parametros
        /// </summary>
        public UsuarioDTO()
        {
        }
    }
}
