using System;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace Calculator.UnitTestForCalculator
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calc = new Calculator();

        [Test]
        public void CheckSumPassTest()
        {
            double sum1 = 5.2;
            double sum2 = 7.3;
            double expectedResult = 12.5;
            double actualResult = calc.Sum(sum1, sum2);
            Assert.AreEqual(expectedResult, actualResult, $"Sum of {sum1} and {sum2} suld be {expectedResult}");
        }
        [Test]
        public void CheckSubstractPassTest()
        {
            double sub1 = 17.0;
            double sub2 = 7.0;
            double expectedResult = 4.0;
            double actualResult = calc.Substract(sub1, sub2);
            Assert.AreNotSame(expectedResult, actualResult, "Result are not same - {0} and {1}", expectedResult, actualResult);
            
        }
        [Test]
        public void CheckDividePassTest()
        {
            double div1 = 50.0;
            double div2 = 0.0;
            double expectedResult = Single.NaN;
            double actualResult = calc.Divide(div1, div2);
            Assert.IsNaN(expectedResult, "division by zero is not allowed", actualResult);
        }

        [Test]
        public void CheckMultiplyPassTest()
        {
            double mul1 = 10.0;
            double mul2 = 6.0;
            double expectedResult = 60.0;
            double actualResult = calc.Multiply(mul1, mul2);
            Assert.GreaterOrEqual(expectedResult, actualResult, "Result is greather than {0}", expectedResult);
        }

        [Test]
        public void CheckSumFailTest()
        {
            double sum1 = 57.0;
            double sum2 = 43.0;
            double expectedResult = 1000.0;
            double actualResult = calc.Sum(sum1, sum2);
            Assert.Less(expectedResult, actualResult, "Sum is less than {}", expectedResult);
            
        }
        [Test]
        public void CheckSubstractFailTest()
        {
            double sub1 = 17.0;
            double sub2 = 237.0;
            double actualResult = calc.Substract(sub1, sub2);
            Assert.Positive(actualResult, "Result is greather than 0");
        }
        [Test]
        public void CheckDivideFailTest()
        {
            double div1 = 50.3;
            double div2 = 11.5;
            double actualResult = calc.Divide(div1, div2);
            Assert.IsNull(actualResult,"Result does not have value" );
        }

        [Test]
        public void CheckMultiplyFailTest()
        {
            double mul1 = 10.0;
            double mul2 = 0.0;
            double actualResult = calc.Multiply(mul1, mul2);
            Assert.NotZero(actualResult, "Result is not 0");
        }
    }
    }

