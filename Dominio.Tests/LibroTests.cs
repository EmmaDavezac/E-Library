using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Dominio.Tests
{
    [TestClass]
    public class LibroTests
    {
        [TestCategory("HappyPath")]
        [TestMethod]
        public void DardDeBaja_HappyPath1_DarDeBajaLibroSinEjemplares()
        {
            // Arrange
            Libro libro = new Libro() { Baja = false };

            // Act
            libro.DarDeBaja();

            //Assert
            Assert.IsTrue(libro.Baja, "El libro fue dado de baja");
        }

        [TestMethod]
        public void DarDeBaja_HappyPath2_DarDeBajaLibroConEjemplarEnBuenEstado()
        {
            //Arrange
            Libro libro = new Libro();
            Ejemplar ejemplar = new Ejemplar(libro) { Estado = EstadoEjemplar.Bueno, Disponible = true };

            //Act
            libro.DarDeBaja();

            //Assert
            Assert.IsTrue(libro.Baja, "El libro fue dado de baja");
            Assert.IsFalse(ejemplar.Disponible, "El ejemplar ya no esta disponible");
            Assert.IsTrue(ejemplar.Baja, "El ejemplar fue dado de baja");
        }

        [TestMethod]
        public void DarDeBaja_HappyPath3_DarDeBajaLibroConEjemplaresEnDiferentesEstados()
        {
            Ejemplar ejemplar1 = new Ejemplar() { Estado = EstadoEjemplar.Bueno, Disponible = true, Baja = false };
            Ejemplar ejemplar2 = new Ejemplar() { Estado = EstadoEjemplar.Malo, Disponible = true, Baja = false };
            Libro libro = new Libro() { Baja = false, Ejemplares = new List<Ejemplar> { ejemplar1, ejemplar2 } };

            // Act
            libro.DarDeBaja();

            // Assert
            Assert.IsTrue(libro.Baja, "El libro debería estar dado de baja.");
            Assert.IsFalse(ejemplar1.Disponible, "El ejemplar1 debería estar no disponible.");
            Assert.IsTrue(ejemplar1.Baja, "El ejemplar1 debería estar dado de baja.");
            Assert.IsTrue(ejemplar2.Disponible, "El ejemplar2 debería seguir disponible.");
            Assert.IsFalse(ejemplar2.Baja, "El ejemplar2 no debería estar dado de baja.");
        }

        [TestCategory("UnHappyPath")]
        [TestMethod]
        public void DardDeBaja_UnHappyPath1_DarDeBajaLibroYaDadoDeBaja()
        {
            // Arrange
            Libro libro = new Libro() { Baja = true };

            // Act
            libro.DarDeBaja();

            //Assert
            Assert.IsTrue(libro.Baja, "El libro ya estaba dado de baja");
        }
    }
}