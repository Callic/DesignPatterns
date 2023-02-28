
namespace DP.Core.Behavioral_Patterns.Command
{
    public class CalculadoraCommand : ICommand
    {
        private char _operador;
        private int _valor;
        private readonly Calculadora _calculadora;
        public CalculadoraCommand(char operador, int valor, Calculadora calculadora)
        {
            _operador = operador;
            _valor = valor;
            _calculadora = calculadora;
        }
        public void Executar()
        {
            _calculadora.Operacao(_operador, _valor);
        }
        public void Desfazer()
        {
            _calculadora.Operacao(Desfazer(_operador), _valor);
        }

        private char Desfazer(char operador)
        {
            switch (operador)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Operador inválido");
            }
        }

    }
}
