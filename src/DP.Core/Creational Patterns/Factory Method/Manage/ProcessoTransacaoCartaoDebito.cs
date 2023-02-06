using DP.Core.Creational_Patterns.Factory_Method.Domain;
using DP.Core.Creational_Patterns.Factory_Method.Domain.Base;
using DP.Core.Creational_Patterns.Factory_Method.Manage.Base;
using DP.Core.Creational_Patterns.Factory_Method.Manage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Factory_Method.Manage
{
    public class ProcessoTransacaoCartaoDebito : ProcessoTransacaoBase<TransacaoCartaoDebito>, IProcessoTransacao
    {
        public TransacaoInfo ProcessarTransacao(Transacao transacao)
        {
            var transacaoCartaoDebito = ValidarTipoTransacao(transacao);
            Simular(ref transacaoCartaoDebito);

            return new TransacaoInfo(transacaoCartaoDebito.TransacaoID, transacaoCartaoDebito.DataCriacao, transacaoCartaoDebito.Valor, transacaoCartaoDebito.TransacaoStatus);
        }
        private static void Simular(ref TransacaoCartaoDebito transacaoCartaoDebito)
        {
            if(transacaoCartaoDebito.Valor > 0 && transacaoCartaoDebito.Valor <= 1000)
            {
                transacaoCartaoDebito.SetTransacaoAutorizada();
                return;
            }
            transacaoCartaoDebito.SetTransacaoNaoAutorizada();
        }
    }
}
