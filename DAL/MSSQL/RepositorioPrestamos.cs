using Dominio;
using System.Collections.Generic;
using System.Linq;

namespace DAL.EntityFramework
{   ///<summary>
    ///Resumen: Esta clase nos permite definir un repositorio de prestamos en MS SQL Server con el ORM Entity Framework.
    ///</summary>
    public class RepositorioPrestamos : Repositorio<Prestamo, AdministradorDePrestamosDbContext>, IRepositorioPrestamos
    {   /// <summary>
        /// Resumen: Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">Contexto de la base de datos</param>   
        public RepositorioPrestamos(AdministradorDePrestamosDbContext pDbContext) : base(pDbContext)
        {
        }
        /// <summary>
        /// Resumen: Este metodo obtiene todos los prestamos proximos a vencerse.
        /// </summary>
        /// <returns>Todos los prestamos proximos a vencerse</returns>
        public List<Prestamo> GetAllProximosAVencerse()
        {
            return this.iDbContext.Set<Prestamo>().ToList().Where(x => x.ProximoAVencerse() == true).ToList();
        }
        /// <summary>
        /// Resumen: Este metodo obtiene todos los prestamos retrasados.
        /// </summary>
        /// <returns>Todos los prestamos retrasados</returns>
        public List<Prestamo> GetAllRetrasados()
        {
            return this.iDbContext.Set<Prestamo>().ToList().Where(x => x.Retrasado() == true).ToList();
        }
    }
}
