using DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Abstracts;

namespace DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Services
{
    public class VeiculoMedio : Veiculo
    {
        public VeiculoMedio(string modelo) : base(modelo, Porte.Medio)
        {
        }
    }
}
