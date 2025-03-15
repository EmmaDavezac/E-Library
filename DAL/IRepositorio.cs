using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// Resumen: Esta interfaz nos permite definir los metodos que se deben implementar en un repositorio generico.
    /// </summary>
    /// <typeparam name="TEntity">Entidad</typeparam>
    public interface IRepositorio<TEntity> where TEntity : class
    {   /// <summary>
        /// Resumen: Este metodo agrega una entidad al repositorio.
        /// </summary>
        void Add(TEntity pEntity);
        /// <summary>
        /// Resumen: Este metodo elimina una entidad del repositorio.
        /// </summary>
        /// <param name="pEntity">Entidad</param>
        void Remove(TEntity pEntity);
        /// <summary>
        /// Resumen: Este metodo obtiene una entidad del repositorio
        /// </summary>
        /// <param name="pId">Identificador de la entidad</param>
        /// <returns>Entidad.</returns>
        TEntity Get(int pId);
        /// <summary>
        /// Resumen: Este metodo obtiene una entidad del repositorio
        /// </summary>
        /// <param name="pValor"> Valor de la entidad</param>
        /// <returns>Entidad</returns>
        TEntity Get(string pValor);
        /// <summary>
        /// Resumen: Este metodo obtiene todas las entidades del repositorio
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();
    }
}
