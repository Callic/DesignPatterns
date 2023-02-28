using DP.Core.Structural_Patterns.Facade.Exemplo_1.Interfaces;
using DP.Core.Structural_Patterns.Facade.Exemplo_1.Models;

namespace DP.Core.Structural_Patterns.Facade.Exemplo_1
{
    public class PagamentoCartaoCreditoService : IPagamentoCartaoCreditoService
    {

        private readonly IPagamentoCartaoCreditoFacade _pagamentoCartaoCreditoFacade;
        public PagamentoCartaoCreditoService(IPagamentoCartaoCreditoFacade pagamentoCartaoCreditoFacade)
        {
            _pagamentoCartaoCreditoFacade = pagamentoCartaoCreditoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            if(!_pagamentoCartaoCreditoFacade.RealizarPagamento(pedido, pagamento))
            {
                pagamento.Status = "Pagamento não aprovado via cartão de crédito";
                return pagamento;
            }

            pagamento.Status = "Pagamento Aprovado via cartão de crédito";
            return pagamento;
        }
    }
}
