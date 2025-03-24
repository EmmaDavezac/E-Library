namespace Nucleo.DTOs
{
    public class EjemplarDTO

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
        public string Estado { get; set; }

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
        public EjemplarDTO()
        {
        }
        /// <summary>
        /// Resumen: Constructor de la clase que toma como parametro el libro al que pertenece el ejemplar
        /// </summary>
        /// <param name="unLibro">Libro al que pertenece el ejemplar</param>
        public EjemplarDTO(int idEjemplar, int pidLibro, string estado, bool disponible, bool baja)//Constructor de la clase que toma como parametro el libro al que pertenece el ejemplar
        {
            Estado = estado;//El estado original de un ejemplar es buen estado
            Disponible = true;//Originalmente un ejemplar se encuentra disponible hasta que se preste
            Baja = false;//Un ejemplar recien creado no se encuentra dado de baja
            Id = idEjemplar;
            idLibro = pidLibro;
        }

    }
}


