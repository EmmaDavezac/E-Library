using System.Collections.Generic;

namespace Dominio
{   ///<summary>
    ///Resumen: Esta clase nos permite definir un libro.
    ///</summary>
    public class Libro 
    {   ///<summary>
        ///Resumen: Clave primaria que nos permite diferenciar los libros entre si.
        ///</summary>
        public int Id { get; set; }
        /// <summary>
        /// Resumen: Codigo ISBN del libro (en el caso de que lo tenga).
        /// </summary>
        public string ISBN { get; set; }
        /// <summary>
        /// Resumen: Titulo del libro.
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// Resumen: Nombre del autor del libro.
        /// </summary>
        public string Autor { get; set; }
        /// <summary>
        /// Resumen: Año de publicacion del libro.
        /// </summary>
        public string AñoPublicacion { get; set; }
        /// <summary>
        /// Resumen: Lista de ejemplares del libro.
        /// </summary>
        public virtual List<Ejemplar> Ejemplares { get; set; }
        /// <summary>
        /// Resumen: Propiedad que nos permite saber si el libro esta dado de baja.
        /// </summary>
        public bool Baja { get; set; }
        /// <summary>
        /// Resumen: Constructor de la clase sin argumentos
        /// </summary>
        public Libro()
        {
        }
        /// <summary>
        /// Resumen: Constructor de la clase con argumentos
        /// </summary>
        /// <param name="unISBN">ISBN del libro</param>
        /// <param name="titulo">Titulo del libro</param>
        /// <param name="autor">Autor del libro</param>
        /// <param name="añoPublicacion">Año de publicacion del libro</param>
        public Libro(string unISBN, string titulo, string autor, string añoPublicacion)
        {
            ISBN = unISBN;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Baja = false;
            Ejemplares = new List<Ejemplar>();
        }
        /// <summary>
        /// Resumen: Este metodo nos permite obtener la lista de ejemplares del libro disponibles para prestarse.
        /// </summary>
        /// <returns>Ejemplares del libro disponibles para prestamo</returns>
        public List<Ejemplar> EjemplaresDisponibles()
        {
            List<Ejemplar> ejemplaresDisponibles = new List<Ejemplar>();//Se crea una lista de ejemplares vacia y se guarda en la variable ejemplaresDisponibles
            foreach (var item in this.Ejemplares)//Recorremos la lista de ejemplares del libro
            {
                if (item.Disponible && item.Estado == EstadoEjemplar.Bueno && item.Baja == false)//Verifica si el ejemplar cumple las condiciones de no encontrarse prestado y estar en buen estado
                {
                    ejemplaresDisponibles.Add(item);//Verifica si el ejemplar cumple las condiciones de no encontrarse prestado y estar en buen estado
                }
            }
            return ejemplaresDisponibles;//Verifica si el ejemplar cumple las condiciones de no encontrarse prestado y estar en buen estado
        }
        /// <summary>
        /// Resumen: Este metodo nos permite obtener la lista de ejemplares del libro en buen estado.
        /// </summary>
        /// <returns>Ejemplares del libro en buen estado</returns>
        public List<Ejemplar> EjemplaresEnBuenEstado()
        {
            List<Ejemplar> ejemplaresEnBuenEstado = new List<Ejemplar>();
            foreach (var item in this.Ejemplares)
            {
                if (item.Estado == EstadoEjemplar.Bueno)
                {
                    ejemplaresEnBuenEstado.Add(item);
                }
            }
            return ejemplaresEnBuenEstado;
        }
        /// <summary>
        /// Resumen: Este metodo nos permite aobtener la lista total de ejemplares del libro.
        /// </summary>
        /// <returns>Lista total de ejemplares del libro</returns>
        public List<Ejemplar> EjemplaresTotales()
        {
            List<Ejemplar> ejemplaresTotales = new List<Ejemplar>();
            foreach (var item in this.Ejemplares)
            {
                if (item.Estado == EstadoEjemplar.Bueno && item.Baja == false)
                {
                    ejemplaresTotales.Add(item);
                }
            }
            return ejemplaresTotales;
        }
        /// <summary>
        /// Resumen: Este metodo nos permite eliminar ejemplares del libro.
        public void EliminarEjemplares(int pCantidad)
        {
            int e = 0;
            foreach (var item in Ejemplares)
            {
                if (e >= pCantidad)
                {
                    break;
                }
                if (item.Estado != EstadoEjemplar.Malo)
                {
                    item.Estado = EstadoEjemplar.Malo;
                    item.Disponible = false;
                    item.Baja = true;
                    e = e + 1;
                }
            }
        }
        /// <summary>
        /// Resumen: Este metodo nos permite dar de baja un libro.
        /// </summary>
        public void DarDeBaja()
        {
            if (Baja == false)
            {
                Baja = true;
                foreach (var item in Ejemplares)
                {
                    if (item.Estado != EstadoEjemplar.Malo)
                    {
                        item.Disponible = false;
                        item.Baja = true;
                    }              
                }
            }
        }
        /// <summary>
        /// Resumen: Este metodo nos permite dar de alta un libro dado de baja previamente.
        /// </summary>
        public void DarDeAlta()
        {
            if (Baja == true)
            {
                Baja = false;
                foreach (var item in Ejemplares)
                {
                    if (item.Estado != EstadoEjemplar.Malo)
                    {
                        item.Disponible = true;
                        item.Baja = false;
                    }
                }
            }
        }
    }
}
