using DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2;
using DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Abstracts;

namespace DP.App.Console.Services
{
    public static class VeiculoCreator
    {
        public static void HandleVeiculo()
        {
            var factory = new VeiculoFactory();
            factory.CriarVeiculo(Porte.Pequeno);
            factory.CriarVeiculo(Porte.Medio);
            factory.CriarVeiculo(Porte.Grande);
        }
    }

}
