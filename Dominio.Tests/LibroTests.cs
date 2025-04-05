using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Dominio.Tests
{
    [TestClass]
    public class LibroTests
    {   
        [TestCategory("HappyPath")]
        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo DarDeBaja siguiendo un camino feliz de un libro sin ejemplares
        /// </summary>
        [TestMethod]
        public void DardDeBaja_HappyPath1_DarDeBajaLibroSinEjemplares()
        {
            // Arrange
            Libro libro = new Libro() { Baja = false, Ejemplares= new List<Ejemplar>() };

            // Act
            libro.DarDeBaja();

            //Assert
            Assert.IsTrue(libro.Baja, "El libro fue dado de baja");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo DarDeBaja siguiendo un camino feliz de un libro con ejemplares en buen estado
        /// </summary>
        [TestMethod]
        public void DarDeBaja_HappyPath2_DarDeBajaLibroConEjemplarEnBuenEstado()
        {
            //Arrange
            Libro libro = new Libro() { Baja = false, Ejemplares = new List<Ejemplar>() };
            Ejemplar ejemplar = new Ejemplar(libro) { Estado = EstadoEjemplar.Bueno, Disponible = true };
            libro.Ejemplares.Add(ejemplar);
            //Act
            libro.DarDeBaja();

            //Assert
            Assert.IsTrue(libro.Baja, "El libro fue dado de baja");
            Assert.IsFalse(ejemplar.Disponible, "El ejemplar ya no esta disponible");

        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo DarDeBaja siguiendo un camino feliz de un libro con ejemplares en diferentes estados
        /// </summary>
        [TestMethod]
        public void DarDeBaja_HappyPath3_DarDeBajaLibroConEjemplaresEnDiferentesEstados()
        {
            Ejemplar ejemplar1 = new Ejemplar() { Estado = EstadoEjemplar.Bueno, Disponible = true, Baja = false };
            Ejemplar ejemplar2 = new Ejemplar() { Estado = EstadoEjemplar.Malo, Disponible = true, Baja = false };
            Libro libro = new Libro() { Baja = false, Ejemplares = new List<Ejemplar> { ejemplar1, ejemplar2 } };
            libro.Ejemplares.Add(ejemplar1);
            libro.Ejemplares.Add(ejemplar2);
            // Act
            libro.DarDeBaja();

            // Assert
            Assert.IsTrue(libro.Baja, "El libro debería estar dado de baja.");
            Assert.IsFalse(ejemplar1.Disponible, "El ejemplar1 debería estar no disponible.");
            Assert.IsFalse(ejemplar2.Disponible, "El ejemplar2 debería estar no disponible.");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo DarDeBaja siguiendo un camino fallido de un libro ya dado de baja
        /// </summary>
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

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo DarDeBaja siguiendo un camino fallido de un libro con la lista de ejemplares mal inicializada
        /// </summary>
        [TestMethod]
        public void DardDeBaja_UnHappyPath2_DarDeBajaLibroListaEjemplaresMalInicializada()
        {
            // Arrange
            Libro libro = new Libro() { Baja = false };
            bool fallo = false;
            //Act 
            try
            {
                libro.DarDeBaja();
            }
            catch (Exception)
            {
                fallo = true;
            }
            //Assert
            Assert.IsTrue(fallo, "No se puede dar de baja porque tiene la lista de ejemplares mal inicializada");
        }

        [TestMethod]
        public void DardDeBaja_UnHappyPath3_DarDeBajaLibroMalInicializado()
        {
            // Arrange
            Libro libro = new Libro();
            bool fallo = false;
            //Act 
            try
            {
                libro.DarDeBaja();
            }
            catch (Exception)
            {
                fallo = true;
            }
            //Assert
            Assert.IsTrue(fallo, "No se puede dar de baja porque esta mal inicializado");
        }


        [TestCategory("HappyPath")]
        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo DarDeAlta siguiendo un camino feliz de un libro sin ejemplares
        /// </summary>
        [TestMethod]
        public void DarDeAlta_HappyPath1_DarDeAltaLibroSinEjemplares()
        {
            // Arrange
            Libro libro = new Libro()
            {
                Baja = true,
                Ejemplares = new List<Ejemplar>()
            };

            // Act
            libro.DarDeAlta();

            //Assert
            Assert.IsFalse(libro.Baja, "El libro fue dado de alta");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo DarDeAlta siguiendo un camino feliz de un libro con ejemplares en buen estado
        /// </summary>
        [TestMethod]
        public void DarDeAlta_HappyPath2_DarDeBajaLibroConEjemplarEnBuenEstado()
        {
            //Arrange
            Libro libro = new Libro()
            {
                Baja = true,
                Ejemplares = new List<Ejemplar>()
            };
            Ejemplar ejemplar = new Ejemplar(libro) { Estado = EstadoEjemplar.Bueno, Disponible = false };
            libro.Ejemplares.Add(ejemplar);

            //Act
            libro.DarDeAlta();

            //Assert
            Assert.IsFalse(libro.Baja, "El libro fue dado de alta");
            Assert.IsTrue(ejemplar.Disponible, "El ejemplar ya esta disponible");
           
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo DarDeAlta siguiendo un camino feliz de un libro con ejemplares en diferentes estados
        /// </summary>
        [TestMethod]
        public void DarDeAlta_HappyPath3_DarDeBajaLibroConEjemplaresEnDiferentesEstados()
        {
            Ejemplar ejemplar1 = new Ejemplar() { Estado = EstadoEjemplar.Bueno, Disponible = true, Baja = false };
            Ejemplar ejemplar2 = new Ejemplar() { Estado = EstadoEjemplar.Malo, Disponible = true, Baja = false };
            Libro libro = new Libro() { Baja = true, Ejemplares = new List<Ejemplar> { ejemplar1, ejemplar2 } };
            libro.Ejemplares.Add(ejemplar1);
            libro.Ejemplares.Add(ejemplar2);
            // Act
            libro.DarDeAlta();

            // Assert
            Assert.IsFalse(libro.Baja, "El libro no debería estar dado de baja.");
            Assert.IsTrue(ejemplar1.Disponible, "El ejemplar1 debería estar  disponible.");
            Assert.IsTrue(ejemplar2.Disponible, "El ejemplar2 debería estar  disponible.");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo DarDeAlta siguiendo un camino fallido de un libro ya dado de alta
        /// </summary>
        [TestCategory("UnHappyPath")]
        [TestMethod]
        public void DarDeAlta_UnHappyPath1_DarDeAltaLibroYaDadoDeAlta()
        {
            // Arrange
            Libro libro = new Libro() { Baja = false };

            // Act
            libro.DarDeAlta();

            //Assert
            Assert.IsFalse(libro.Baja, "El libro ya estaba dado de alta");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo DarDeAlta siguiendo un camino fallido de un libro con la lista de ejemplares mal inicializada
        /// </summary>
        [TestMethod]
        public void DarDeAlta_UnHappyPath2_DarDeAltaLibroListaEjemplaresMalInicializada()
        {
            // Arrange
            Libro libro = new Libro() { Baja = true };
            bool fallo = false;
            //Act 
            try
            {
                libro.DarDeAlta();
            }
            catch (Exception)
            {
                fallo = true;
            }
            //Assert
            Assert.IsTrue(fallo, "No se puede dar de alta porque tiene la lista de ejemplares mal inicializada");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo DarDeAlta siguiendo un camino fallido de un libro mal inicializado
        /// </summary>
        [TestMethod]
        public void DarDeAlta_UnHappyPath3_DarDeAltaLibroMalInicializado()
        {
            // Arrange
            Libro libro = new Libro() { Baja=true,Ejemplares=null};
            bool fallo = false;
            //Act 
            try
            {
                libro.DarDeAlta();
            }
            catch (Exception)
            {
                fallo = true;
            }
            //Assert
            Assert.IsTrue(fallo, "No se puede dar de alta porque tiene la lista de ejemplares no puede ser null");
        }
    }
}