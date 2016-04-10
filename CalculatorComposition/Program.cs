using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(new LoggerConsole());
            int sum = calc.Add(5, 6);

            Calculator calc1 = new Calculator(new LoggerFile());
            int sum2 = calc1.Add(10, 15);
            
            Console.ReadLine();
        }
    }
}
