/*using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dominio.Tests
{   /// <summary>
    /// Pruebas unitarias de la clase UsuarioSimple
    /// </summary>
    [TestClass]
    public class UsuarioSimpleTests
    {   /// <summary>
        /// Resumen:Prueba unitaria que valida el metodo ValidarBaja siguiendo un camino exitoso
        /// </summary>
        [TestMethod]
        public void ValidarBaja_CaminoExitoso_Test1()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");

            //Act
            bool resultado = unUsuario.ValidarBaja();

            //Assert
            Assert.AreEqual(true, resultado);
        }

        /// <summary>
        /// Resumen:Prueba unitaria que valida el metodo ValidarBaja siguiendo un camino fallido
        /// </summary>
        [TestMethod]
        public void ValidarBaja_CaminoFallido_Test1()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, unEjemplar, unLibro);

            //Act
            bool resultado = unUsuario.ValidarBaja();

            //Assert
            Assert.AreEqual(true, resultado);
        }
    }
}*/