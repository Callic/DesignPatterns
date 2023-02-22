
using DP.Core.Structural_Patterns.Composite.Interfaces;

namespace DP.Core.Structural_Patterns.Composite
{
    public class DomainMessage : IMessage
    {
        public DomainMessage(string nome)
        {
            Nome = nome;
        }
        public string Nome {get; private set;}

        public void ExibirMensagens(int prefix)
        {
            Console.WriteLine($"{new string('-', prefix)} {Nome}");
        }
    }
}
