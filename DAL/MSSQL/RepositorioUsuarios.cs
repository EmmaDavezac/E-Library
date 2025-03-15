using Dominio;

namespace DAL.EntityFramework
{   ///<summary>
    ///Resumen: Esta clase nos permite definir un repositorio de usuarios en MS SQL Server con el ORM Entity Framework.
    ///</summary>
    class RepositorioUsuarios : Repositorio<UsuarioSimple, AdministradorDePrestamosDbContext>, IRepositorioUsuarios
    {   /// <summary>
        /// Resumen: Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">Contexto de la base de datos</param>
        public RepositorioUsuarios(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
    }
}
