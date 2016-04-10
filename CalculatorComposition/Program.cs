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
            calc.Add(5, 6);

            Calculator calc1 = new Calculator(new LoggerFile());
            calc1.Add(10, 15);
            
            Console.ReadLine();
        }
    }
}
