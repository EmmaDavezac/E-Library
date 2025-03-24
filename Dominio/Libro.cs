using System.Collections.Generic;

namespace Dominio
{   ///<summary>
    ///Resumen: Esta clase nos permite definir un libro.
    ///</summary>
    public class Libro 
    {   
        ///<summary>
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
