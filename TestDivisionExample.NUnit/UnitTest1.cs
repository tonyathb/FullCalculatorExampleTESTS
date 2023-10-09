using DivisionExample;
using NUnit.Framework;

namespace TestDivisionExample.NUnit
{
    public class Tests
    {
       
        [Test]
        public void TestSumWorkPrely()
        {
            Calculator calc = new Calculator();
            double res = calc.Sum(2, 4);
            Assert.AreEqual(6, "Tochnostta ne e .01");
        }
    }
}