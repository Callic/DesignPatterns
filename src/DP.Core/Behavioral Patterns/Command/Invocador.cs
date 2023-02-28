namespace DP.Core.Behavioral_Patterns.Command
{
    public class Invocador
    {
        private readonly Calculadora _calculadora;
        private readonly List<ICommand> _commands= new List<ICommand>();
        private int _total;

        public Invocador(Calculadora calculadora)
        {
            _calculadora = calculadora;
            
        }

        public void Adicionar(char operador, int valor)
        {
            ICommand command = new CalculadoraCommand(operador, valor, _calculadora);
            command.Executar();

            _commands.Add(command);
            _total++;
        }
        public void Retornar(int niveis)
        {
            Console.WriteLine("\n---- Retornando {0} níveis ", niveis);

            for (var i = 0; i < niveis; i++)
            {
                if (_total >= _commands.Count - 1) continue;
                var command = _commands[_total++];
                command.Executar();
            }
        }

        public void Desfazer(int niveis)
        {
            Console.WriteLine("\n---- Desfazendo {0} níveis ", niveis);

            for (var i = 0; i < niveis; i++)
            {
                if (_total <= 0) continue;
                var command = _commands[--_total];
                command.Desfazer();
            }
        }
    }
}
