using System;
using System.IO;

namespace Bitacora
{   /// <summary>
    /// Resumen: Esta clase nos permite crear y manipular una bitacora del programa donde se registraran las operaciones del programa y los errores que surgan durante la ejecucion del mismo
    /// </summary>
    public class ImplementacionBitacora:IBitacora
    {  
        /// <summary>
        /// Establece la direccion relativa de los archivos de la bitacora
        /// </summary>
        private string Path = "Logs";

        /// <summary>
        /// Contructor de la clase
        /// </summary>
        public ImplementacionBitacora()//contructor de la clase
        {

        }

        /// <summary>
        /// Resumen: Este metodo añade entrada a la bitacora
        /// </summary>
        /// <param name="sLog">Cadena que se va a añadir a la bitacora</param>
        public void RegistrarLog(string sLog)
        {
            CrearDirectorio();//crea un directorio en el caso de que no exista
            string nombre = ObtenerNombreArchivo();//obtiene el nombre del archivo
            string cadena =""+ DateTime.Now + " - " + sLog + Environment.NewLine;//el texto que se va a escribir en la entrada
            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);//establece una transmision para escribir el archivo
            sw.Write(cadena);//escribe la entrada en el archivo
            sw.Close();//cierra el archivo
        }

        /// <summary>
        /// Resumen: Este metodo devuelve el nombre para un nuevo archivo de la bitacora
        /// </summary>
        /// <returns></returns>
        private string ObtenerNombreArchivo()//metodo que devuelve el nombre para un nuevo archivo de la bitacora
        {
            string nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";//el formato de nombre del archivo es log_año_mes_dia.txt
            return nombre;//devuelve el nombre del archivo
        }

        /// <summary>
        /// Resumen: Este metodo crea el directorio de la bitacora en el caso de que no exista
        /// </summary>
        private void CrearDirectorio()//metodo que crea el directorio de la bitacora en el caso de que no exista
        {
                if (!Directory.Exists(Path)) //verifica si existe la ruta de directorio especificada
                {
                    Directory.CreateDirectory(Path);//si el directorio no existe lo crea
                }
        }
    }
}
