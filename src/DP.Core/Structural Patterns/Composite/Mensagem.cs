using DP.Core.Structural_Patterns.Composite.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Composite
{
    public class Mensagem : IMessage
    {
        private readonly List<IMessage> _mensagens = new List<IMessage>();
        public Mensagem(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }



        public void AdicionarMensagemFilha(IMessage filha)
        {
            _mensagens.Add(filha);
        }

        public void AdicionarMensagemFilha(IEnumerable<IMessage> filhas)
        {
            _mensagens.AddRange(filhas);
        }
        public void ExibirMensagens(int prefix)
        {
            Console.WriteLine($"{new string('-', prefix)} {Nome}");
            foreach (var _mensagem in _mensagens)
            {
                _mensagem.ExibirMensagens(prefix + 2);
            }
        }

        
    }
}
