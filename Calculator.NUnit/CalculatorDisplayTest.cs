using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DivisionExample;

namespace Calculator.NUnit
{
    class CalculatorDisplayTest
    {
        private CalculatorDisplay display;

        [Test]
        public void TestWithNumber()
        {
            display = new CalculatorDisplayInTest("123");
            Assert.AreEqual(123, display.ReadNumber());
        }

        [Test]
        public void TestWithNotNumber()
        {
            display = new CalculatorDisplayInTest("abc");
            FormatException exception = Assert.Throws<FormatException>(() => display.ReadNumber());
        }

        private class CalculatorDisplayInTest : CalculatorDisplay
        {

            private readonly string consoleOutput;

            public CalculatorDisplayInTest(string consoleOutput)
            {
                this.consoleOutput = consoleOutput;
            }

            protected override string ReadFromConsole()
            {
                return consoleOutput;
            }
        }
    }
}
