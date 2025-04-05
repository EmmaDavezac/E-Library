using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dominio.Tests
{   /// <summary>
    /// Pruebas unitarias de la clase UsuarioSimple
    /// </summary>
    [TestClass]
    public class UsuarioSimpleTests
    {
        [TestCategory("HappyPath")]
        /// <summary>
        /// Resumen:Prueba unitaria que valida el metodo ValidarBaja siguiendo un camino feliz de un usuario sin prestamos
        /// </summary>
        [TestMethod]
        public void ValidarBaja_HappyPath1_UsuarioSinPrestamos()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");

            //Act
            bool resultado = unUsuario.ValidarBaja();

            //Assert
            Assert.AreEqual(true, resultado);
        }

        /// <summary>
        /// Resumen:Prueba unitaria que valida el metodo ValidarBaja siguiendo un camino feliz de un usuario con un prestamo devuelto
        /// </summary>
        [TestMethod]
        public void ValidarBaja_HappyPath1_UsuarioConUnPrestamoDevuelto()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, DateTime.Now.AddDays(10), unEjemplar);
            unPrestamo.EstadoPrestamo = EstadoPrestamo.Devuelto;
            //Act
            bool resultado = unUsuario.ValidarBaja();

            //Assert
            Assert.AreEqual(true, resultado);
        }

        [TestCategory("UnhappyPath")]
        /// <summary>
        /// Resumen:Prueba unitaria que valida el metodo ValidarBaja siguiendo un camino fallido donde el usuario tiene un prestamo activo
        /// </summary>
        [TestMethod]
        public void ValidarBaja_UnhappyPath1_UsuarioConUnPrestamoActivo()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("Juan", "Gomez", new DateTime(2000, 2, 2), "juan@gomez.con", "343812345678", "juangomez");
            Libro unLibro = new Libro("123456789", "Libro", "Autor", "2000");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, DateTime.Now.AddDays(10), unEjemplar);
            unUsuario.Prestamos.Add(unPrestamo);

            //  throw new Exception(unPrestamo.EstadoPrestamo.ToString());
            //Act
            bool resultado = unUsuario.ValidarBaja();

            //Assert
            Assert.IsFalse(resultado, "El resultado de la la validacion deferia ser False");
        }
    
        /// <summary>
        /// Resumen:Prueba unitaria que valida el metodo ValidarBaja siguiendo un camino fallido donde el usuario tiene un prestamo activo y uno devuelto
        /// </summary>
        [TestMethod]
        public void ValidarBaja_UnhappyPath2_UsuarioConUnPrestamoActivoYUnoDevuelto()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("Juan", "Gomez", new DateTime(2000, 2, 2), "juan@gomez.con", "343812345678", "juangomez");
            Libro unLibro = new Libro("123456789", "Libro", "Autor", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro);
            Prestamo prestamo1 = new Prestamo(unUsuario, DateTime.Now.AddDays(10), ejemplar1);
            Ejemplar ejemplar2 = new Ejemplar(unLibro);
            Prestamo prestamo2 = new Prestamo(unUsuario, DateTime.Now.AddDays(10), ejemplar2);
            unUsuario.Prestamos.Add(prestamo1);
            unUsuario.Prestamos.Add(prestamo2);
            //  throw new Exception(unPrestamo.EstadoPrestamo.ToString());
            //Act
            bool resultado = unUsuario.ValidarBaja();

            //Assert
            Assert.IsFalse(resultado, "El resultado de la la validacion deferia ser False");
        }
    }
}