using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();// 

            double result = calculator.Sum(number1, number2);
            Console.WriteLine($"Sum ==> {number1} + {number2} = {result}");

            result = calculator.Izvajdane(number1, number2);
            Console.WriteLine($"Izvajdane ==> {number1} - {number2} = {result}");

            result = calculator.Multiplay(number1, number2);
            Console.WriteLine($"Umnojenie ==> {number1} * {number2} = {result}");
            try
            {
                result = calculator.Divide(number1, number2);
                Console.WriteLine($"Delenie ==> {number1} / {number2} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Делене на 0!");
            }

            result = calculator.Stepenuvane(number1, number2);
            Console.WriteLine($"Stepenuvane ==> {number1} na stepen {number2} = {result:f10}");
        }
    }
}
