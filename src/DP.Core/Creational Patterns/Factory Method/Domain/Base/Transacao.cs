using DP.Core.Creational_Patterns.Factory_Method.Domain.ValueObj;

namespace DP.Core.Creational_Patterns.Factory_Method.Domain.Base
{
    public abstract class Transacao
    {
        public Guid TransacaoID { get; }
        public TransacaoTipo TransacaoTipo { get; }
        public TransacaoStatus TransacaoStatus { get; private set; }
        public double Valor { get; }
        public DateTime DataCriacao { get; }

        public Transacao(TransacaoTipo transacaoTipo, double transacaoValor)
        {
            TransacaoID = Guid.NewGuid();
            TransacaoTipo = transacaoTipo;
            Valor = transacaoValor;
            DataCriacao = DateTime.Now;
            TransacaoStatus = TransacaoStatus.EmProcesso;
        }
        public void SetTransacaoAutorizada()
        {
            TransacaoStatus = TransacaoStatus.Autorizada;
        }
        public void SetTransacaoNaoAutorizada()
        {
            TransacaoStatus = TransacaoStatus.NaoAutorizada;
        }
    }
}
