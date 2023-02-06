using DP.Core.Creational_Patterns.Factory_Method.Domain;
using DP.Core.Creational_Patterns.Factory_Method.Domain.Base;

namespace DP.Core.Creational_Patterns.Factory_Method.Manage.Interfaces
{
    public interface IProcessoTransacao
    {
        TransacaoInfo ProcessarTransacao(Transacao transacao);
    }
}
