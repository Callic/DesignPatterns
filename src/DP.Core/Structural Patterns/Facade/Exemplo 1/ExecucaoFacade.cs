
using DP.Core.Structural_Patterns.Facade.Exemplo_1.Models;
using Microsoft.Extensions.Configuration;

namespace DP.Core.Structural_Patterns.Facade.Exemplo_1
{
    public class ExecucaoFacade
    {
        
        private readonly IPagamento _pagamentoCartaoCreditoService;
        public ExecucaoFacade(IConfiguration configuration, IPagamento pagamentoCartaoCreditoService)
        {
            _pagamentoCartaoCreditoService = pagamentoCartaoCreditoService;
        }

        public void Executar()
        {
            var objetos = MontarObjetos();
            var result = _pagamentoCartaoCreditoService.RealizarPagamento(objetos.pedido, objetos.pagamento);
            Console.WriteLine(result.Status);
        
        }
        private (Pedido pedido, Pagamento pagamento) MontarObjetos()
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

            var pagamento = new Pagamento
            {
                CartaoCredito = "123456 654321 456987 789456",
                Valor = pedido.Valor
            };

            return (pedido, pagamento);
        }
    }
}
