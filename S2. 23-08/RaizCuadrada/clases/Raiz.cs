using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RaizCuadrada.clases
{
    internal class Raiz
    {
        public double Numero {  get; set; }

        public double CalcularRaiz()
        {
            return Math.Sqrt(Numero);
        }
        public Raiz() { }
    }
}
