using DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Abstracts;

namespace DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Interfaces
{
    public interface IVeiculoFactory
    {
        Veiculo CriarVeiculo(Porte porte);
    }
}
