namespace BibliotecaEncriptacion
{   ///<summary>
    ///Resumen: Esta interfaz nos permite definir los metodos necesarios para encriptar y desencriptar una cadena.
    ///</summary>
    public interface IEncriptador
    {
        ///<summary>
        ///Resumen: Este metodo nos permite encriptar una cadena.
        ///</summary>
        string Encriptar(string pCadena);

        /// <summary>
        /// Resumen: Este metodo nos permite desencriptar una cadena.
        /// </summary>
        /// <param name="pCadena"></param>
        /// <returns></returns>
        string Desencriptar(string pCadena);

        /// <summary>
        /// Resumen: Este metodo nos permite validar si una cadena encriptada es igual a una cadena sin encriptar. Sin que el usuario pueda ver el metodo de encriptacion.
        /// </summary>
        /// <param name="pCadena"></param>
        /// <param name="pCadenaEncriptada"></param>
        /// <returns></returns>
        bool Validar(string pCadena, string pCadenaEncriptada);
    }
}
