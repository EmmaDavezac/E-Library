using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace BibliotecaEncriptacion
{
    public class EncriptadorAES : IEncriptador
    {
        /// <summary>
        /// Resumen: Este metodo nos permite encriptar una cadena.
        /// </summary>
        /// <param name="pCadena">Cadena a encriptar</param>
        /// <returns>Cadena encriptada</returns>
        public string Encriptar(string pCadena)
        {
            string EncryptionKey = "MAKV2SPBNI99212"; //Esta cadena será usada para generar una contraseña en base a esta.
            byte[] clearBytes = Encoding.Unicode.GetBytes(pCadena); //Obtiene el valor en bytes de cada caracter de la cadena pCadena.
            byte[] tmpBytes = { 12, 78, 2, 5, 80, 56, 90, 14 }; //Colección de bytes que serán usados para generar una contraeña en base a estos. 
            using (Aes encryptor = Aes.Create())
            {
                //La clase AES es un estandar de encriptación 
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, tmpBytes); //Rfc2898DeriveBytes implementa metodos para crear contraseñas que se usarán en encriptación, tomando como parametros de entrada una contraseña y una colección de bytes.  
                encryptor.Key = pdb.GetBytes(32); //Key es la clave que se usa para encriptar o desencrptar la cadena. 
                encryptor.IV = pdb.GetBytes(16); //IV es el vector de inicialización que se usara en conjunto a la Key.
                using (MemoryStream ms = new MemoryStream()) //MemoryStream implementa metodos de escritura y lectura de Streams.
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)) //CryptoStream permite crear cadenas cifradas.
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    pCadena = Convert.ToBase64String(ms.ToArray());
                }
            }
            return pCadena;
        }

        /// <summary>
        /// Resumen: Este metodo nos permite desencriptar una cadena.
        /// </summary>
        /// <param name="pCadena">Cadena encriptada</param>
        /// <returns>Cadena desencriptada</returns>
        public string Desencriptar(string pCadena)
        {
            //Este metodo sigue el mismo procedimiento que Encriptar pero de forma contraría.
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(pCadena);
            byte[] tmpBytes = { 12, 78, 2, 5, 80, 56, 90, 14 };
            string cadena;
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, tmpBytes);
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                encryptor.Mode = CipherMode.CBC;
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cadena = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cadena;
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
