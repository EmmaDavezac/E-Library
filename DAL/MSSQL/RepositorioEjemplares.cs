using Dominio;
using System.Collections.Generic;
using System.Linq;

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
        /// <summary>
        /// Resumen: Este metodo obtiene todos los ejemplares disponibles de un libro
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Ejemplar> GetEjemplaresDisponiblesLibro(int idLibro)
        { return this.GetAll().Where(x => x.Disponible && x.Estado == EstadoEjemplar.Bueno && !x.Baja && x.idLibro == idLibro); }

        /// <summary>
        /// Resumen: Este metodo obtiene todos los ejemplares de un libro
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Ejemplar> GetEjemplaresLibro(int idLibro)
        { return this.GetAll().Where(x => x.Disponible && x.Estado == EstadoEjemplar.Bueno && !x.Baja && x.idLibro == idLibro); }
    }
}
