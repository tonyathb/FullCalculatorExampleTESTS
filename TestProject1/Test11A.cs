using DivisionExample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    [TestClass]
    public class DIV
    {
        [TestMethod]
        public void TestNUnitTestDivideWorkProperly()
        {
            Calculator calc = new Calculator();
            double res = calc.Divide(2, 4);
            Assert.IsTrue(Math.Abs(res - (2.0/4)) < 0.01,"Tochnostta ne e .01");
        }
    }
}
