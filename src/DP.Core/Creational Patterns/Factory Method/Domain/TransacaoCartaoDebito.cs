using DP.Core.Creational_Patterns.Factory_Method.Domain.Base;
using DP.Core.Creational_Patterns.Factory_Method.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Factory_Method.Domain
{
    public class TransacaoCartaoDebito : Transacao
    {
        public TransacaoCartaoDebito(double transacaoValor) : base(TransacaoTipo.CartaoDebito, transacaoValor)
        {
        }
    }
}
