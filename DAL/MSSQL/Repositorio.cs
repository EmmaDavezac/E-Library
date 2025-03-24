using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL.EntityFramework
{   ///<summary>
    ///Resumen: Esta clase nos permite definir un repositorio generico en MS SQL Server con el ORM Entity Framework.
    ///</summary>
    public abstract class Repositorio<TEntity, TDbContext> : IRepositorio<TEntity> where TEntity : class
                                                                                    where TDbContext : DbContext
    {
        /// <summary>
        /// Resumen: Contexto de la base de datos.
        /// </summary>
        protected readonly TDbContext iDbContext;
        /// <summary>
        /// Resumen: Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">Contexto de la base de datos</param>
        public Repositorio(TDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new ArgumentNullException(nameof(pDbContext));
            }

            this.iDbContext = pDbContext;
        }
        /// <summary>
        /// Resumen: Este metodo añade una entidad al repositorio
        /// </summary>
        /// <param name="pEntity">Entidad del repositorio</param>
        public void Add(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }
            this.iDbContext.Set<TEntity>().Add(pEntity);
        }
        /// <summary>
        /// Resumen:Este metodo obtiene una entidad al repositorio
        /// </summary>
        /// <param name="pId">Identificador de la entidad</param>
        /// <returns>Entidad del repositorio</returns>
        public TEntity Get(int pId)
        {
            return this.iDbContext.Set<TEntity>().Find(pId);
        }
        /// <summary>
        /// Resumen: Este metodo obtiene una entidad del repositorio
        /// </summary>
        /// <param name="pValor">Valor de la entidad</param>
        /// <returns>Entidad del repositorio</returns>
        public TEntity Get(string pValor)
        {
            return this.iDbContext.Set<TEntity>().Find(pValor);
        }
        /// <summary>
        /// Resumen: Este metodo obtiene todas las entidades del repositorio
        /// </summary>
        /// <returns>Todas la entidades del respositorio</returns>
        public IEnumerable<TEntity> GetAll()
        {
            return this.iDbContext.Set<TEntity>();
        }
        /// <summary>
        /// Resumen: Este metodo elimina una entidad del repositorio.
        /// </summary>
        /// <param name="pEntity">Entidad</param>
        public void Remove(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }

            this.iDbContext.Set<TEntity>().Remove(pEntity);
        }
    }
}
