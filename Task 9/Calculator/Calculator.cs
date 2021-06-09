using System;

namespace Calculator
{
    public class Calculator
    {
        public double Sum(double sum1, double sum2)
        {
            return sum1 + sum2;
        }

        public double Substract(double sub1, double sub2)
        {
            return sub1 - sub2;
        }
        public double Divide (double div1, double div2)
        {
           double nan = Single.NaN;
            if (div2 == 0.0)
                return nan;
           else return div1/div2;
        }
        public double Multiply(double mul1, double mul2)
        {
            return mul1 * mul2;
        }

    }
}
