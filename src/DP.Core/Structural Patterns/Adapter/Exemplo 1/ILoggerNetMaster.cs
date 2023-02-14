using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Adapter.Exemplo_1
{
    public interface ILoggerNetMaster
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(Exception exception);
    }
}
