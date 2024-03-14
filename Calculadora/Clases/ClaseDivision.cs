using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    internal class ClaseDivision
    {
        public double Division(double primero, double segundo)
        {
            if (segundo == 0)
            {
                // Manejar el caso de división por cero
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return primero / segundo;
        }
    }
}
