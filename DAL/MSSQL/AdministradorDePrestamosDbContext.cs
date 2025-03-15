using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Dominio;

namespace DAL.EntityFramework
{   /// <summary>
    /// Resumen: Esta clase nos permite definir el contexto de la base de datos MS SQL Server.
    /// </summary>
    public class AdministradorDePrestamosDbContext : DbContext
    {   /// <summary>
        /// Resumen: Cadena de conexion a la base de datos.
        ///</summary>
        private static string[]  cadenasDeConexionMSSQLSERVER =new string[] {
                                                                                "ConnectionSQLServerLocal",
                                                                                "ConnectionSQLServerHosting"
                                                                            };
        /// <summary>
        /// Resumen: Cadena de conexion a la base de datos.
        /// Por defecto se establece la cadena de conexion local.
        /// </summary>
        private static string cadenaDeConexion = cadenasDeConexionMSSQLSERVER[0];

        /// <summary>
        /// Resumen: Constructor de la clase.
        /// Si la base de datos no existe, se crea y se ejecuta la migracion a la ultima version.
        /// </summary>
        public AdministradorDePrestamosDbContext() :
            base(cadenaDeConexion)
        {
            if (!Database.Exists())
            {
                Database
                    .SetInitializer(new MigrateDatabaseToLatestVersion<AdministradorDePrestamosDbContext,DAL.Migrations.Configuration>());
            }
        }
        /// <summary>
        /// Resumen: Propiedad que nos permite acceder a la tabla de libros.
        /// </summary>
        public IDbSet<Libro> Libros { get; set; }

        /// <summary>
        /// Resumen: Propiedad que nos permite acceder a la tabla de Ejemplares.
        /// </summary>
        public IDbSet<Ejemplar> Ejemplares { get; set; }
        /// <summary>
        /// Resumen: Propiedad que nos permite acceder a la tabla de Prestamos.
        /// </summary>
        public IDbSet<Prestamo> Prestamos { get; set; }
        /// <summary>
        /// Resumen: Propiedad que nos permite acceder a la tabla de Usuarios.
        /// </summary>
        public IDbSet<UsuarioSimple> Usuarios { get; set; }
        /// <summary>
        /// Resumen: Propiedad que nos permite acceder a la tabla de Administradores.
        /// </summary>
        public IDbSet<UsuarioAdministrador> Administradores { get; set; }
        
        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
