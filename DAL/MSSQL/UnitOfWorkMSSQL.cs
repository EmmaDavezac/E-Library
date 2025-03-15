using System;

namespace DAL.EntityFramework
{   ///<summary>
    ///Resumen: Esta clase nos permite definir un UnitOfWork en MS SQL Server con el ORM Entity Framework.
    ///</summary>
    public class UnitOfWorkMSSQL : IUnitOfWork
    {   ///<summary>
        ///Resumen: Contexto de la base de datos del administrador de prestamos.
        ///</summary>
        private readonly AdministradorDePrestamosDbContext iDbContext;
        /// <summary>
        /// Resumen: Indica si el objeto ya fue liberado.
        /// </summary>
        private bool iDisposedValue = false;
        /// <summary>
        /// Resumen: Constructor de la clase.
        /// </summary>
        /// <param name="pDbContext">Contexto de la base de datos</param>
        public UnitOfWorkMSSQL(AdministradorDePrestamosDbContext pDbContext)
        {
            if (pDbContext == null)
            {
                throw new NotImplementedException();
            }

            this.iDbContext = pDbContext;
            this.RepositorioUsuarios = new RepositorioUsuarios(pDbContext);
            this.RepositorioLibros = new RepositorioLibros(pDbContext);
            this.RepositorioPrestamos = new RepositorioPrestamos(pDbContext);
            this.RepositorioEjemplares = new RepositorioEjemplares(pDbContext);
            this.RepositorioAdministradores = new RepositorioAdministradores(pDbContext);
        }
        /// <summary>
        /// Resumen: Repositorio de usuarios.
        /// </summary>
        public IRepositorioUsuarios RepositorioUsuarios { get; private set; }
        /// <summary>
        /// Resumen: Repositorio de libros.
        /// </summary>
        public IRepositorioLibros RepositorioLibros { get; private set; }
        /// <summary>
        /// Resumen: Repositorio de prestamos.
        /// </summary>
        public IRepositorioPrestamos RepositorioPrestamos { get; private set; }
        /// <summary>
        /// Resumen: Repositorio de ejemplares.
        /// </summary>
        public IRepositorioEjemplares RepositorioEjemplares { get; private set; }
        /// <summary>
        /// Resumen: Repositorio de administradores.
        /// </summary>
        public IRepositorioAdministradores RepositorioAdministradores { get; private set; }
        /// <summary>
        /// Resumen: Este metodo guarda los cambios realizados en la base de datos.
        /// </summary>
        public void Complete()
        {
            this.iDbContext.SaveChanges();
        }
        /// <summary>
        /// Resumen: Este metodo libera los recursos utilizados por el objeto.
        /// </summary>
        /// <param name="pDisposing"></param>
        protected virtual void Dispose(bool pDisposing)
        {
            if (!this.iDisposedValue)
            {
                if (pDisposing)
                {
                    this.iDbContext.Dispose();
                }

                this.iDisposedValue = true;
            }
        }
        /// <summary>
        /// Resumen: Este metodo libera los recursos utilizados por el objeto.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }
    }
}
