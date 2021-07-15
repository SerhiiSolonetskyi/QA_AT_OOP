using Calculator;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace UnitTestForCalculator
{
    [TestFixture]
    [Category("Scientific Calculator Tests")]
    public class ScientificCalculatorTests
    {
        int resulForInt;
        double resulForDouble;
        ScientificCalculator scalc = new ScientificCalculator();

        [SetUp]
        public void Init()
        {
            resulForInt = 0;
            resulForDouble = 0;

        }

        [TearDown]
        public void Dispose()
        {
            resulForInt = 0;
            resulForDouble = 0;
        }

        [Test, Order(2), Combinatorial, MaxTime(15)]

        public void CheckPow(
            [Values(4, 3, 8)] double number, [Values(5, 6)] double degree
        )

        {
            Assert.That(scalc.Percent(number, degree), Is.Not.Null, "Result is not NULL");
        }


        [Test, Order(5)]
        [TestCase(250, 20, ExpectedResult = 50)]
        [TestCase(844, 28, ExpectedResult = 236.32)]
        [TestCase(10, 50, ExpectedResult = 4)]
        public double CheckPercent(double value, double percent)
        {
            return scalc.Percent(value, percent);
        }


        [Test, Order(1)]
        public void CheckMod()
        {
            resulForDouble = scalc.Mod(0);
            Assert.Zero(resulForDouble, "Zero");

        }

        [Test, Order(3), Pairwise, Timeout(50), Retry(300)]
        public void CheckMaxOfArray
        (
        [Values(2, 3)] int maxa, [Values(4, 5)] int maxb, [Values(6, 7)] int maxc, [Values(8, 9)] int maxd
        )

        {
            resulForInt = scalc.MaxOfArray(maxa, maxb, maxc, maxd);
            Assert.That(resulForInt, Is.GreaterThanOrEqualTo(8).And.LessThanOrEqualTo(8), "Result is at least 8");
        }



        [Test, Order(6), Sequential, MaxTime(25)]
        public void CheckMinOfArray
        (
        [Values(4, 6, 12)] int mina, [Values(7, 12, 8)] int minb, [Values(15, 8, 56)] int minc, [Values(22, 33, 92)] int mind
        )

        {
            resulForInt = scalc.MinOfArray(mina, minb, minc, mind);
            Assert.That(resulForInt, Is.LessThanOrEqualTo(6), "Result is less than or equal to 6");
        }

        [Test, Order(4)]
        [TestCase(-2, 2, 5, 3, ExpectedResult = 8)]
        [TestCase(12, 0, -5, 5, ExpectedResult = 12)]
        [TestCase(10, 50, 15, 25, ExpectedResult = 101)]
        public int CheckSumOfArray(int suma, int sumb, int sumc, int sumd)

        {
            return scalc.SumOfAnArray(suma, sumb, sumc, sumd);

        }
        [Test, Order(7)]
        public void CheckStartOfDivisionByZeroErrorMessage()
        {
            scalc.Divide(8, 0);
            StringAssert.StartsWith("Div", scalc.error);

        }

        [Test, Order(8)]
        public void CheckContentOfDivisionByZeroErrorMessage()
        {
            scalc.Divide(1, 0);
            StringAssert.AreEqualIgnoringCase("Division by zero!", scalc.error);

        }

        [Test, Order(9)]
        public void CheckPartOfDivisionByZeroErrorMessage()
        {
            scalc.Divide(5, 0);
            StringAssert.Contains("by zero!", scalc.error);

        }
    }

 }