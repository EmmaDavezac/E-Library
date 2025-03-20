using System;
using System.Data.Entity.Migrations;
using BibliotecaEncriptacion;


namespace DAL.Migrations
{   ///<summary>
    ///Resumen: Esta clase nos permite definir la configuracion de las migraciones de la base de datos.
    ///</summary>
    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EntityFramework.AdministradorDePrestamosDbContext>
    {   /// <summary>
        /// Resumen: Constructor de la clase.
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        /// <summary>
        /// Resumen: Este metodo nos permite sembrar la base de datos.
        /// Añade un administrador por defecto.
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(DAL.EntityFramework.AdministradorDePrestamosDbContext context)
        {
            /// <summary>º
            /// criptador para proteger la contraseña del administrador.
            /// </summary>
            IEncriptador encriptador = new EncriptadorCesar();

            context.Administradores.AddOrUpdate(x => x.nombreUsuario, new Dominio.UsuarioAdministrador("admin", "admin", new DateTime(1900, 1, 1), "admin@gmail.com",encriptador.Encriptar("admin"), "34421234", "admin"));
        }
    }
   
}
