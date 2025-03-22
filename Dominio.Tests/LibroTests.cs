using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Dominio.Tests
{
    [TestClass]
    public class LibroTests
    {   /// <summary>
        /// Resumen: se crea un libro con dos ejemplares, se verifica que los ejemplares disponibles sean los mismos que los originales.
        /// </summary>
        [TestMethod] //
        public void EjemplaresDisponibles_CaminoExitoso_Test1()
        {
            //Arange
            Libro unLibro = new Libro("123", "a", "b", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro);
            Ejemplar ejemplar2 = new Ejemplar(unLibro);
            List<Ejemplar> original = new List<Ejemplar>
            {
                ejemplar1,
                ejemplar2
            };
            unLibro.Ejemplares.Add(ejemplar1);
            unLibro.Ejemplares.Add(ejemplar2);

            //Act
            List<Ejemplar> resultado = new List<Ejemplar>();
            resultado = unLibro.EjemplaresDisponibles();

            //Assert
            CollectionAssert.AreEqual(original, resultado);
        }

        /// <summary>
        /// Resumen: se crea un libro con dos ejemplares (uno en mal estado), se verifica que el ejemplar disponible sea solo el ejemplar en buen estado.
        /// </summary>
        [TestMethod]
        public void EjemplaresDisponibles_CaminoExitoso_Test2()
        {
            //Arange
            Libro unLibro = new Libro("123", "a", "b", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro);
            ejemplar1.Estado = EstadoEjemplar.Malo;
            Ejemplar ejemplar2 = new Ejemplar(unLibro);
            List<Ejemplar> original = new List<Ejemplar>() { ejemplar2 };
            unLibro.Ejemplares.Add(ejemplar1);
            unLibro.Ejemplares.Add(ejemplar2);

            //Act
            List<Ejemplar> resultado = new List<Ejemplar>();
            resultado = unLibro.EjemplaresDisponibles();

            //Assert
            CollectionAssert.AreEqual(original, resultado);
        }
        /// <summary>
        /// Resumen: se crea un libro con dos ejemplares (uno en mal estado), se verifica que el ejemplar disponible sea solo el ejemplar en buen estado.
        /// </summary>
        [TestMethod]
        public void EjemplaresEnBuenEstado_CaminoExitoso_Test1()
        {
            //Arange
            Libro unLibro = new Libro("123", "a", "b", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro);
            ejemplar1.Estado = EstadoEjemplar.Malo;
            Ejemplar ejemplar2 = new Ejemplar(unLibro);
            List<Ejemplar> original = new List<Ejemplar>() { ejemplar2 };
            unLibro.Ejemplares = new List<Ejemplar>() { ejemplar1, ejemplar2 };

            //Act
            List<Ejemplar> resultado = unLibro.EjemplaresEnBuenEstado();

            //Assert
            CollectionAssert.AreEqual(original, resultado);
        }
        /// <summary>
        /// Resumen: se crea un libro con dos ejemplares (uno dado de baja), se verifica que los ejemplares totales disponible sea solo el ejemplar en buen estado y dado de alta.
        /// </summary>
        [TestMethod]
        public void EjemplaresTotales_CaminoExitoso_Test1()
        {
            //Arange
            Libro unLibro = new Libro("123", "a", "b", "2000");
            Ejemplar ejemplar1 = new Ejemplar(unLibro);
            Ejemplar ejemplar2 = new Ejemplar(unLibro);
            ejemplar2.Baja = true;
            List<Ejemplar> original = new List<Ejemplar>() { ejemplar1 };
            unLibro.Ejemplares.Add(ejemplar1);
            unLibro.Ejemplares.Add(ejemplar2);

            //Act
            List<Ejemplar> resultado = unLibro.EjemplaresTotales();

            //Assert
            CollectionAssert.AreEqual(original, resultado);
        }
        /// <summary>
        /// Resumen: se crea un libro con dos ejemplares (uno en mal estado), se elimina un ejemplar y se verifica que los ejemplares disponibles sea la misma cantidad que los originales.
        /// </summary>
        [TestMethod]
        public void EliminarEjemplares_CaminoExitoso_Test1()
        {
            //Arange
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar ejemplar1 = new Ejemplar(unLibro);
            ejemplar1.Estado = EstadoEjemplar.Malo;
            Ejemplar ejemplar2 = new Ejemplar(unLibro);
            List<Ejemplar> original = new List<Ejemplar>() { };
            unLibro.Ejemplares = new List<Ejemplar>() { ejemplar1, ejemplar2 };

            //Act
            unLibro.EliminarEjemplar(1);

            //Assert
            Assert.AreEqual(original.Count, unLibro.EjemplaresDisponibles().Count);
        }
    }
}