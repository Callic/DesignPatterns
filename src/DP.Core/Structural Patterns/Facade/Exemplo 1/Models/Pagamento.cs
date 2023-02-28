using DP.Core.Behavioral_Patterns.Strategy;
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

        public TipoPagamento TipoPagamento { get; set; }
        public static Pagamento GerarPagamento(Pedido pedido, TipoPagamento tipoPagamento)
        {
            return new Pagamento
            {
                CartaoCredito = "123456 654321 456987 789456",
                Valor = pedido.Valor,
                TipoPagamento = tipoPagamento
            };
        }
    }
}
