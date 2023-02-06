using DP.Core.Creational_Patterns.Builder.Builders.Base;
using DP.Core.Creational_Patterns.Builder.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Builder.Builders
{
    public sealed class CarroPeruaBuilder : CarroBuilder, ICarroBuilder
    {
        public void FabricarBancos()
        {
            this.Carro.QtdBancos = 7;
        }

        public void FabricarChassi(string modelo)
        {
            this.Init();
            this.Carro.TipoCarro = TipoCarro.Perua;
            this.Carro.Modelo= modelo;
        }

        public void FabricarPortas()
        {
            this.Carro.QtdPortas = 3;
        }
    }
}
