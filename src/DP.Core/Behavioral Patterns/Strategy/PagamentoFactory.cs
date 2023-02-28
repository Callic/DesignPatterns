using DP.Core.Behavioral_Patterns.Strategy.Interfaces;
using DP.Core.Structural_Patterns.Facade.Exemplo_1;
using DP.Core.Structural_Patterns.Facade.Exemplo_1.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DP.Core.Behavioral_Patterns.Strategy
{
    public class PagamentoFactory
    {
        private readonly IServiceProvider _service;

        public PagamentoFactory(IServiceProvider service)
        {
            _service = service;
        }

        public IPagamento CreatePagamento(TipoPagamento tipoPagamento)
        {
            switch (tipoPagamento)
            {
                case TipoPagamento.CartaoCredito:
                    return _service.GetService<IPagamentoCartaoCreditoService>()!;
                //case TipoPagamento.Debito:
                //    return _service.GetService<IPagamento<PagamentoCartaoCreditoService>>();
                case TipoPagamento.Boleto:
                    return _service.GetService<IPagamentoBoletoService>()!;
                default:
                    throw new ArgumentException("Tipo de Pagamento não reconhecido");
            }


        }
    }
}