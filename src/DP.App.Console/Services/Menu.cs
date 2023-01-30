using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.App.Console.Services
{
    public static class Menu 
    {
        public static void Menus()
        {
            WriteLine("###### Selecione uma opção #####");
            WriteLine("Creational Patterns");
            WriteLine(new string[] { "1 - Abstract Factory", "2 - Factory Method", "3 - Singleton" });
            System.Console.Write("Selecione uma opção: ");
            WriteLine("Exemplo: Opção: 1", 1, ConsoleColor.Green);
            var escolha = System.Console.ReadLine();
            HandleOpcao(escolha!);
        }

        public static void WriteLine(string texto = "", int linhas = 1, System.ConsoleColor corTexto = System.ConsoleColor.White)
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
        private static void HandleOpcao(string escolha)
        {
            switch (escolha.Trim())
            {
                case "1":
                    VeiculoCreator.HandleVeiculo();
                    break;
                case "2":
                    MobiliaCreator.HandleMobilia();
                    break;
                default:
                    System.Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
