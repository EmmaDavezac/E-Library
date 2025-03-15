using Dominio;

namespace NotificacionAUsuario
{   ///<summary>
    ///Resumen: Esta interfaz nos permite notificar a un usuario.
    ///</summary>
    public interface INotificadorUsuario
    {
        /// <summary>
        /// Resumen: Este metodo notifica a un usuario que posee un prestamo proximo a vencer.
        /// </summary>
        /// <param name="usuario">Usuario a notificar</param>
        /// <param name="titulo">Titulo del libro</param>
        /// <param name="fechaLimite">Fecha limite de devolucion</param>
        /// <returns>Cadena de confirmacion de exito o de error</returns>
        string NotificarProximoAVencer(UsuarioSimple usuario,string titulo,string fechaLimite);
        /// <summary>
        /// Resumen: Este metodo notifica a un usuario que posee un prestamo retrasado.
        /// </summary>
        /// <param name="usuario">Usuario a notificar</param>
        /// <param name="titulo">Titulo del libro</param>
        /// <param name="fechaLimite">Fecha limite de devolucion</param>
        /// <returns>Cadena de confirmacion de exito o de error</returns>
        string NotificarRetraso(UsuarioSimple usuario, string titulo, string fechaLimite);
    }
}
