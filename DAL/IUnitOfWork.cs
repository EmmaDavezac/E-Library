using System;

namespace DAL
{
    /// <summary>
    /// Resumen: Esta interfaz nos permite definir los metodos que se deben implementar en un UnitOfWork.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {   /// <summary>
        /// Resumen: Este metodo guarda los cambios realizados en la base de datos.
        void Complete();
        /// <summary>
        /// Resumen: Repositorio de libros.
        /// </summary>
        IRepositorioLibros RepositorioLibros { get; }
        /// <summary>
        /// Resumen: Repositorio de ejemplares.
        IRepositorioEjemplares RepositorioEjemplares { get; }
        /// <summary>
        /// Resumen: Repositorio de prestamos.
        /// </summary>
        IRepositorioPrestamos RepositorioPrestamos { get; }
        /// <summary>
        /// Resumen: Repositorio de usuarios.
        /// </summary>
        IRepositorioUsuarios RepositorioUsuarios { get; }
        /// <summary>
        /// Resumen: Repositorio de administradores.
        /// </summary>
        IRepositorioAdministradores RepositorioAdministradores { get; }
    }
}
