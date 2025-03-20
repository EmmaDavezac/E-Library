using System;

namespace Nucleo.DTOs
{
    public class LibroDTO
    {
        ///<summary>
        ///Resumen: Clave primaria que nos permite diferenciar los librosDTO entre si.
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
        /// Resumen: Propiedad que nos permite saber si el libro esta dado de baja.
        /// </summary>
        public bool Baja { get; set; }

        /// <summary>
        /// Resumen: Constructor de la clase sin argumentos
        /// </summary>
        public LibroDTO()
        {
        }

        /// <summary>
        /// Resumen: Constructor de la clase con argumentos
        /// </summary>
        /// <param name="unISBN">ISBN del libro</param>
        /// <param name="titulo">Titulo del libro</param>
        /// <param name="autor">Autor del libro</param>
        /// <param name="añoPublicacion">Año de publicacion del libro</param>
        public LibroDTO(int ID,string unISBN, string titulo, string autor, string añoPublicacion)
        {
            Id=ID;
            ISBN = unISBN;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Baja = false;
        }

   
 

    }
}
