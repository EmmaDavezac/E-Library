﻿using Bitacora;
using BibliotecaMapeado;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace ServiciosAPILibros
{   ///<summary>
    ///Resumen: Esta clase nos permite realizar una busqueda en la API de OpenLibrary y obtener una lista de libros que coincidan con el termino de busqueda.
    ///</summary>
    public class APIOpenLibrary : IServicioAPILibros

    {   ///<summary>
        ///Resumen: Este metodo transforma la cadena que queremos buscar en el formato solicitado por la api para hacer una consulta(palabra+palabra+...+palabra)
        ///</summary>
        private string TratarCadenaBusqueda(string cadena)
        {
            string[] palabrasSeparadas = cadena.Split(new char[] { ' ' });//Toma la cadena de entradas,la separa en subcadenas tomando como separador los espacios y las almacena en el array palabrasSeparadas
            string c = string.Empty;//Creamos una nueva cadena llamada se y le asignamos la cadena vacia
            foreach (string palabra in palabrasSeparadas) //recorremos todas las palabras del array
            {
                if (c.Length > 0)
                    c = c + "+" + palabra;//Si la cadena c no esta vacia concatenamos c con el caracter '+' y luego con la palabra
                else c += palabra;//si la cadena c esta vacia, la concatenamos con la palabra
            }
            return c.ToUpper();//Convertimos la cadena c a mayusculas y la devolvemos como resultado
        }
        /// <summary>
        /// Resumen: Este metodo nos permite obtener una lista de libros que coincidan con el termino de busqueda.
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public List<LibroDTO> ListarPorCoincidencia(string cadena)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Establecimiento del protocolo ssl de transporte
            List<LibroDTO> lista = new List<LibroDTO>();//Creamos una lista de libro
            string terminoDeBusqueda = TratarCadenaBusqueda(cadena);//Convertimos la cadena al formato necesario para realizar una busqueda solicitado por la API
            var mUrl = "http://openlibrary.org/search.json?q=" + terminoDeBusqueda;
            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);            // Se crea el request http
            IBitacora oLog = new BitacoraImplementacionPropia();// Instancia del objeto que maneja los logs.
            string msg;//Mensaje a guardar en el log.
            try
            {
                // Se ejecuta la consulta
                WebResponse mResponse = mRequest.GetResponse();
                // Se obtiene los datos de respuesta
                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());
                    // Se iteran cada uno de los resultados.
                    int id =0;
                    string titulo;
                    string autor;
                    string añoPublicacion;
                    string isbn;
                    bool baja = false;
                    foreach (var bResponseItem in mResponseJSON.docs)//Recorremos cada item de la respuesta que nos dio la api
                    {
                        //Convertimos el objeto que obtenemos como respuesta por parte de la api y lo convertimos en una lista de libros
                        if (bResponseItem.title != null)//si el item posee el atributo title leemos el atributo, lo convertimos en una cadena y lo asignamoa a la variable titulo
                        {
                            titulo = HttpUtility.HtmlDecode(bResponseItem.title.ToString());
                        }
                        else { titulo = "desconocido"; }//si no posee el atributo le asignamos a la variable titulo "desconocido"
                        if (bResponseItem.author_name != null)
                        {
                            autor = HttpUtility.HtmlDecode(bResponseItem.author_name.ToString());
                        }
                        else { autor = "desconocido"; }

                        if (bResponseItem.first_publish_year != null)
                        {
                            añoPublicacion = HttpUtility.HtmlDecode(bResponseItem.first_publish_year.ToString());
                        }
                        else { añoPublicacion = "desconocido"; }

                        if (bResponseItem.isbn != null)
                        {
                            isbn = HttpUtility.HtmlDecode(bResponseItem.isbn.ToString());
                        }
                        else { isbn = "desconocido"; }
                        lista.Add(new LibroDTO(id,isbn, titulo, autor, añoPublicacion,baja));//creamos una instancia de la clase Libro y lo añadimos a la lista de libros
                    }
                }
                msg = "Listado por coincidencia con la api OpenLibrary a funcionado correctemente.";
                oLog.RegistrarLog(msg);//Registramos la operacion en la bitacora
            }
            catch (WebException ex)//Manejamos la excepcion
            {
                WebResponse mErrorResponse = ex.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    String mErrorText = mReader.ReadToEnd();
                    System.Console.WriteLine("Error: {0}", mErrorText);
                }
                msg = "Error al intentar conectarse con la api OpenLibrary. Se intento traer un listado por coincidencia. (termino de busqueda: " + terminoDeBusqueda + " cadena: " + cadena + ")" + ex.Message + ex.StackTrace + ex.Response;
                oLog.RegistrarLog(msg);
                throw new Exception(msg);
            }
            return lista;
        }

    }
}
