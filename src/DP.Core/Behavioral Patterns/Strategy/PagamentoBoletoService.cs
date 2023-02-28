using DP.Core.Behavioral_Patterns.Strategy.Interfaces;
using DP.Core.Structural_Patterns.Facade.Exemplo_1;
using DP.Core.Structural_Patterns.Facade.Exemplo_1.Models;

namespace DP.Core.Behavioral_Patterns.Strategy
{
    public class PagamentoBoletoService : IPagamentoBoletoService
    {
        //vou utilizar o facade do cartão de crédito apenas para simular a autorização da transação
        private readonly IPagamentoCartaoCreditoFacade _facade;

        public PagamentoBoletoService(IPagamentoCartaoCreditoFacade facade)
        {
            _facade = facade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            if (!_facade.RealizarPagamento(pedido, pagamento))
            {
                pagamento.Status = "Pagamento não aprovado via boleto";
                return pagamento;
            }

            pagamento.Status = "Pagamento Aprovado via boleto";
            return pagamento;
        }
    }
}
