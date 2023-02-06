using DP.Core.Creational_Patterns.Factory_Method.Domain.Base;
using DP.Core.Creational_Patterns.Factory_Method.Domain.ValueObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Factory_Method.Domain
{
    public sealed class TransacaoBoleto : Transacao
    {
        public string CodigoBarras { get; }
        public DateTime ValidadeBoleto { get; }
        public TransacaoBoleto(double transacaoValor, string codigoBarras, DateTime validadeBoleto) : base(TransacaoTipo.Boleto, transacaoValor)
        {
            CodigoBarras = codigoBarras;
            ValidadeBoleto = validadeBoleto;
        }
    }
}
