using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Facade.Exemplo_1.Models
{
    public class Pedido
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public decimal Valor { get; set; }
        public IEnumerable<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
