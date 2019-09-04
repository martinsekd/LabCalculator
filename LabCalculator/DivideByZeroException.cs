using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalculator
{
    public class DivideByZeroException : Exception
    {
        public double number { get; private set; }

        public DivideByZeroException(double n) : base()
        {
            number = n;
        }

    }
}
