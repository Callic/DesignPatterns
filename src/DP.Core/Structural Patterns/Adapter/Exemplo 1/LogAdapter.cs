using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Adapter.Exemplo_1
{
    public class LogAdapter : ILogger<LogAdapter>
    {
        private readonly ILoggerNetMaster _logNetMaster;
        public LogAdapter(ILoggerNetMaster logNetMaster)
        {
            _logNetMaster = logNetMaster;
        }
        public void Log(string messagem)
        {
            _logNetMaster.LogInfo(messagem);
        }

        public void LogException(Exception exception)
        {
            _logNetMaster.LogError(exception);
        }
    }
}
