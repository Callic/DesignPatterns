using DP.Core.Creational_Patterns.Factory_Method.Domain;
using DP.Core.Creational_Patterns.Factory_Method.Domain.Base;
using DP.Core.Creational_Patterns.Factory_Method.Manage.Base;
using DP.Core.Creational_Patterns.Factory_Method.Manage.Interfaces;

namespace DP.Core.Creational_Patterns.Factory_Method.Manage
{
    public class ProcessoTransacaoCartaoCredito : ProcessoTransacaoBase<TransacaoCartaoCredito>, IProcessoTransacao
    {
        public TransacaoInfo ProcessarTransacao(Transacao transacao)
        {
            var transacaoCartaoCredito =  ValidarTipoTransacao(transacao);
            Simulacao(ref transacaoCartaoCredito);
            return new TransacaoInfo(transacaoCartaoCredito.TransacaoID, transacaoCartaoCredito.DataCriacao, transacaoCartaoCredito.Valor, transacaoCartaoCredito.TransacaoStatus);
        }

        private static void Simulacao(ref TransacaoCartaoCredito transacao)
        {
            if (transacao.Valor > 0 && transacao.Valor < 10000)
            {
                transacao.SetTransacaoAutorizada();
                return;
            }
            transacao.SetTransacaoNaoAutorizada();
        }
    }
}
