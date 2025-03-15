using Dominio;

namespace DAL.EntityFramework
{   ///<summary>
    ///Resumen: Esta clase nos permite definir un repositorio de administradores en MS SQL Server con el ORM Entity Framework.
    ///</summary>
    class RepositorioAdministradores : Repositorio<UsuarioAdministrador, AdministradorDePrestamosDbContext>, IRepositorioAdministradores
    {
        /// <summary>
        /// Resumen: Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">Contexto de la base de datos</param>
        public RepositorioAdministradores(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
    }
}
