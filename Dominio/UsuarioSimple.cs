using System;
using System.Collections.Generic;

namespace Dominio
{   ///<summary>
    ///Resumen: Esta clase nos permite definir un usuario simple que es quien solicita un prestamo.
    public class UsuarioSimple : Usuario
    {
        /// <summary>
        /// Resumen: Propiedad que nos permite acceder a la lista de prestamos del usuario.
        /// </summary>
        public virtual List<Prestamo> Prestamos { get; set; }
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
        public UsuarioSimple(string nombre, string apellido, DateTime fechaNacimiento, string mail, string telefono, string pNombreUsuario) : base(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario)
        {
            Scoring = 0;
        }
        /// <summary>
        /// Resumen: Constructor de la clase sin parametros.
        /// </summary>
        public UsuarioSimple()
        {
        }
        /// <summary>
        /// Resumen: Este metodo nos permite validar la baja de un usuario.El usuario no puede darse de baja si tiene prestamos sin devolver.
        /// </summary>
        /// <returns></returns>
        public bool ValidarBaja()
        {
            bool resultado = true;
            if (Prestamos == null)
            {
                resultado = true;
            }
            else
            {
                foreach (var item in Prestamos)
                {
                    if (item.EstadoPrestamo == EstadoPrestamo.Devuelto)
                    {
                        resultado = false;
                    }
                }
            }
            return resultado;
        }
    }
}