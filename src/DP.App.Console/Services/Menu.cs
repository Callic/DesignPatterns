using DP.App.Console.Services.Factory_Method;
using DP.Core.Behavioral_Patterns.Command;
using DP.Core.Behavioral_Patterns.Strategy;
using DP.Core.Creational_Patterns.Builder.Builders;
using DP.Core.Creational_Patterns.Builder.Director;
using DP.Core.Creational_Patterns.Singleton.Exemplo_1;
using DP.Core.Structural_Patterns.Adapter;
using DP.Core.Structural_Patterns.Adapter.Exemplo_1;
using DP.Core.Structural_Patterns.Composite;
using DP.Core.Structural_Patterns.Facade.Exemplo_1;
using Microsoft.Extensions.DependencyInjection;


namespace DP.App.Console.Services
{
    public static class Menu
    {
        public static string Menus(IServiceProvider serviceProvider)
        {
            WriteLine("Para sair, digite 0", 1, ConsoleColor.Red);

            WriteLine("###### Selecione uma opção #####");

            MenuManage();

            System.Console.Write("Selecione uma opção: ");
            var escolha = System.Console.ReadLine();
            if(escolha is not "0")
                HandleOpcao(escolha!, serviceProvider);
            return escolha;
        }


        private static void HandleOpcao(string escolha, IServiceProvider service)
        {
            switch (escolha.Trim())
            {
                case "1":
                    VeiculoCreator.HandleVeiculo();
                    break;
                case "2":
                    HandleProcessoTransacao.SimularProcessoTransacao();
                    break;
                case "3":
                    var carroBuilder = service.GetService<CarroEsportivoBuilder>();
                    var carroDirector = service.GetService<CarroBuilderDirector>();
                    carroDirector!.FabricarCarro(carroBuilder!, "Jaguar");
                    var carro = carroBuilder!.BuscarCarro();
                    WriteLine(carro.Modelo);
                    break;
                case "4":
                    SingletonEx1.Executar();
                    break;
                case "5":
                    var adapter = service.GetService<IAdapter<AdapterEx1>>();
                    adapter!.Executar();
                    break;
                case "6":
                    var facade = service.GetService<ExecucaoFacade>();
                    facade!.Executar();
                    break;
                case "7":
                    var composite = service.GetService<ExecucaoComposite>();
                    composite!.Executar();
                    break;
                case "8":
                    var commander = service.GetService<ExecucaoCommand>();
                    commander!.Executar();
                    break;
                case "9":
                    var strategy = service.GetService<ExecucaoStrategy>();
                    strategy!.Executar();
                    break;
                default:
                    System.Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        private static void MenuManage()
        {
            CreationalPatternsMenu();
            StructuralPatternsMenu();
            BehaviorPatternsMenu();
        }

        private static void CreationalPatternsMenu()
        {

            WriteLine("> Creational Patterns", 1, ConsoleColor.Cyan);
            WriteLine(new string[] { "1 - Abstract Factory", "2 - Factory Method", "3 - Builder", "4 - Singleton" });
        }
        private static void StructuralPatternsMenu()
        {
            WriteLine("> Structural Patterns", 1, ConsoleColor.Cyan);
            WriteLine(new string[] { "5 - Adapter", "6 - Facade", "7 - Composite" });
        }
        private static void BehaviorPatternsMenu()
        {
            WriteLine("> Behavior Patterns", 1, ConsoleColor.Cyan);
            WriteLine(new string[] { "8 - Command", "9 - Strategy" });
        }
        public static void WriteLine(string texto, int linhas = 1, System.ConsoleColor corTexto = System.ConsoleColor.White)
        {
            for (int i = 0; i < linhas; i++)
            {
                System.Console.ForegroundColor = corTexto;
                System.Console.WriteLine(texto);
                System.Console.ResetColor();
            }
        }

        public static void WriteLine(string[] textos, int linhas = 1)
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < textos.Length; j++)
                {
                    WriteLine(textos[j]);
                }
            }
        }
    }
}
