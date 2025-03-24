using Dominio;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// Resumen: Esta interfaz nos permite definir los metodos que se deben implementar en un repositorio de ejemplares de libros.
    /// </summary>
    public interface IRepositorioEjemplares : IRepositorio<Ejemplar>
    {
        /// <summary>
        /// Resumen: Este metodo obtiene todos los ejemplares disponibles de un libro
        /// </summary>
        /// <returns></returns>
        IEnumerable<Ejemplar> GetEjemplaresDisponiblesLibro( int idLibro);

        /// <summary>
        /// Resumen: Este metodo obtiene todos los ejemplares de un libro
        /// </summary>
        /// <returns></returns>
        IEnumerable<Ejemplar> GetEjemplaresLibro(int idLibro);
    }

}

