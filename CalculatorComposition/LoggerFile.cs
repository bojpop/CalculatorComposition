using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorComposition
{
    class LoggerFile : ILogger
    {
        public void Logging()
        {
            Console.WriteLine("This is file logger");
        }
    }
}
