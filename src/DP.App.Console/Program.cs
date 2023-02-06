using DP.App.Console.Configuration.DI;
using DP.App.Console.Services;


var serviceProvider = DependencyInjectionConfiguration.BuscarServiceProvider();
while (true)
{
    Console.WriteLine("Teste imagem docker");
    Menu.Menus(serviceProvider);
    Console.WriteLine("Pressione qualquer tecla!");
    Console.ReadKey();
    Console.Clear();
}