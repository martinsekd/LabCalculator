using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalculator
{
    public class Calculator
    {
        public double Accumulator { get; private set; }

        public Calculator()
        {
            Accumulator = 0;
        }
        public void Clear()
        {
            Accumulator = 0;
        }
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return a + b;

        }

        public double Add(double a)
        {
            Accumulator += a;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return a - b;
        }

        public double Subtract(double a)
        {
            Accumulator -= a;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return a * b;
        }

        public double Multiply(double a)
        {
            Accumulator *= a;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Math.Pow(x, exp);
        }

        public double Power(double a)
        {
            Accumulator = Math.Pow(Accumulator, a);
            return Accumulator;
        }
        public double Divide(double x, double y)
        {
            if (y == 0)
                    throw new DivideByZeroException(y);
                Accumulator = x / y;
                return x / y;
        }

        public double Divide(double a)
        {
            if (a == 0)
                    throw new DivideByZeroException(a);
            Accumulator /= a;
            return Accumulator;
        }

    }
}
