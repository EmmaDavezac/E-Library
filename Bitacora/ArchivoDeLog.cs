﻿using System;
using System.IO;

namespace Bitacora
{
    public class ArchivoDeLog//esta clase nos permite crear y manipular una bitacora del programa donde se registraran las operaciones del programa y los errores que surgan durante la ejecucion del mismo
    {
        private string Path = "Logs";//establece la direccion relativa del los archivos de la bitacora


        public ArchivoDeLog()//contructor de la clase
        {

        }

        public void Add(string sLog)//añadir entrada a la bitacora
        {
            CreateDirectory();//crea un directorio en el caso de que no exista
            string nombre = GetNameFile();//obtiene el nombre del archivo
            string cadena =""+ DateTime.Now + " - " + sLog + Environment.NewLine;//el texto que se va a escribir en la entrada

            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);//establece una transmision para escribir el archivo
            sw.Write(cadena);//escribe la entrada en el archivo
            sw.Close();//cierra el archivo

        }


        private string GetNameFile()//metodo que devuelve el nombre para un nuevo archivo de la bitacora
        {
           

            string nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";//el formato de nombre del archivo es log_año_mes_dia.txt

            return nombre;//devuelve el nombre del archivo
        }

        private void CreateDirectory()//metodo que crea el directorio de la bitacora en el caso de que no exista
        {
            try
            {
                if (!Directory.Exists(Path)) //si el directorio no existe lo crea
                    Directory.CreateDirectory(Path);
            }
            catch (DirectoryNotFoundException ex) //en el caso de ocurrir un error captura la excepcion
            {
                throw new Exception(ex.Message);
            }
        }

    }
}