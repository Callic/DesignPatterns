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
    public class ProcessoTransacaoBoleto : ProcessoTransacaoBase<TransacaoBoleto>, IProcessoTransacao
    {
        public TransacaoInfo ProcessarTransacao(Transacao transacao)
        {
            var boleto = ValidarTipoTransacao(transacao);
            Simular(ref boleto);
            return new TransacaoInfo(boleto.TransacaoID, boleto.DataCriacao, boleto.Valor, boleto.TransacaoStatus);
        }
        private static void Simular(ref TransacaoBoleto transacaoBoleto)
        {
            if(transacaoBoleto.ValidadeBoleto < DateTime.Now)
            {
                transacaoBoleto.SetTransacaoNaoAutorizada();
                return;
            }
            transacaoBoleto.SetTransacaoAutorizada();

        }
    }
}
