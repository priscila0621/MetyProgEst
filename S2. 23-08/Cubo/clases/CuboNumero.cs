using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubo.clases
{
    internal class CuboNumero
    {
        public double Numero {  get; set; }
        public double CalcularCubo()
        {
            return Math.Pow(Numero, 3);
        }
        public CuboNumero() { }

    }
}
