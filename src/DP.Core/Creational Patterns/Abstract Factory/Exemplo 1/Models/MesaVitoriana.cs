using DP.Core.Creational_Patterns.Abstract_Factory.Models.Interfaces;

namespace DP.Core.Creational_Patterns.Abstract_Factory.Models
{
    public class MesaVitoriana : IMesa
    {
        public MesaVitoriana()
        {
            Console.WriteLine("Mesa Vitoriana Ocupada");
        }
    }
}
