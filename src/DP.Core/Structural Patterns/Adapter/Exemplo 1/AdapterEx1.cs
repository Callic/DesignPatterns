using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Adapter.Exemplo_1
{
    public class AdapterEx1 : IAdapter<AdapterEx1>
    {
        private readonly ILogger<Logger> _logger;
        private readonly ILogger<LogAdapter> _logAdapter;

        public AdapterEx1(ILogger<Logger> logger, ILogger<LogAdapter> logAdapter)
        {
            _logger = logger;
            _logAdapter = logAdapter;
        }
        public void Executar()
        {
            _logger.Log("Log normal");

            _logAdapter.Log("Log Adapter");

        }
    }
}
