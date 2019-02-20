using System;
using NUnit.Framework;

namespace FancyCalc
{
    [TestFixture]
    public class FancyCalculatorTests
    {

        [Test]
        public void AddTest()
        {
            FancyCalcEnguine calc = new FancyCalcEnguine();
            double expected = 4;
            double actual = calc.Add(2, 2);
            Assert.AreEqual(expected, actual);

            //double expected2 = 6;
            //double actual2 = calc.Add(3, 3);
            //Assert.AreEqual(expected2, actual2);
        }

        [Test]
        public void CalculateTestHidden()
        {
            FancyCalcEnguine calc = new FancyCalcEnguine();
            double expected2 = 6;
            double actual2 = calc.Add(3, 3);
            Assert.AreEqual(expected2, actual2);
        }

      

        [Test]
        public void SubtractTest()
        {
            var calc = new FancyCalcEnguine();
            double expected = 0;
            double actual = calc.Subtract(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractTest2()
        {
            var calc = new FancyCalcEnguine();
            double expected = 1;
            double actual = calc.Subtract(10, 9);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(3, 3, ExpectedResult = 9)]
        [TestCase(1, 0, ExpectedResult = 0)]
        [TestCase(1, -1, ExpectedResult = -1)]
        
        public double MultiplyTest(int a, int b)
        {
            var calc = new FancyCalcEnguine();
            return calc.Multiply(a, b);
        }
       

    }
}
