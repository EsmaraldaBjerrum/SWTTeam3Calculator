using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator =0;
        public double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public double Add(double a)
        {
            Accumulator += a;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            return result;
        }
        public double Subtract(double a)
        {
            Accumulator -= a;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double Multiply(double a)
        {
            Accumulator = a*Accumulator;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            double result = Math.Pow(x, exp);
            return result;
        }

        public double Power(double exp)
        {
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0; 
        }
    }
}
