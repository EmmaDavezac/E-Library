using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
    {///<summary>
     ///Resumen: Esta clase tiene como objetivo representar en el modelo un ejemplar de un libro registrado, almacenando sus atributos y comportamiento.
     ///</summary>
    public class Ejemplar

    {   ///<summary>
        ///Resumen: Clave que nos permite diferenciar entre si los ejemplares.
        ///</summary>
        public int Id { get; set; }
        public int idLibro { get; set; }

        ///<summary>
        ///Resumen: Propiedad que nos permite saber si el ejemplar se encuentra disponible para prestamo.
        ///</summary>
        public bool Disponible { get; set; }

        /// <summary>
        /// Resumen: Propiedad que nos permite saber el estado del ejemplar (bueno o malo), solo se puede prestar si esta en buen estado
        /// </summary>
        public EstadoEjemplar Estado { get; set; }

        /// <summary>
        /// Resumen: Lista de prestamos que se ha hecho del ejemplar
        /// </summary>
        //public virtual List<Prestamo> Prestamos { get; set; }

        /// <summary>
        /// Resumen: Propiedad que nos permite saber si el ejemplar se encuentra dado de baja
        /// </summary>
        public bool Baja { get; set; }
        /// <summary>
        /// Resumen: Constructor de la clase
        /// </summary>
        public Ejemplar()
        {
        }
        /// <summary>
        /// Resumen: Constructor de la clase que toma como parametro el libro al que pertenece el ejemplar
        /// </summary>
        /// <param name="unLibro">Libro al que pertenece el ejemplar</param>
        public Ejemplar(Libro unLibro)//Constructor de la clase que toma como parametro el libro al que pertenece el ejemplar
        {
            Estado = EstadoEjemplar.Bueno;//El estado original de un ejemplar es buen estado
            Disponible = true;//Originalmente un ejemplar se encuentra disponible hasta que se preste
            Baja = false;//Un ejemplar recien creado no se encuentra dado de baja
            idLibro = unLibro.Id;
        }

    }
}
