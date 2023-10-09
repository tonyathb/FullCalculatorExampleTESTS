using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionExample
{
    public class Calculator
    {
        public double Divide(double x, int y)
        {
            if (y != 0)
            {
                return x / y;
            }
            throw new DivideByZeroException("Deli se na 0!!!");
        }
        public double Sum(int x, int y)
        {            
                return (x+ y);          
        }
        public double Izvajdane(double op1, double op2)
        {
            return op1 - op2;
        }
        public double Multiplay(double op1, double op2)
        {
            return op1 * op2;
        }
        public double Stepenuvane(int chisllo, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (n > 0)
            {
                double res = chisllo;
                for (int i = 1; i < n; i++)
                {
                    res = res * chisllo;
                }
                return res;
            }
            else
            {
                double res = 1.0 / chisllo;
                n = -n;
                for (int i = 1; i < n; i++)
                {
                    res = res * 1.0 / chisllo;
                }
                return res;
            }
            
        }
    }
}
