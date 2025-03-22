using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Nucleo.DTOs
{
    public class  Mapeador
    {   ///<summary>
        ///Resumen: Este metodo nos permite mapear un usuario simple a un usuario simple DTO.
        ///</summary>
        /// <param name="usuarioSimple">Usuario simple a mapear</param>
        /// <returns>Usuario simple DTO</returns>
        public UsuarioSimpleDTO Mapear(UsuarioSimple usuarioSimple)
        {   
            UsuarioSimpleDTO usuarioSimpleDTO = new UsuarioSimpleDTO(usuarioSimple.Nombre, usuarioSimple.Apellido, usuarioSimple.FechaNacimiento, usuarioSimple.Mail, usuarioSimple.Telefono, usuarioSimple.nombreUsuario, usuarioSimple.Scoring);
            return usuarioSimpleDTO;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite mapear un usuario administrador a un usuario administrador DTO.
        /// </summary>
        /// <param name="usuarioAdministrador"></param>
        /// <returns></returns>
        public UsuarioAdministradorDTO Mapear(UsuarioAdministrador usuarioAdministrador)
        {
            UsuarioAdministradorDTO usuarioAdministradorDTO = new UsuarioAdministradorDTO(usuarioAdministrador.Nombre, usuarioAdministrador.Apellido, usuarioAdministrador.FechaNacimiento, usuarioAdministrador.Mail, usuarioAdministrador.Telefono, usuarioAdministrador.nombreUsuario);
            return usuarioAdministradorDTO;
        }

        public LibroDTO Mapear(Libro libro)
        {
            LibroDTO libroDTO = new LibroDTO(libro.Id,libro.ISBN,libro.Titulo,libro.Autor,libro.AñoPublicacion);
            return libroDTO;
        }

        public EjemplarDTO Mapear(Ejemplar ejemplar)
        {   string estado;
            if (ejemplar.Estado==EstadoEjemplar.Bueno)
                estado= "Bueno";
            else 
                estado= "Malo";
            EjemplarDTO ejemplarDTO = new EjemplarDTO(ejemplar.Id, ejemplar.idLibro, estado,ejemplar.Disponible,ejemplar.Baja);
            return ejemplarDTO;
        }

        public PrestamoDTO Mapear(Prestamo prestamo)
        {   string estadoPrestamo="";
            switch (prestamo.EstadoPrestamo)
            {   
                case EstadoPrestamo.Normal:
                    estadoPrestamo = "Normal";
                    break;
                case EstadoPrestamo.ProximoAVencer:
                    estadoPrestamo = "Proximo a vencer";
                    break;
                case EstadoPrestamo.Retrasado:estadoPrestamo = "Retrasado";
                    break;
                  
            }
            string estadoDevolucion="";
            switch (prestamo.EstadoDevolucion)
            {
                case EstadoEjemplar.Bueno:
                    estadoDevolucion = "Bueno";
                    break;
                case EstadoEjemplar.Malo:
                    estadoDevolucion = "Malo";
                    break;
            }
            PrestamoDTO prestamoDTO = new PrestamoDTO(prestamo.nombreUsuario,prestamo.idEjemplar,prestamo.FechaPrestamo,prestamo.FechaLimite,prestamo.FechaDevolucion,estadoPrestamo,estadoDevolucion);
            return prestamoDTO;

        }
    }

}
