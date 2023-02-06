using DP.Core.Creational_Patterns.Builder.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Builder.Domain
{
    public class Carro
    {
        public string Modelo { get; set; }
        public TipoCarro TipoCarro { get; set; }
        public int QtdBancos { get; set; }
        public int QtdPortas { get; set; }
    }
}
