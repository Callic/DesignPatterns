using DP.Core.Structural_Patterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Composite
{
    public class ValidateFormMessage : IMessage
    {
        public string Nome { get; private set; }

        public ValidateFormMessage(string nome)
        {
            Nome = nome;
        }

        public void ExibirMensagens(int prefix)
        {
            Console.WriteLine($"{new string('-', prefix)} {Nome}");
        }
    }
}
