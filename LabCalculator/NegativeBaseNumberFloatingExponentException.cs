using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalculator
{
    class NegativeBaseNumberFloatingExponentException : Exception
    {
        public double number { get; private set; }

        public NegativeBaseNumberFloatingExponentException(double n) : base()
        {
            number = n;
        }
    }
}
