using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    public enum ETipo { Jacuzzi, Sauna, Masaje };
    public class Servicio : IPRecio
    {
        private int id;
        private int duracion;
        private double costo;
        private DateTime fecha;
        private ETipo tipo;
        private bool estaPagado;

        public Servicio() { }
        public Servicio(int duracion, double costo, DateTime fecha, ETipo tipo, bool estaPagado)
        {
            this.Duracion = duracion;
            this.Costo = costo;
            this.fecha = fecha;
            this.Tipo = tipo;
            this.EstaPagado = estaPagado;
            this.Id = this.GetHashCode()+10000000;
        }

        public Servicio(int id, int duracion, double costo, DateTime fecha, ETipo tipo, bool estaPagado)
        {
            this.Id = id;
            this.Duracion = duracion;
            this.Costo = costo;
            this.Fecha = fecha;
            this.Tipo = tipo;
            this.EstaPagado = estaPagado;
        }

        public int Id { get { return this.id; } set { this.id = value; } }
        public int Duracion { get { return this.duracion; } set { this.duracion = value; } }
        public bool EstaPagado { get { return this.estaPagado; } set { this.estaPagado = value; } }
        public double Costo { get { return this.costo; } set { this.costo = value; } }
        public DateTime Fecha { get { return this.fecha; } set { this.fecha = value; } }
        public ETipo Tipo { get { return this.tipo; } set { this.tipo = value; } }

        public double PrecioFinal
        {
            get
            {
                double duracionHora = Math.Ceiling((double)this.Duracion / 60);
                return AplicarDescuentos(this.Costo * duracionHora);
            }
        }
        /// <summary>
        /// Verificará si es Miercoles para implementar el respectivo descuento en el servicio
        /// </summary>
        /// <param name="precio"></param>
        /// <returns></returns>
        public double AplicarDescuentos(double precio)
        {
            if (this.Fecha.DayOfWeek == DayOfWeek.Wednesday)
            {
                switch (this.Tipo)
                {
                    case ETipo.Jacuzzi:
                        precio *= 0.75;
                        break;
                    case ETipo.Sauna:
                        precio *= 0.85;
                        break;
                    default:
                        precio *= 0.9;
                        break;
                }
            }
            return precio;
        }
        /// <summary>
        /// Validara si son iguales 2 servicios por duracion, fecha y tipo
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>true si son iguales todos los parametros || false</returns>
        public static bool operator ==(Servicio s1, Servicio s2)
        {
            return s1.Duracion == s2.Duracion && s1.Fecha == s2.Fecha && s1.Tipo == s2.Tipo;
        }
        public static bool operator !=(Servicio s1, Servicio s2)
        {
            return !(s1 == s2);
        }
        /// <summary>
        /// Devuelve un string con el Id del Servicio
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Id.ToString();
        }
        /// <summary>
        /// Valida si el Id recibido es igual al Id del Servicio
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true si son iguales || false</returns>
        public override bool Equals(object obj)
        {
            return this.Id == (int)obj;
        }
        /// <summary>
        /// Devolverá un string con toda la informacion del pago pendiente para generar el correo
        /// </summary>
        /// <returns></returns>
        public string MostrarInfoCorreo()
        {
            return $"El dia {this.Fecha.ToString("dd/MMM")} participo de nuestro {this.Tipo.ToString()} por un valor de ${Math.Round(this.PrecioFinal, 2)}.";
        }
        /// <summary>
        /// Devolvera un string con toda la informacion del pago pendiente
        /// </summary>
        /// <returns></returns>
        public string MostrarPagoPendiente()
        {
            return $"{this.Id} - {this.Fecha.ToString("dd/MMM")} {this.Tipo.ToString()}: ${Math.Round(this.PrecioFinal, 2)}";
        }
        
    }
}
