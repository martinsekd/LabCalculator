using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LabCalculator;

namespace Calculator.Test.Unit
{
    [TestFixture]
    class CalculatorTest
    {
        private LabCalculator.Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new LabCalculator.Calculator();
        }

        [Test]
        public void Add_Add2And2_4()
        {
            double sum = uut.Add(2, 2);

            Assert.That(sum, Is.EqualTo(4));
        }

        [Test]
        public void Subtract_Subtract4With2_2()
        {
            double sum = uut.Subtract(4, 2);

            Assert.That(sum, Is.EqualTo(2));
        }



        [Test]
        public void Multiply_Multiply2With4_8()
        {
            double sum = uut.Multiply(2, 4);

            Assert.That(sum, Is.EqualTo(8));
        }

        [Test]
        public void Power_Power4With2_16()
        {
            double sum = uut.Power(4, 2);

            Assert.That(sum, Is.EqualTo(16));
        }

        [Test]
        public void Multiply_Multiply4With0_0()
        {
            double sum = uut.Multiply(4, 0);

            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void Multiply_MultiplyNegative2With2_4()
        {
            double sum = uut.Multiply(-2, -2);

            Assert.That(sum, Is.EqualTo(4));
        }

        [Test]
        public void Subtract_SubtractNegative2With4_negative6()
        {
            double sum = uut.Subtract(-2, 4);

            Assert.That(sum, Is.EqualTo(-6));
        }

        [Test]
        public void Power_Power4With0_1()
        {
            double sum = uut.Power(4, 0);

            Assert.That(sum, Is.EqualTo(1));
        }

        [Test]
        public void Power_Power10WithNegative1_0dot1()
        {
            double sum = uut.Power(10, -1);

            Assert.That(sum, Is.EqualTo(0.1));
        }

        [Test]
        public void Power_Power0With0_1()
        {
            double sum = uut.Power(0, 0);

            Assert.That(sum, Is.EqualTo(1));
        }

        [TestCase(0, 2, 2)]
        [TestCase(-4, -2, -6)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 5, 5)]
        public void Add_Add2Numbers_d(double a, double b, double d)
        {
            double sum = uut.Add(a, b);
            Assert.That(sum, Is.EqualTo(d));
        }

        [TestCase(0, 2, -2)]
        [TestCase(-4, -2, -2)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 5, -5)]
        [TestCase(0, -5, 5)]
        public void Subtraction_Subtract2Numbers_d(double a, double b, double d)
        {
            double sum = uut.Subtract(a, b);
            Assert.That(sum, Is.EqualTo(d));
        }

        [TestCase(0, 2, 0)]
        [TestCase(-4, -2, 8)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 5, 0)]
        [TestCase(0, -5, 0)]
        [TestCase(1, -5, -5)]
        public void Multiply_Multiply2Numbers_d(double a, double b, double d)
        {
            double sum = uut.Multiply(a, b);
            Assert.That(sum, Is.EqualTo(d));
        }

        private double square = Math.Sqrt(10);
        [TestCase(0, 2, 0)]
        [TestCase(10, -2, 0.01)]
        [TestCase(0, 0, 1)]
        [TestCase(0, 5, 0)]
        [TestCase(10, 0.5, 3.1622776601683795)]
        [TestCase(10, 3, 1000)]
        public void Power_PoweraWithb_d(double a, double b, double d)
        {
            double sum = uut.Power(a, b);
            Assert.That(sum, Is.EqualTo(d));
        }

        [TestCase(0, 2, 0)]
        [TestCase(10, -2, -5)]
        [TestCase(0, 1, 0)]
        [TestCase(0, 5, 0)]
        [TestCase(10, 0.5, 20)]
        [TestCase(10, 10, 1)]
        public void Divide_DivideaWithb_d(double a, double b, double d)
        {
            double sum = uut.Divide(a, b);
            Assert.That(sum, Is.EqualTo(d));
        }
        static void Main(string[] args)
        {

        }
    }
}
