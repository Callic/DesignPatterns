

namespace DP.Core.Behavioral_Patterns.Command
{
    public class ExecucaoCommand
    {
        private readonly Invocador _invocador;
        
        public ExecucaoCommand(Invocador invocador)
        {
            this._invocador = invocador;
        }
        public void Executar()
        {
            _invocador.Adicionar('+', 100);
            Console.ReadKey();
            _invocador.Adicionar('-', 50);
            Console.ReadKey();
            _invocador.Adicionar('*', 10);
            Console.ReadKey();
            _invocador.Adicionar('/', 2);
            Console.ReadKey();

            _invocador.Desfazer(4);
            Console.ReadKey();

            _invocador.Retornar(3);

        }
    }
}
