using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorComposition
{
    class Calculator
    {
        ILogger _logger;

        public Calculator(ILogger log)
        {
            _logger = log;
        }
        public int Add(int a, int b)
        {
            int sum = a + b;
            _logger.Logging();
            Console.WriteLine("Sum is {0}", sum);
            return sum;
        }
    }
}
