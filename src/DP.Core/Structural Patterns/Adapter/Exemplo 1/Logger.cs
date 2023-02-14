using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Adapter.Exemplo_1
{
    public class Logger : ILogger<Logger>
    {
        public void Log(string messagem)
        {
            Console.WriteLine(messagem);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
