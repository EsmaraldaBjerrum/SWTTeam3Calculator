using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Unit.Test
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        public Calculator uut;

        [SetUp]
        public void SetUp()
        {
            uut = new Calculator();
        }

        [Test]
        [TestCase(1, 3, 4)]
        [TestCase(-5, 3, -2)]
        [TestCase(-5, -3, -8)]
        [TestCase(-5, 5, 0)]
        [TestCase(-5.9, 3.5, -2.4)]
        public void Add_aPlusb_Resultc(double a, double b, double c)
        {
            double result = uut.Add(a, b);
            Assert.That(result, Is.InRange(c-0.001, c+0.001));
        }

        [Test]
        [TestCase(1, 3, -2)]
        [TestCase(-5, 3, -8)]
        [TestCase(-5, -3, -2)]
        [TestCase(-5, 5, -10)]
        [TestCase(-5.9, 3.5, -9.4)]
        public void Subtract_aMinusb_Resultc(double a, double b, double c)
        {
            Assert.That(uut.Subtract(a,b), Is.InRange(c-0.001, c+0.001));
        }

        [Test]
        [TestCase(1, 3, 3)]
        [TestCase(-5, 3, -15)]
        [TestCase(-5, -3, 15)]
        [TestCase(-5, 0, 0)]
        [TestCase(-5, 3.5, -17.5)]
        public void Multiply_aTimesb_Resultc(double a, double b, double c)
        {
            Assert.That(uut.Multiply(a, b), Is.InRange(c - 0.001, c + 0.001));
        }

        [Test]
        [TestCase(1, 3, 1)]
        [TestCase(-5, 3, -125)]
        [TestCase(-5, -1, -0.2)]
        [TestCase(-5, 0, 1)]
        [TestCase(2.5, 2, 6.25)]
        public void Power_aPoweredByb_Resultc(double a, double b, double c)
        {
            Assert.That(uut.Power(a, b), Is.InRange(c - 0.001, c + 0.001));
        }

        [Test]
        [TestCase(1, 3, 0.3333)]
        [TestCase(-5, 2, -2.5)]
        [TestCase(-5, -1, 5)]
        [TestCase(-5, 0.2, -25)]
        [TestCase(2.6, 2, 1.3)]
        public void Divide_aDividedByb_Resultc(double a, double b, double c)
        {
            Assert.That(uut.Divide(a, b), Is.InRange(c - 0.001, c + 0.001));
        }

        [Test]
        public void Divide_aDividedBy0_ResultException(double a, double b, double c)
        {
            //Indsæt kode
        }
    }
}
