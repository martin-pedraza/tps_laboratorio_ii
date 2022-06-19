using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    public delegate void NotificarServicioAgregadoHandler(Cliente c);
    public class Cliente
    {
        public event NotificarServicioAgregadoHandler OnServicioAgregado;
        private int dni;
        private string nombre;
        private string apellido;
        private string telefono;
        private List<Servicio> sevicios;

        private Cliente()
        {
            this.sevicios = new List<Servicio>();
        }

        public Cliente(int dni, string nombre, string apellido, string telefono) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        public int Dni { get { return this.dni; } set { this.dni = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }
        public string Telefono { get { return this.telefono; } set { this.telefono = value; } }
        public List<Servicio> Sevicios { get { return this.sevicios; } set { this.sevicios = value; } }

        /// <summary>
        /// Valida si 2 clientes son iguales segun el DNI
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.Dni == c2.Dni;
        }
        /// <summary>
        /// Valida si 2 clientes son diferentes segun el DNI
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool operator +(Cliente c, Servicio s)
        {
            foreach (var item in c.sevicios)
            {
                if (item == s)
                {
                    return false;
                }
            }
            c.sevicios.Add(s);
            return true;
        }
        /// <summary>
        /// Devolverá el DNI del Cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Dni.ToString();
        }
        /// <summary>
        /// Devolvera todos los datos del Cliente en un string
        /// </summary>
        /// <returns></returns>
        public string MostrarCliente()
        {
            return $"{this.Dni} - {this.nombre} {this.Apellido}, {this.Telefono}";
        }
        /// <summary>
        /// Si el evento fue asignado,se creará un servicio random del dia sin pagar y se le agregara al cliente.
        /// </summary>
        /// <param name="cancellation"></param>
        /// <param name="token"></param>
        public void AgregarAutomatico(CancellationTokenSource cancellation, CancellationToken token)
        {
            Random r = new Random();
            Task.Run(() =>
            {
                do
                {
                    Servicio s = new Servicio(r.Next(0, 180), r.Next(0, 3000), DateTime.Today, (ETipo)(r.Next(1, 4) - 1), false);
                    if (this + s)
                    {
                        Thread.Sleep(1000);

                        if (this.OnServicioAgregado is not null)
                        {
                            this.OnServicioAgregado.Invoke(this);
                        }
                    }
                } while (!cancellation.IsCancellationRequested);
                this.OnServicioAgregado = null;
            }, token);
        }
    }
}
