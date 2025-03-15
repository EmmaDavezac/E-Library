using Dominio;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL.EntityFramework
{
    ///<summary>
    ///Resumen: Esta clase nos permite definir un repositorio de libros en MS SQL Server con el ORM Entity Framework.
    ///</summary>
    public class RepositorioLibros : Repositorio<Libro, AdministradorDePrestamosDbContext>, IRepositorioLibros
    {   /// <summary>
        /// Resumen: Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">Contexto de la base de datos</param>   
        public RepositorioLibros(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
        /// <summary>
        /// Resumen: Este metodo obtiene todos los ISBN de los libros.
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllISBN()
        {
            return this.iDbContext.Set<Libro>().Select(x => x.ISBN).ToList();
        }
        /// <summary>
        /// Resumen: Este metodo obtiene todos los titulos de los libros.
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllTitulo()
        {
            return this.iDbContext.Set<Libro>().Select(x => x.Titulo).ToList();
        }
    }
}
