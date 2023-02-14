using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Adapter.Exemplo_1
{
    public class LoggerNetMaster : ILoggerNetMaster
    {
        public void LogError(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"Log Info: {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"Log Warning: {message}");
        }
    }
}
