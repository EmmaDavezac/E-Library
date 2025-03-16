using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEncriptacion
{
    public class EncriptadorCesar: IEncriptador
    {
        /// <summary>
        /// Resumen:Cantidad de desplazamientos de un caracter en nuestro abecesario.
        /// </summary>
        private int desplazamiento=5;

        /// <summary>
        /// Resumen:Es nuestro abecedario de cifrado/descifrado
        /// </summary>
        private static readonly string abc = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!,.;:{}[]|";

        
        /// <summary>
        /// Resumen: Este metodo nos permite obtener la posición de un caracter en el abecedario.
        /// </summary>
        /// <param name="caracter">Caracter</param>
        /// <returns>Posicion del caracter en nuestro abecedario</returns>
        private static int GetPosABC(char caracter)
        {
            for (int i = 0; i < abc.Length; i++)
            {
                if (caracter == abc[i])
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite encriptar una cadena.
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Cadena encriptada</returns>
        public string Encriptar(string pCadena)
        {
            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
                //recorre caracter a caracter el mensaje a cifrar
                for (int i = 0; i < pCadena.Length; i++)
                {
                    int posCaracter = GetPosABC(pCadena[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter + desplazamiento;
                        while (pos >= abc.Length)
                        {
                            pos = pos - abc.Length;
                        }
                        //concatena al mensaje cifrado
                        cifrado += abc[pos];
                    }
                    else//si no existe el caracter no se cifra
                    {
                        cifrado += pCadena[i];
                    }
                }

            }
            return cifrado;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite desencriptar una cadena.
        /// </summary>
        /// <param name="pCadena">Cadena encriptada</param>
        /// <returns>Cadena desencriptada</returns>
        public string Desencriptar(string pCadena)
        {
            String cifrado = "";
            if (desplazamiento > 0 && desplazamiento < abc.Length)
            {
                for (int i = 0; i < pCadena.Length; i++)
                {
                    int posCaracter = GetPosABC(pCadena[i]);
                    if (posCaracter != -1) //el caracter existe en la variable abc
                    {
                        int pos = posCaracter - desplazamiento;
                        while (pos < 0)
                        {
                            pos = pos + abc.Length;
                        }
                        cifrado += abc[pos];
                    }
                    else
                    {
                        cifrado += pCadena[i];
                    }
                }

            }
            return cifrado;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite comprarar una cadena encriptada con su supuesta desencriptacion, sin revelar la verdadera desencriptacion.
        /// </summary>
        /// <param name="pCadena">Supuesta desencriptacion</param>
        /// <param name="pCadenaEncriptada">Cadena encriptada</param>
        /// <returns>True si las cadenas coinciden, False en caso contrario</returns>
        public bool Validar(string pCadena, string pCadenaEncriptada)
        {
            return (Desencriptar(pCadenaEncriptada) == pCadena); 
        }
    }
    
}
