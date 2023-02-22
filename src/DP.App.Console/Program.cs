using DP.App.Console.Configuration.DI;
using DP.App.Console.Services;
using Microsoft.Extensions.Configuration;


IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var serviceProvider = DependencyInjectionConfiguration.BuildServiceProvider(configuration);


while (true)
{
    Console.WriteLine("Teste imagem docker");
    Menu.Menus(serviceProvider);
    Console.WriteLine("Pressione qualquer tecla!");
    Console.ReadKey();
    Console.Clear();
}