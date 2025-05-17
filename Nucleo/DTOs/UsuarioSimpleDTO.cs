using System;


namespace Nucleo.DTOs
{   ///<summary>
    ///Resumen: DTO para pasar la informacion de un Usuario Simple a la capa de presentación.
    ///</summary>
    public class UsuarioSimpleDTO : UsuarioDTO
    {

        /// <summary>
        /// Resumen: Propiedad que nos permite acceder al scoring del usuario.
        /// </summary>
        public int Scoring { get; set; }
        /// <summary>
        /// Resumen: Constructor de la clase.
        /// </summary>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="apellido">Apellido del usuario</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del usuario</param>
        /// <param name="mail">Email del usuario</param>
        /// <param name="telefono">Telefono del usuario</param>
        /// <param name="pNombreUsuario">Nombre de usuario</param>
        public UsuarioSimpleDTO(string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono, string pNombreUsuario, int pScoring,bool baja) : base(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario,baja)
        {
            Scoring = pScoring;
        }
        /// <summary>
        /// Resumen: Constructor de la clase sin parametros.
        /// </summary>
        public UsuarioSimpleDTO()
        {
        }

    }
}
