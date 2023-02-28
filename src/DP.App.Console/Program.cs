using DP.App.Console.Configuration.DI;
using DP.App.Console.Services;
using Microsoft.Extensions.Configuration;


IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var serviceProvider = DependencyInjectionConfiguration.BuildServiceProvider(configuration);

string opcao = "";
do
{
    Console.WriteLine("Teste imagem docker");
    opcao = Menu.Menus(serviceProvider);
    if(opcao is not "0")
    {
        Console.WriteLine("Pressione qualquer tecla para reiniciar os exemplos!");
        Console.ReadKey();
        Console.Clear();
    }
} while (opcao != "0");

