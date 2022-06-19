using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class RegistrosException : Exception
    {
        public RegistrosException(string message) : base(message)
        {
        }
        /// <summary>
        /// Excepcion personalizada con mensaje de error en Database
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public RegistrosException(string message, Exception innerException) : base("No se pudo conectar a la base de datos", innerException)
        {
        }
    }
}
