using System;
using System.Data.Entity.Migrations;

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
            context.Administradores.AddOrUpdate(x => x.nombreUsuario, new Dominio.UsuarioAdministrador()
            {
                nombreUsuario = "admin",
                Pass = "admin",
                Nombre = "admin",
                Apellido = "admin",
                Mail = "admin@gmail.com",
                Telefono = "34421234",
                FechaNacimiento = new DateTime(1900, 1, 1),
            }); 
        }
    }
}
