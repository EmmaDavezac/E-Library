using Dominio;
using System.Collections.Generic;

namespace DAL
{
    public interface IRepositorioPrestamos : IRepositorio<Prestamo>
    {   /// <summary>
        /// Resumen: Este metodo obtiene todos los prestamos retrasados.
        ///</summary>
        ///<returns>Todos los prestamos retrasados.</returns>
        List<Prestamo> GetAllRetrasados();
        /// <summary>
        /// Resumen: Este metodo obtiene todos los prestamos proximos a vencerse.
        /// </summary>
        /// <returns> Todos los prestamos proximos a vencerse.</returns>
        List<Prestamo> GetAllProximosAVencerse();
    }
}
