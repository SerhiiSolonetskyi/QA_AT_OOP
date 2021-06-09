using Calculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UnitTestForCalculator
{
    [TestFixture]
    [Category ("Scientific Calculator Tests")]
   public class ScientificCalculatorTests
    {
        ScientificCalculator scalc = new ScientificCalculator();


        [Test]       
        public void CheckPow()

        {
            double number = 2;
            double degree = 8;
            Assert.That(scalc.Percent(number, degree), Is.Not.Null, "Result is not NULL");
      
        }


        [Test]
  
        public void CheckPercent ()
        {
            double value = 250;
            double percent = 20;
            double expectedResult = 50;
            double actualResult = scalc.Percent(value, percent);
            Assert.That(actualResult, Is.EqualTo(expectedResult), "Result is 50");
        }

        [Test]
        public void CheckMod()
        {
            double abs1 = 0;
            double actualResult = scalc.Mod(abs1);
            Assert.Zero(actualResult, "Result is Zero");

        }

        [Test]
        public void CheckMaxOfArray()

        {
            int maxa = 2;
            int maxb = 4;
            int maxc = 6;
            int maxd = 8;
            int actualResult = scalc.MaxOfArray(maxa, maxb, maxc, maxd);
            Assert.That(actualResult, Is.GreaterThanOrEqualTo(8).And.LessThanOrEqualTo(8), "Result is 8");
        }

        

        [Test]
        public void CheckMinOfArray()

        {
            int mina = 4;
            int minb = 7;
            int minc = 15;
            int mind = 22;
            int actualResult = scalc.MinOfArray(mina, minb, minc, mind);
            Assert.That(actualResult, Is.LessThanOrEqualTo(6), "Result is less than 6");
        }

        [Test]
        public void ChecSumOfArray()

        {
            int suma = 10;
            int sumb = 50;
            int sumc = 15;
            int sumd = 25;
            int expectedResult = 100;
            int actualResult = scalc.SumOfAnArray(suma, sumb, sumc, sumd);
            Assert.GreaterOrEqual(actualResult, expectedResult, "Result is equal to 100");

        }

    }
}