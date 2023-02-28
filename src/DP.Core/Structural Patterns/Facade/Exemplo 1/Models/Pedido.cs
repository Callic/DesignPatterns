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

        public static Pedido GerarPedido()
        {
            var produtos = new List<Produto>
            {
                new Produto{ Nome = "Nike Pegasus 39", Valor = 699.99m},
                new Produto{ Nome = "Monitor Samsumg 34\"", Valor = 3699.99m},
                new Produto{ Nome = "Bíblia ACF", Valor = 99.99m},
            };
            var pedido = new Pedido
            {
                Produtos = produtos,
                Valor = produtos.Select(p => p.Valor).Sum()
            };
            return pedido;
        }
    }
}
