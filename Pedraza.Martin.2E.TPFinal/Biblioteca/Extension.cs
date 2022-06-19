using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Extension
    {
        /// <summary>
        /// Tomará un string y en caso de ser un conjunto de palabras devolverá solo la primer palabra
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string PrimerizarPalabra(this string texto)
        {
            string[] cadena = texto.Split(' ');
            return cadena[0];
        }
        /// <summary>
        /// Verificará que un string contenga numeros
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>true si tiene algun numero sino false</returns>
        public static bool NoNumber(this string texto)
        {
            foreach (char c in texto)
            {
                if (int.TryParse(c.ToString(), out int valor))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// VErificara la cantidad de caracteres que posee el string
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="length">cantidad de caracteres a verificar</param>
        /// <returns>true si la longitud del string es menor a la cantidad recibida || false</returns>
        public static bool LengthWord(this string texto, int length)
        {
            return texto.Length < length;
        }
    }
}
