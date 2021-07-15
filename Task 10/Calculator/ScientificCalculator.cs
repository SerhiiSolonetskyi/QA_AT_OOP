using System;
using System.Linq;

namespace Calculator
{
  public class ScientificCalculator
    {
        public string error;
        public double result;
        public double Pow(double number, double degree)
        {
            return Math.Pow(number, degree);
        }

        public double Percent(double value, double percent)
        {               
            return (value * percent) / 100;
        }

        public double Mod(double value)
        {
            return Math.Abs(value);
        }

        public int MaxOfArray(int a, int b, int c, int d)
        {
            int[] nums = {a,b,c,d};
            return nums.Max();
        }

        public int MinOfArray(int a, int b, int c, int d)
        {
            int[] nums = { a, b, c, d };
            return nums.Min();
        }
        public int SumOfAnArray(int a, int b, int c, int d)
  
        {
            int[] nums = { a, b, c, d };
            return nums.Sum();
        }

        public void Divide(double div1, double div2)
        {
            if (div2 == 0.0)
            {
                error = "Division by zero!";

            }
            else  result = div1 / div2;
            
        }

    }
}
