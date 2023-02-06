using DP.Core.Creational_Patterns.Factory_Method.Domain.Base;
using DP.Core.Creational_Patterns.Factory_Method.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Factory_Method.Domain
{
    public class TransacaoCartaoCredito : Transacao
    {
        public string NomeCliente { get; }
        public int CodigoSeguranca { get; }
        public string NumeroCartao { get; }
        public TransacaoCartaoCredito(double transacaoValor, string nomeCliente, int codigoSeguranca, string numeroCartao) : base(TransacaoTipo.CartaoCredito, transacaoValor)
        {
            NomeCliente = nomeCliente;
            CodigoSeguranca = codigoSeguranca;
            NumeroCartao = numeroCartao;
        }
    }
}
