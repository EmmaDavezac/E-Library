using Dominio;

namespace DAL.EntityFramework
{   ///<summary>
    ///Resumen: Esta clase nos permite definir un repositorio de ejemplares en MS SQL Server con el ORM Entity Framework.
    ///</summary>
    public class RepositorioEjemplares : Repositorio<Ejemplar, AdministradorDePrestamosDbContext>, IRepositorioEjemplares
    {   /// <summary>
        /// Resumen: Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">Contexto de la base de datos</param>   
        public RepositorioEjemplares(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
    }
}
