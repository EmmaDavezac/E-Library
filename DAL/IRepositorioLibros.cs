using Dominio;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// Resumen: Esta interfaz nos permite definir los metodos que se deben implementar en un repositorio de libros.
    /// </summary>
    public interface IRepositorioLibros : IRepositorio<Libro>
    {
        /// <summary>
        /// Resumen: Este metodo obtiene todos los ISBN de los libros.
        /// </summary>
        /// <returns>Todos los ISBN de libros.</returns>
        List<string> GetAllISBN();
        /// <summary>
        /// Resumen: Este metodo obtiene todos los titulos de los libros.
        /// </summary>
        /// <returns>Todos los titulos de libros.</returns>
        List<string> GetAllTitulo();
    }
}
