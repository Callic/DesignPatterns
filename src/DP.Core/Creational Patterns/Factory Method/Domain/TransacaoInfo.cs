using DP.Core.Creational_Patterns.Factory_Method.Domain.ValueObj;
using DP.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Factory_Method.Domain
{
    public class TransacaoInfo
    {
        public Guid TransacaoID { get; }
        public DateTime TransacaoData { get; }
        public double Valor { get; }
        public TransacaoStatus TransacaoStatus { get; }

        public TransacaoInfo(Guid transacaoID, DateTime transacaoData, double valor, TransacaoStatus transacaoStatus)
        {
            TransacaoID = transacaoID;
            TransacaoData = transacaoData;
            Valor = valor;
            TransacaoStatus = transacaoStatus;
        }
        public override string ToString()
        {
            return @$"Transação ID: {this.TransacaoID}
                        Data da transação: {this.TransacaoData}
                        Status da transação: {this.TransacaoStatus.GetDescription()}
                        Valor: {this.Valor}";
        }
    }
}
