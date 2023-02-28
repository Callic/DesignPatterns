using DP.Core.Structural_Patterns.Facade.Exemplo_1;
using DP.Core.Structural_Patterns.Facade.Exemplo_1.Models;

namespace DP.Core.Behavioral_Patterns.Strategy
{
    public class PedidoService
    {
        private readonly PagamentoFactory _pagamentoFactory;
        private IPagamento _pagamento;
        public PedidoService(PagamentoFactory pagamentoFactory)
        {
            _pagamentoFactory = pagamentoFactory;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            _pagamento = _pagamentoFactory.CreatePagamento(pagamento.TipoPagamento);
            return _pagamento.RealizarPagamento(pedido, pagamento);
        }
    }
}
