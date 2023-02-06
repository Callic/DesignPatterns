using DP.Core.Creational_Patterns.Factory_Method.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Factory_Method.Manage.Base
{
    public abstract class ProcessoTransacaoBase<T> where T : Transacao
    {
        protected T ValidarTipoTransacao(Transacao transacao)
        {
            if (!(transacao is T)) throw new ArgumentException("Tipo de Transação inválido");
            return (T)transacao;
        }
        
    }
}
