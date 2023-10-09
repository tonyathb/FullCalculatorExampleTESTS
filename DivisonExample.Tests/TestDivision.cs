using DivisionExample;
using NUnit.Framework;
using System;

namespace DivisonExample.Tests
{
    [TestFixture]
    public class TestDivision
    {
        [Test]
        public void Dividing4By2Gives2()
        {
            //Arrange
            Calculator div = new Calculator();
            //Act
            var result = div.Divide(4, 2);
            //Assert
            Assert.AreEqual(2, result, "Dividing 4 by 2 does not result in 2.");
        }
        [Test]
        public void TestDivideByZeroThrowsException()
        {
            //Arrange
            Calculator div = new Calculator();
            //Act
            //var result = ;
            //Assert
            //Assert.AreEqual(2, result, "Dividing 4 by 2 does not result in 2.");
            Assert.Throws<DivideByZeroException>(() =>div.Divide(4, 0));
        }


    }
}
