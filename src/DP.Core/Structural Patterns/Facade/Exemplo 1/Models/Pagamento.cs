using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Facade.Exemplo_1.Models
{
    public class Pagamento
    {
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public string CartaoCredito { get; set; }
    }
}
