using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Factory_Method.Domain.ValueObj
{
    public enum TransacaoStatus
    {
        [Description("Autorizada")]
        Autorizada = 0,
        [Description("Não Autorizada")]
        NaoAutorizada = 1,
        [Description("Processando")]
        EmProcesso = 2,
    }
}
