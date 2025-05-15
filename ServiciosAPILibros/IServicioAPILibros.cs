using Dominio;
using System.Collections.Generic;

namespace ServiciosAPILibros
{   ///<summary>
    ///Resumen: Esta interfaz nos permite definir los metodos que se deben implementar al consumir una API de libros.
    ///</summary>
    public interface IServicioAPILibros
    {   ///<summary>
        ///Resumen: Metodo que nos permite obtener una lista de libros que coinciden con el termino buscado.
        ///</summary>
        List<Libro> ListarPorCoincidencia(string cadena);


    }
}
