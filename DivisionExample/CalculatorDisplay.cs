using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionExample
{
    public class CalculatorDisplay
    {
        public int ReadNumber()
        {
            return int.Parse(ReadFromConsole());
        }

        protected virtual string ReadFromConsole()
        {
            return Console.ReadLine();
        }
    }
}
