using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Resources;

namespace Dominio.Tests
{
    [TestClass]
    public class PrestamoTests
    {   //Tests metodo Retrasado()
        [TestCategory("HappyPath")]

        [TestMethod]
        public void Retrasado_HappyPath1_PrestamoConFechaLimitePasada()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, DateTime.Now, unEjemplar);
            unPrestamo.FechaLimite = "2008, 2, 2";

            //Act
            bool resultado = unPrestamo.Retrasado();

            //Assert
            Assert.IsTrue(resultado, "El prestamo deberia estar retrasado");
        }

        [TestMethod]
        public void Retrasado_HappyPath1_PrestamoConFechaLimitePasadaPeroDevuelto()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, DateTime.Now, unEjemplar);
            unPrestamo.FechaLimite = "2008, 2, 2";
            unPrestamo.EstadoPrestamo = EstadoPrestamo.Devuelto;

            //Act
            bool resultado = unPrestamo.Retrasado();

            //Assert
            Assert.IsFalse(resultado, "El prestamo no deberia estar retrasado");
        }

        [TestCategory("UnHappyPath")]

        /// <summary>
        /// Resumen:Prueba unitaria que valida el metodo Retrasado siguiendo un camino feliz de un prestamo sin fecha limite
        /// </summary>
        [TestMethod]
        public void Retrasado_UnhappyPath1_PrestamoSinfechaLimite()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo() { Usuario=unUsuario,EstadoPrestamo=EstadoPrestamo.Normal};
            

            //Act
            bool resultado = unPrestamo.Retrasado();

            //Assert
            Assert.IsFalse(resultado, "El prestamo no deberia estar retrasado");
        }

        /// <summary>
        /// Resumen:Prueba unitaria que valida el metodo Retrasado siguiendo un camino feliz de un prestamo sin fecha limite
        /// </summary>
        [TestMethod]
        public void Retrasado_UnhappyPath2_PrestamoConFechaVacia()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo() { Usuario = unUsuario,FechaLimite="", EstadoPrestamo = EstadoPrestamo.Normal };
            bool fallo = false;

            //Act
            try
            {
                unPrestamo.Retrasado();
            }
            catch (Exception)
            {
                fallo = true;
            }

            //Assert
            Assert.IsTrue(fallo, "El metodo deberia fallar por tener una fecha limite no cargada");
        }

        //Tests metodo ProximoAVencerse()

        /// <summary>
        /// Resumen:Prueba unitaria que valida el metodo ProximoAVencerse siguiendo un camino feliz de un prestamo con fecha limite proxima
        /// </summary>

        [TestMethod]
        public void ProximoAVencerse_HappyPath1_PrestamoConUnDiaParaVencer()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, DateTime.Now, unEjemplar);
            unPrestamo.FechaLimite = DateTime.Now.AddDays(1).ToShortDateString();

            //Act
            bool resultado = unPrestamo.ProximoAVencerse();

            //Assert
            Assert.IsTrue(true, "El deberia prestamo deberia estar proximo a vencer");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo ProximoAVencerse siguiendo un camino feliz de un prestamo con fecha limite proxima
        /// </summary>
        [TestMethod]
        public void ProximoAVencerse_HappyPath2_PrestamoConUnTresDiasParaVencer()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, DateTime.Now, unEjemplar);
            unPrestamo.FechaLimite = DateTime.Now.AddDays(3).ToShortDateString();

            //Act
            bool resultado = unPrestamo.ProximoAVencerse();

            //Assert
            Assert.IsTrue(true, "El deberia prestamo deberia estar proximo a vencer");
        }


        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo ProximoAVencerse siguiendo un camino feliz de un prestamo con fecha limite proxima
        /// </summary>
        [TestMethod]
        public void ProximoAVencerse_UnappyPath1_PrestamoVencido()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, new DateTime(2000, 2, 2), unEjemplar);
           
            //Act
            bool resultado = unPrestamo.ProximoAVencerse();

            //Assert
            Assert.IsFalse(resultado, "El deberia no prestamo deberia estar proximo a vencer");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo ProximoAVencerse siguiendo un camino feliz de un prestamo con fecha limite proxima
        /// </summary>
        [TestMethod]
        public void ProximoAVencerse_UnhappyPath2_PrestamoSinFechaLimite()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("", "", new DateTime(2000, 2, 2), "", "", "");
            Libro unLibro = new Libro("", "", "", "");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo();

            //Act
            bool resultado = unPrestamo.ProximoAVencerse();

            //Assert
            Assert.IsFalse(resultado, "El deberia no prestamo deberia estar proximo a vencer");

        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo RegistrarDevolucion siguiendo un camino feliz de un prestamo con ejemplar devuelto en buen estado
        /// </summary>
        [TestMethod]
        public void RegistrarDevolucion_HappyPath1_RegistrarDevolcionEjemplarATiempoYEnBuenEstado()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("Juan", "Gomez", new DateTime(2000, 2, 2), "juan@gmail.com", "3438123456", "juangomez");
            Libro unLibro = new Libro("123456", "Libro", "Autor", "1999");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, DateTime.Now.AddDays(5), unEjemplar);
            EstadoEjemplar unEstado = EstadoEjemplar.Bueno;

            //Act
            unPrestamo.RegistrarDevolucion(unEstado);

            //Assert
            Assert.IsTrue(unEjemplar.Disponible && unPrestamo.EstadoPrestamo == EstadoPrestamo.Devuelto, "El ejemplar devuelto deberia estar disponible y el estado del prestamo deberia ser DEVUELTO");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo RegistrarDevolucion siguiendo un camino feliz de un prestamo con ejemplar devuelto en buen estado
        /// </summary>
        [TestMethod]
        public void RegistrarDevolucion_HappyPath2_RegistrarDevolcionRetrasadoYEnBuenEstado()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("Juan", "Gomez", new DateTime(2000, 2, 2), "juan@gmail.com", "3438123456", "juangomez");
            Libro unLibro = new Libro("123456", "Libro", "Autor", "1999");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, new DateTime(2000, 2, 2), unEjemplar);
            EstadoEjemplar unEstado = EstadoEjemplar.Bueno;

            //Act
            unPrestamo.RegistrarDevolucion(unEstado);

            //Assert
            Assert.IsTrue(unEjemplar.Disponible && unPrestamo.EstadoPrestamo == EstadoPrestamo.Devuelto, "El ejemplar devuelto deberia estar disponible y el estado del prestamo deberia ser DEVUELTO");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo RegistrarDevolucion siguiendo un camino feliz de un prestamo con ejemplar devuelto en buen estado
        /// </summary>
        [TestMethod]
        public void RegistrarDevolucion_UnhappyPath2_RegistrarDevolcionEjemplarATiempoYEnMalEstado()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("Juan", "Gomez", new DateTime(2000, 2, 2), "juan@gmail.com", "3438123456", "juangomez");
            Libro unLibro = new Libro("123456", "Libro", "Autor", "1999");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, DateTime.Now.AddDays(5), unEjemplar);
            EstadoEjemplar unEstado = EstadoEjemplar.Malo;

            //Act
            unPrestamo.RegistrarDevolucion(unEstado);

            //Assert
            Assert.IsTrue(!unEjemplar.Disponible && unEjemplar.Baja && unPrestamo.EstadoPrestamo == EstadoPrestamo.Devuelto, "El ejemplar devuelto no deberia estar disponible, deberia estar dado de baja y el estado del prestamo deberia ser DEVUELTO");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo RegistrarDevolucion siguiendo un camino feliz de un prestamo con ejemplar devuelto en buen estado
        /// </summary>
        [TestMethod]
        public void RegistrarDevolucion_UnhappyPath2_RegistrarDevolucionPrestamoSinFechaLimite()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("Juan", "Gomez", new DateTime(2000, 2, 2), "juan@gmail.com", "3438123456", "juangomez");
            Libro unLibro = new Libro("123456", "Libro", "Autor", "1999");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo() { Ejemplar=unEjemplar};
            EstadoEjemplar unEstado = EstadoEjemplar.Bueno;
            bool fallo = false;
            //Act
            try
            {
                unPrestamo.RegistrarDevolucion(unEstado);
            }
            catch (Exception )
            {
                fallo = true;
            }

            //Assert
            Assert.IsTrue(fallo, "El metodo deberia fallar porque el estado no tiene fecha limite");
        }

        //Pruebas del metodo CalcularScoring()

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo CalcularScoring siguiendo un camino feliz de un prestamo con ejemplar devuelto en buen estado
        /// </summary>
        [TestMethod]
        public void CalcularScoring_HappyPath1_DevolucionDePrestamoATiempoYEnBuenEstado()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("Juan", "Gomez", new DateTime(2000, 2, 2), "juan@gmail.com", "3438123456", "juangomez");
           
            Libro unLibro = new Libro("123456", "Libro", "Autor", "1999");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, DateTime.Now.AddDays(5), unEjemplar) { EstadoDevolucion=EstadoEjemplar.Bueno,EstadoPrestamo=EstadoPrestamo.Devuelto};
            int scoring = 0;

            //Act
            scoring=unPrestamo.CalcularScoring();
            //Assert
            Assert.AreEqual(scoring,5, "El Nuevo scoring deberia ser 5");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo CalcularScoring siguiendo un camino feliz de un prestamo con ejemplar devuelto en mal estado
        /// </summary>
        [TestMethod]
        public void CalcularScoring_HappyPath2_DevolucionDePrestamoATiempoYEnMalEstado()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple("Juan", "Gomez", new DateTime(2000, 2, 2), "juan@gmail.com", "3438123456", "juangomez") { Scoring=15};

            Libro unLibro = new Libro("123456", "Libro", "Autor", "1999");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, DateTime.Now.AddDays(5), unEjemplar) { EstadoDevolucion = EstadoEjemplar.Malo, EstadoPrestamo = EstadoPrestamo.Devuelto };
            int scoring = 0;

            //Act
            scoring = unPrestamo.CalcularScoring();
            //Assert
            Assert.AreEqual(scoring, 5, "El metodo deberia fallar porque el estado no tiene fecha limite");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo CalcularScoring siguiendo un camino fallido si el usuario no tiene scoring inicializado
        /// </summary>
        [TestMethod]
        public void CalcularScoring_UnhappyPath1_DevolucionDePrestamoUsuarioSinScoringInicializado()
        {
            //Arange 
            UsuarioSimple unUsuario = new UsuarioSimple();

            Libro unLibro = new Libro("123456", "Libro", "Autor", "1999");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
            Prestamo unPrestamo = new Prestamo(unUsuario, DateTime.Now.AddDays(5), unEjemplar) { EstadoDevolucion = EstadoEjemplar.Malo, EstadoPrestamo = EstadoPrestamo.Devuelto };
            int scoring ;

            //Act
            scoring = unPrestamo.CalcularScoring();
            //Assert
            Assert.AreEqual(scoring, 0, "El Scoring deberia dar 0");
        }

        /// <summary>
        /// Resumen: Prueba unitaria que valida el metodo CalcularScoring siguiendo un camino fallido si el prestamono tiene un usuario asociado
        /// </summary>
        [TestMethod]
        public void CalcularScoring_UnhappyPath1_DevolucionDePrestamoSinUsuarioCargado()
        {
            //Arange 

            Libro unLibro = new Libro("123456", "Libro", "Autor", "1999");
            Ejemplar unEjemplar = new Ejemplar(unLibro);
          Prestamo unPrestamo = new Prestamo() { FechaLimite=DateTime.Now.ToShortDateString(),EstadoDevolucion=EstadoEjemplar.Bueno,EstadoPrestamo=EstadoPrestamo.Devuelto};
            bool fallo = false;
            //Act
            try
            {
                unPrestamo.CalcularScoring();
            }
            catch(Exception)
            {
                fallo = true;
            }
            //Assert
            Assert.IsTrue(fallo, "El metodo deberia fallar porque no se asocio ningun usuario al prestamo ");
        }

    }
}
