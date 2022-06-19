using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Centro<T> where T : class
    {
        private List<T> lista;
        public Centro()
        {
            this.lista = new List<T>();
        }
        public List<T> Lista { get { return this.lista; } set { this.lista = value; } }
        /// <summary>
        /// Verificara si el objeto esta en la lista del Centro
        /// </summary>
        /// <param name="c">Centro<T></param>
        /// <param name="p">parametro a verificar</param>
        /// <returns>devuelve true si esta en la lista || false</returns>
        public static bool operator ==(Centro<T> c, T p)
        {
            foreach (T t in c.lista)
            {
                if (p == t)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Verificara si el objeto no esta en la lista del Centro
        /// </summary>
        /// <param name="c">Centro<T></param>
        /// <param name="p">parametro a verificar</param>
        /// <returns>devuelve true si no esta en la lista || false</returns>
        public static bool operator !=(Centro<T> c, T p)
        {
            return !(c == p);
        }
        /// <summary>
        /// Si el objeto no esta en la lista del Centro<T> entonces lo agrega</T>
        /// </summary>
        /// <param name="c">Centro<T></param>
        /// <param name="p">parametro a verificar</param>
        /// <returns>devuelve true si se agrega o false si no se hizo</returns>
        public static bool operator +(Centro<T> c, T p)
        {
            if (c != p)
            {
                c.lista.Add(p);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Se verifica que el indice del objeto esta en la lista del Centro.
        /// </summary>
        /// <param name="indice">indice del objeto a verificar</param>
        /// <returns>si se encontro el indice devuelve el Index del objeto en la lista pero si no esta en la lista devuelve MinValue</returns>
        public int BuscarIndice(string indice)
        {
            this.OrdenarPorIndice();
            foreach (var item in this.Lista)
            {
                if (item.GetType() == typeof(Cliente) || item.GetType() == typeof(Servicio))
                {
                    if (item.ToString() == indice)
                    {
                        return this.lista.IndexOf(item);
                    }
                }
            }
            return int.MinValue;
        }
        /// <summary>
        /// Ordenara la lista del Centro por el indice de los objetos que contenga
        /// </summary>
        public void OrdenarPorIndice()
        {
            Comparison<T> comparador = ComparaPorIndice;
            this.Lista.Sort(comparador);
        }
        /// <summary>
        /// Funcion que validará los indices de los objetos
        /// </summary>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <returns></returns>
        private int ComparaPorIndice(T t1, T t2)
        {
            if (t1.GetType() == typeof(Cliente) || t2.GetType() == typeof(Servicio))
            {
                return int.Parse(t2.ToString()) - int.Parse(t1.ToString());
            }
            return 0;
        }
        /// <summary>
        /// Duplicará un Centro agregando todos sus objetos
        /// </summary>
        /// <param name="c1">Centro de donde se tomaran los objetos</param>
        /// <returns>devuelve el Centro con todos los objetos agregados</returns>
        public Centro<T> duplicarCentro(Centro<T> c1)
        {
            this.Lista.Clear();
            foreach (T item in c1.Lista)
            {
                this.Lista.Add(item);
            }
            return this;
        }
    }
}
