using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IPRecio
    {
        double PrecioFinal { get; }
        double AplicarDescuentos(double precio);
    }
}
