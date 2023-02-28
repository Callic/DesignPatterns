using DP.Core.Structural_Patterns.Facade.Exemplo_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Behavioral_Patterns.Strategy
{
    public class ExecucaoStrategy
    {
        private readonly PedidoService _pedidoService;

        public ExecucaoStrategy(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        public void Executar()
        {
            var pedido = Pedido.GerarPedido();
            var result = _pedidoService.RealizarPagamento(pedido, Pagamento.GerarPagamento(pedido, TipoPagamento.CartaoCredito));
            Console.WriteLine(result.Status);
            Console.WriteLine("----------------------------------------");
            var result2 = _pedidoService.RealizarPagamento(pedido, Pagamento.GerarPagamento(pedido, TipoPagamento.Boleto));
            Console.WriteLine(result2.Status);
        }

       
    }
}
