using System;


namespace Nucleo.DTOs
{
    public class UsuarioAdministradorDTO : UsuarioDTO
    {

        /// <summary>
        /// Resumen: Constructor de la clase que inicializa los atributos de la clase
        /// </summary>
        /// <param name="nombre">Nombre del administrador</param>
        /// <param name="apellido">Apellido del administrador</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del administrador</param>
        /// <param name="mail">Email del administrador</param>
        /// <param name="telefono">Telefono del administrador</param>
        /// <param name="pNombreUsuario">Nombre de usuario</param>
        public UsuarioAdministradorDTO(string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono, string pNombreUsuario,bool baja) : base(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario,baja)//Constructor de la clase que hace uso del contructor de la clase padre
        {
        }

        /// <summary>
        /// Resumen: Constructor de la clase sin parametros
        /// </summary>
        public UsuarioAdministradorDTO()
        {
        }
    }
}
