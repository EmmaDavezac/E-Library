using System;
using System.IO;
using log4net;


namespace Bitacora
{

    /// <summary>
    /// Resumen: Esta clase nos permite crear y manipular una bitacora del programa donde se registraran las operaciones del programa y los errores que surgan durante la ejecucion del mismo utilizando la libreria log4net.
    /// </summary>
    public class ImplementacionBitacoraConLog4Net : IBitacora//
    {  
        /// <summary>
        /// Contructor de la clase
        /// </summary>
        public ImplementacionBitacoraConLog4Net()
        {
        }

        /// <summary>
        /// Resumen: Este metodo añade una entrada a la bitacora
        /// </summary>
        /// <param name="entradaLog"></param>
        public void RegistrarLog(string entradaLog)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            log.Info(entradaLog);

        }

     
    }
}
