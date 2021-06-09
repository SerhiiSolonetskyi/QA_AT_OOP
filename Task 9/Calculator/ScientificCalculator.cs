using System;
using System.Linq;

namespace Calculator
{
  public class ScientificCalculator
    {
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
    }
}
