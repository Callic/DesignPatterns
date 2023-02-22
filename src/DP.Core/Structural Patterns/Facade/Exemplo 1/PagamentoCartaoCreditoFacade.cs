using DP.Core.Structural_Patterns.Facade.Exemplo_1.Clients;
using DP.Core.Structural_Patterns.Facade.Exemplo_1.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Facade.Exemplo_1
{
    public class PagamentoCartaoCreditoFacade : IPagamentoCartaoCreditoFacade
    {
        private readonly IPayPalGateway _payPalGateway;
        private readonly IConfiguration _configuration;
        public PagamentoCartaoCreditoFacade(IPayPalGateway payPalGateway, IConfiguration configuration)
        {
            _payPalGateway = payPalGateway;
            _configuration = configuration;
        }
        public bool RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            var apiKey = _configuration["apiKey"];
            var encriptionKey = _configuration["encriptionKey"];
            
            var serviceKey = _payPalGateway.GetPayPalServiceKey(apiKey!, encriptionKey!);
            var cardHashKey = _payPalGateway.GetCardHashKey(serviceKey, pagamento.CartaoCredito);

            return _payPalGateway.CommitTransaction(cardHashKey, pedido.Id, pagamento.Valor);
        }
    }
}
