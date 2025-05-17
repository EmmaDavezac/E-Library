using Dominio;

namespace Nucleo.DTOs
{
    public class Mapeador
    {   ///<summary>
        ///Resumen: Este metodo nos permite mapear un usuario simple a un usuario simple DTO.
        ///</summary>
        /// <param name="usuarioSimple">Usuario simple a mapear</param>
        /// <returns>Usuario simple DTO</returns>
        public UsuarioSimpleDTO Mapear(UsuarioSimple usuarioSimple)
        {
            UsuarioSimpleDTO usuarioSimpleDTO = new UsuarioSimpleDTO(usuarioSimple.Nombre, usuarioSimple.Apellido, usuarioSimple.FechaNacimiento, usuarioSimple.Mail, usuarioSimple.Telefono, usuarioSimple.nombreUsuario, usuarioSimple.Scoring,usuarioSimple.Baja);
            return usuarioSimpleDTO;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite mapear un usuario administrador a un usuario administrador DTO.
        /// </summary>
        /// <param name="usuarioAdministrador"></param>
        /// <returns></returns>
        public UsuarioAdministradorDTO Mapear(UsuarioAdministrador usuarioAdministrador)
        {
            UsuarioAdministradorDTO usuarioAdministradorDTO = new UsuarioAdministradorDTO(usuarioAdministrador.Nombre, usuarioAdministrador.Apellido, usuarioAdministrador.FechaNacimiento, usuarioAdministrador.Mail, usuarioAdministrador.Telefono, usuarioAdministrador.nombreUsuario,usuarioAdministrador.Baja);
            return usuarioAdministradorDTO;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite mapear un libro a un libro DTO.
        /// </summary>
        /// <param name="libro"></param>
        /// <returns></returns>
        public LibroDTO Mapear(Libro libro)
        {
            LibroDTO libroDTO = new LibroDTO(libro.Id, libro.ISBN, libro.Titulo, libro.Autor, libro.AñoPublicacion,libro.Baja);
            return libroDTO;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite mapear un ejemplar a un ejemplar DTO.
        /// </summary>
        /// <param name="ejemplar"></param>
        /// <returns></returns>
        public EjemplarDTO Mapear(Ejemplar ejemplar)
        {
            string estado;
            if (ejemplar.Estado == EstadoEjemplar.Bueno)
                estado = "Bueno";
            else
                estado = "Malo";
            EjemplarDTO ejemplarDTO = new EjemplarDTO(ejemplar.Id, ejemplar.idLibro, estado, ejemplar.Disponible, ejemplar.Baja);
            return ejemplarDTO;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite mapear un prestamo a un prestamo DTO.
        /// </summary>
        /// <param name="prestamo"></param>
        /// <returns></returns>
        public PrestamoDTO Mapear(Prestamo prestamo)
        {
            string estadoPrestamo = "";
            switch (prestamo.EstadoPrestamo)
            {
                case EstadoPrestamo.Normal:
                    estadoPrestamo = "Normal";
                    break;
                case EstadoPrestamo.ProximoAVencer:
                    estadoPrestamo = "Proximo a vencer";
                    break;
                case EstadoPrestamo.Retrasado:
                    estadoPrestamo = "Retrasado";
                    break;
                case EstadoPrestamo.Devuelto:
                    estadoPrestamo = "Devuelto";
                    break;

            }
            string estadoDevolucion = "";
            switch (prestamo.EstadoDevolucion)
            {
                case EstadoEjemplar.Bueno:
                    estadoDevolucion = "Bueno";
                    break;
                case EstadoEjemplar.Malo:
                    estadoDevolucion = "Malo";
                    break;
            }
            PrestamoDTO prestamoDTO = new PrestamoDTO(prestamo.Id, prestamo.nombreUsuario, prestamo.idEjemplar, prestamo.FechaPrestamo, prestamo.FechaLimite, estadoPrestamo, estadoDevolucion);
            return prestamoDTO;

        }
    }

}
