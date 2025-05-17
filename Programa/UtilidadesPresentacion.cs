using Bitacora;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Programa
{
    /// <summary>
    /// Resumen: Esta clase nos brinda una serie de utilidades para los distintos formularios de la aplicacion
    /// </summary>
    public class UtilidadesPresentacion
    {
        private IBitacora bitacora = new Bitacora.BitacoraImplementacionPropia();

        /// <summary>
        /// Resumen: Constructor de la clase
        /// </summary>
        public UtilidadesPresentacion()
        {
        }


        /// <summary>  Resumen: Este metodo transforma el campo isbns de un libro ofrecido por la api de libros en una lista de isbn
        /// </summary>
        /// <param name="pLista">string que contiene los isbn de un libro</param>
        public List<string> TransformarListaJSONALista(string pLista)
        {
            try
            {
                string palabra = "";
                int contador = 0;
                List<string> resultadoIntermedio = new List<string>();
                List<string> resultado = new List<string>();
                for (int i = 0; i < pLista.Length; i++)
                {
                    if (pLista.Substring(i, 1) == "[" || pLista.Substring(i, 1) == "," || pLista.Substring(i, 1) == "]")
                    {
                    }
                    if (pLista.Substring(i, 1) == '"'.ToString())
                    {
                        contador = 1;
                    }
                    if (pLista.Substring(i, 1) == '"'.ToString() && contador == 1)
                    {
                        contador = 0;
                        resultadoIntermedio.Add(palabra);
                        palabra = "";
                    }
                    else
                    {
                        palabra = palabra + pLista.Substring(i, 1);
                    }
                }
                for (int i = 1; i < resultadoIntermedio.Count; i += 2)
                {
                    resultado.Add(resultadoIntermedio[i]);
                }
                HashSet<string> hashWithoutDuplicates = new HashSet<string>(resultado);
                List<string> listWithoutDuplicates = hashWithoutDuplicates.ToList();
                return listWithoutDuplicates;
            }
            catch (Exception ex)
            {
                string msg = "Error en TransformarListaJSONALista: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);
                throw new Exception(msg);
            }
        }

        /// <summary>
        /// Resumen: devuelve el autor de un libro, a partir de la lista de autores de un libro ofrecido por la api de libros
        /// </summary>
        /// <param name="pLista"> lista de autores de un libro  </param>
        /// <returns></returns>
        public string SacarAutorDeLaLista(string pLista)

        {
            try
            {

                if (pLista == "desconocido" || pLista == "Unknown")
                {
                    return "Desconocido";
                }
                else
                {
                    return TransformarListaJSONALista(pLista).First();
                }
            }
            catch (Exception ex)
            {

                string msg = "Error en SacarAutorDeLaLista: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);
                throw new Exception(msg);
            }
        }



        /// <summary>
        /// Resumen: Este metodo indica si una cadena tiene el formato de email valido
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool EsUnEmailValido(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception ex)
            {
                string msg = "Error en SacarAutorDeLaLista: " + ex.Message + ex.StackTrace;
                bitacora.RegistrarLog(msg);
                return false;
                throw new Exception(msg);

            }
        }

        /// <summary>
        /// Resumen: Este metodo convierte la primera letra de una cadena en mayuscula
        /// </summary>
        /// <param name="cadena">Cadena que querermos transformar</param>
        /// <returns></returns>
        public string MayusculaPrimeraLetra(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
            { return string.Empty; }
            else
            {
                char[] letters = cadena.ToCharArray();
                letters[0] = char.ToUpper(letters[0]);
                return new string(letters);
            }
        }
    }
}
