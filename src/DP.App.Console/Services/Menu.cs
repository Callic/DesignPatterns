using DP.App.Console.Services.Factory_Method;
using DP.Core.Creational_Patterns.Builder.Builders;
using DP.Core.Creational_Patterns.Builder.Builders.Base;
using DP.Core.Creational_Patterns.Builder.Director;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.App.Console.Services
{
    public static class Menu 
    {
        public static void Menus(IServiceProvider serviceProvider)
        {
            WriteLine("###### Selecione uma opção #####");


            MenuCreationalPatterns();


            System.Console.Write("Selecione uma opção: ");
            WriteLine("Exemplo: Opção: 1", 1, ConsoleColor.Green);
            var escolha = System.Console.ReadLine();
            HandleOpcao(escolha!, serviceProvider);
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
                    carroDirector.FabricarCarro(carroBuilder, "Jaguar");
                    var carro = carroBuilder.BuscarCarro();
                    WriteLine(carro.Modelo);
                    break;
                default:
                    System.Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        private static void MenuCreationalPatterns()
        {
            
            WriteLine("Creational Patterns");
            WriteLine(new string[] { "1 - Abstract Factory", "2 - Factory Method", "3 - Builder" });
        }
    }
}
