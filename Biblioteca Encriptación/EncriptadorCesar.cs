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
        private int Cdesplazamiento=5;

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
            return -1; // Si el carácter no está en el abecedario, retornamos -1
        }


        /// <summary>
        /// Resumen: Este metodo nos permite encriptar una cadena.
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Cadena encriptada</returns>
        public string Encriptar(string pCadena)
        {
            int desplazamiento = Cdesplazamiento;
            StringBuilder mensajeCifrado = new StringBuilder();
            foreach (char c in pCadena)
            {
                if (char.IsLetter(c))
                {
                    char letraCifrada = (char)((c + desplazamiento - (char.IsLower(c) ? 'a' : 'A')) % 26 + (char.IsLower(c) ? 'a' : 'A'));
                    mensajeCifrado.Append(letraCifrada);
                }
                else
                {
                    mensajeCifrado.Append(c); // Si no es una letra, no se modifica
                }
            }
            return mensajeCifrado.ToString();
        }


        /// <summary>
        /// Resumen: Este metodo nos permite desencriptar una cadena.
        /// </summary>
        /// <param name="pCadena">Cadena encriptada</param>
        /// <returns>Cadena desencriptada</returns>
        public string Desencriptar(string pCadena)
        {
            int desplazamiento = -Cdesplazamiento;
            StringBuilder mensajeCifrado = new StringBuilder();
            foreach (char c in pCadena)
            {
                if (char.IsLetter(c))
                {
                    char letraCifrada = (char)((c + desplazamiento - (char.IsLower(c) ? 'a' : 'A')) % 26 + (char.IsLower(c) ? 'a' : 'A'));
                    mensajeCifrado.Append(letraCifrada);
                }
                else
                {
                    mensajeCifrado.Append(c); // Si no es una letra, no se modifica
                }
            }
            return mensajeCifrado.ToString();
        }


        /// <summary>
        /// Resumen: Este metodo nos permite comprarar una cadena encriptada con su supuesta desencriptacion, sin revelar la verdadera desencriptacion.
        /// </summary>
        /// <param name="pCadena">Supuesta desencriptacion</param>
        /// <param name="pCadenaEncriptada">Cadena encriptada</param>
        /// <returns>True si las cadenas coinciden, False en caso contrario</returns>
        public bool Validar(string pCadena, string pCadenaEncriptada)
        {
            //return true;
            Console.WriteLine("cadena:"+ pCadena);
            Console.WriteLine("cadena encriptada:" + Encriptar(pCadena));
            Console.WriteLine("cadena encriptada (pass):"+ pCadenaEncriptada);
            return (Desencriptar(pCadenaEncriptada) == pCadena);
        }
    }
    
}
