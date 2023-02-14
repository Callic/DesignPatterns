using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Adapter.Exemplo_1
{
    public interface ILogger<T> where T : class
    {
        void Log(string messagem);
        void LogException(Exception exception);
    }
}
