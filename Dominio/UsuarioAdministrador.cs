﻿using System;

namespace Dominio
{   ///<summary>
    ///Resumen: Esta clase representa un UsuarioAdministrador que es quien usa el programa.
    ///</summary>
    public class UsuarioAdministrador : Usuario
    {


        ///<summary>
        ///Resumen: Contraseña para acceder al programa.
        ///</summary>
        public string Pass { get; set; }

        /// <summary>
        /// Resumen: Metodo que nos permite saber si la contraseña ingresada para acceder es correcta sin divulgar la contraseña real
        /// </summary>
        /// <param name="contraseña">Contraseña a verificar</param>
        /// <returns></returns>


        /// <summary>
        /// Resumen: Constructor de la clase que inicializa los atributos de la clase
        /// </summary>
        /// <param name="nombre">Nombre del administrador</param>
        /// <param name="apellido">Apellido del administrador</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del administrador</param>
        /// <param name="mail">Email del administrador</param>
        /// <param name="contraseña">Constraseña de inicio de sesion del administrador</param>
        /// <param name="telefono">Telefono del administrador</param>
        /// <param name="pNombreUsuario">Nombre de usuario</param>
        public UsuarioAdministrador(string nombre, string apellido, DateTime fechaNacimiento, string mail, string contraseña, string telefono, string pNombreUsuario) : base(nombre, apellido, fechaNacimiento, mail, telefono, pNombreUsuario)//Constructor de la clase que hace uso del contructor de la clase padre
        {
            Pass = contraseña;
        }
       
        /// <summary>
        /// Resumen: Constructor de la clase sin argumentos
        /// </summary>
        public UsuarioAdministrador()
        {
        }
    }
}
