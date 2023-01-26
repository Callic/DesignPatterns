using DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Abstracts;


namespace DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Services
{
    public class VeiculoPequeno : Veiculo
    {
        public VeiculoPequeno(string modelo) : base(modelo, Porte.Pequeno)
        {
        }
        
    }
}
