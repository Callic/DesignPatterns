using DP.Core.Creational_Patterns.Factory_Method.Domain.ValueObj;
using DP.Core.Creational_Patterns.Factory_Method.Manage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Factory_Method.Manage.Factory
{
    public static class ProcessoTransacaoFactory
    {

        /// <summary>
        /// FACTORY METHOD
        /// </summary>
        /// <param name="transacaoTipo"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static IProcessoTransacao CriarProcessoTransacao(TransacaoTipo transacaoTipo)
        {
            switch (transacaoTipo)
            {
                case TransacaoTipo.CartaoCredito:
                    return new ProcessoTransacaoCartaoCredito();
                case TransacaoTipo.CartaoDebito:
                    return new ProcessoTransacaoCartaoDebito();
                case TransacaoTipo.Boleto:
                    return new ProcessoTransacaoBoleto();
                default:
                    throw new ArgumentException("Tipo de transação não reconhecido");
            }
        }
    }
}
