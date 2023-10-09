using System;
using NUnit.Framework;
using DivisionExample;

namespace CalculatorNUnit
{
    [TestFixture]
    public class NUnitTests
    {
        
        [Test]
        public void TestDivedeIfDivideByZero()
        {
            DivisionExample.Calculator calc = new DivisionExample.Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(20, 0));
        }

        [TestCase(2, 3)]
        [TestCase(-2, 3)]
        [TestCase(2, -3)]
        [TestCase(-2, -3)]
        [TestCase(0, -3)]
        public void Test_Sum_Work_Properly(int num1, int num2)
        {
            //Arrange
            DivisionExample.Calculator calc = new DivisionExample.Calculator();
            double result = 0;
            for (int i = 0; i < 5; i++)
            {
                //Act 
                result=calc.Sum(num1, num2);
                //Assert
                Assert.AreEqual(num1 + num2,result ,
                    $"{num1} + {num2} ne e {num1 + num2}");
            }
        }
        [TestCase(2, 3)]
        [TestCase(-2, 3)]
        [TestCase(2, -3)]
        [TestCase(-2, -3)]
        [TestCase(0, -3)]
        public void Test_Substract_Work_Properly(int num1, int num2)
        {
            //Arrange
            DivisionExample.Calculator calc = new DivisionExample.Calculator();
            double result = 0;
            for (int i = 0; i < 5; i++)
            {
                //Act 
                result = calc.Sum(num1, num2);
                //Assert
                Assert.AreEqual(num1 - num2, result,
                    $"{num1} - {num2} ne e {num1 - num2}");
            }
        }
        [TestCase(2, 3)]
        [TestCase(-2, 3)]
        [TestCase(2, -3)]
        [TestCase(-2, -3)]
        [TestCase(0, -3)]
        public void Test_Multiplay_Work_Properly(int num1, int num2)
        {
            //Arrange
            DivisionExample.Calculator calc = new DivisionExample.Calculator();
            double result = 0;
            for (int i = 0; i < 5; i++)
            {
                //Act 
                result = calc.Sum(num1, num2);
                //Assert
                Assert.AreEqual(num1 + num2, result,
                    $"{num1} + {num2} ne e {num1 + num2}");
            }
        }

        public void Test_Divide_Work_Properly(int num1, int num2)
        {
            //Arrange
            DivisionExample.Calculator calc = new DivisionExample.Calculator();
            double result = 0;
            for (int i = 0; i < 5; i++)
            {
                //Act 
                result = calc.Sum(num1, num2);
                //Assert
                Assert.AreEqual(num1 + num2, result,
                    $"{num1} + {num2} ne e {num1 + num2}");
            }
        }

        public void Test_Stepenuvane_Work_Properly(int num1, int num2)
        {
            //Arrange
            DivisionExample.Calculator calc = new DivisionExample.Calculator();
            double result = 0;
            for (int i = 0; i < 5; i++)
            {
                //Act 
                result = calc.Stepenuvane(num1, num2);
                //Assert
                Assert.AreEqual(num1 + num2, result,
                    $"{num1} + {num2} ne e {num1 + num2}");
            }
        }
    }
}