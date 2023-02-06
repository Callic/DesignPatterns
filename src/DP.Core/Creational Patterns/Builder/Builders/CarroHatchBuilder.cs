using DP.Core.Creational_Patterns.Builder.Builders.Base;
using DP.Core.Creational_Patterns.Builder.Domain.ValueObject;

namespace DP.Core.Creational_Patterns.Builder.Builders
{
    public sealed class CarroHatchBuilder : CarroBuilder, ICarroBuilder
    {
        public void FabricarBancos()
        {
            this.Carro.QtdBancos = 4;
        }

        public void FabricarChassi(string modelo)
        {
            this.Init();
            this.Carro.Modelo = modelo;
            this.Carro.TipoCarro = TipoCarro.Hatch;
        }

        public void FabricarPortas()
        {
            this.Carro.QtdPortas = 4;
        }
    }
}
