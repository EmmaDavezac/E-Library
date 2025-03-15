namespace Bitacora
{   /// <summary>
    /// Resumen: Esta interfaz nos permite crear y manipular una bitacora del programa donde se registraran las operaciones del programa y los errores que surgan durante la ejecucion del mismo
    /// </summary>

    public interface IBitacora
    {   /// <summary>   
        /// Resumen:Este metodo añade entrada a la bitacora
        ///  </summary>
        /// <param name="sLog">cadena que se va a añadir a la bitacora</param>
        void RegistrarLog(string sLog);
    }
}
