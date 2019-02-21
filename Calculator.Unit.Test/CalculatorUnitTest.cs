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
       [TestCase(1, 3, 4)]
       [TestCase(-5, 3, -2)]
       [TestCase(-5, -3, -8)]
       [TestCase(-5, 5, 0)]
       [TestCase(-5.9, 3.5, -2.4)]
       public void Add_aPlusb_Accumulator(double a, double b, double c)
       {
          double result = uut.Add(a, b);
          Assert.That(result, Is.EqualTo(uut.Accumulator));
       }

       [Test]
       [TestCase(1, 3, -2)]
       [TestCase(-5, 3, -8)]
       [TestCase(-5, -3, -2)]
       [TestCase(-5, 5, -10)]
       [TestCase(-5.9, 3.5, -9.4)]
       public void Subtract_aMinusb_Accumulator(double a, double b, double c)
       {
          double result = uut.Subtract(a, b);
         Assert.That(result, Is.EqualTo(uut.Accumulator));
       }

       [Test]
       [TestCase(1, 3, 3)]
       [TestCase(-5, 3, -15)]
       [TestCase(-5, -3, 15)]
       [TestCase(-5, 0, 0)]
       [TestCase(-5, 3.5, -17.5)]
       public void Multiply_aTimesb_Accumulator(double a, double b, double c)
       {
          double result = uut.Multiply(a, b);
         Assert.That(result, Is.EqualTo(uut.Accumulator));
       }

       [Test]
       [TestCase(1, 3, 1)]
       [TestCase(-5, 3, -125)]
       [TestCase(-5, -1, -0.2)]
       [TestCase(-5, 0, 1)]
       [TestCase(2.5, 2, 6.25)]
       public void Power_aPoweredByb_Accumulator(double a, double b, double c)
       {
          double result = uut.Power(a, b);
         Assert.That(result, Is.EqualTo(uut.Accumulator));
       }
   


        [Test]
        [TestCase(1, 3, 4)]
        [TestCase(-5, 3, -2)]
        [TestCase(-5, -3, -8)]
        [TestCase(-5, 5, 0)]
        [TestCase(-5.9, 3.5, -2.4)]
        public void AddOneNumber_aPlusb_Resultc(double a, double b, double c)
        {
            uut.Accumulator = a;
            double result = uut.Add(b);
            Assert.That(result, Is.InRange(c - 0.001, c + 0.001));
        }

        [Test]
        [TestCase(1, 3, -2)]
        [TestCase(-5, 3, -8)]
        [TestCase(-5, -3, -2)]
        [TestCase(-5, 5, -10)]
        [TestCase(-5.9, 3.5, -9.4)]
        public void SubtractOneNumber_aMinusb_Resultc(double a, double b, double c)
        {
            uut.Accumulator = a;
            Assert.That(uut.Subtract(b), Is.InRange(c - 0.001, c + 0.001));
        }

        [Test]
        [TestCase(1, 3, 3)]
        [TestCase(-5, 3, -15)]
        [TestCase(-5, -3, 15)]
        [TestCase(-5, 0, 0)]
        [TestCase(-5, 3.5, -17.5)]
        public void MultiplyOneNumber_aTimesb_Resultc(double a, double b, double c)
        {
            uut.Accumulator = a;
            Assert.That(uut.Multiply(b), Is.InRange(c - 0.001, c + 0.001));
        }

        [Test]
        [TestCase(1, 3, 1)]
        [TestCase(-5, 3, -125)]
        [TestCase(-5, -1, -0.2)]
        [TestCase(-5, 0, 1)]
        [TestCase(2.5, 2, 6.25)]
        public void PowerOneNumber_aPoweredByb_Resultc(double a, double b, double c)
        {
            uut.Accumulator = a;
            Assert.That(uut.Power(b), Is.InRange(c - 0.001, c + 0.001));
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
        [TestCase(1,0)]
        [TestCase(3,0)]
        [TestCase(5, 0)]
        public void Divide_aDividedBy0_ResultException(double a, double b)
        {
            Assert.That(() => uut.Divide(a,b), Throws.TypeOf<DivideByZeroException>());
            //uut.Divide(a, 0);
            //Assert.Catch<DivideByZeroException>(() => uut.Divide(a, b));
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(3, 0)]
        [TestCase(5, 0)]
        public void DivideOneNumber_aDividedBy0_ResultException(double a, double b)
        {
            uut.Accumulator = a;
            Assert.That(() => uut.Divide(b), Throws.TypeOf<DivideByZeroException>());
            //uut.Divide(a, 0);
            //Assert.Catch<DivideByZeroException>(() => uut.Divide(a, b));
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(3, 0)]
        [TestCase(5, 0)]
        public void Clear_AccumolatorIsa_ReturnsZero(double a, double b)
        {
            uut.Accumulator = a;
            uut.Clear();
            Assert.That(uut.Accumulator, Is.EqualTo(0));
        }
    }
}
