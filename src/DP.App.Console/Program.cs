

using DP.Core.Creational_Patterns.Abstract_Factory;
using DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2;
using DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Abstracts;
using DP.Core.Creational_Patterns.Abstract_Factory.Interfaces;


HandleMobilia();
WriteLine(3);
HandleVeiculo();
Console.ReadKey();




static void HandleVeiculo()
{
    var factory = new VeiculoFactory();
    factory.CriarVeiculo(Porte.Pequeno);
    factory.CriarVeiculo(Porte.Medio);
    factory.CriarVeiculo(Porte.Grande);
};


static void HandleMobilia()
{
    Console.WriteLine("######  Mobilia Vitoriana ######");
    CriarMobilia(new MobiliaVitorianaFactory());


    Console.WriteLine("######  Mobilia Moderna ######");
    CriarMobilia(new MobiliaModernaFactory());
}

static void CriarMobilia(IMobiliaFactory _mobiliaFactory)
{
    var mesa = _mobiliaFactory.CriarMesa();
    var cadeira = _mobiliaFactory.CriarCadeira();
}


static void WriteLine(int linhas, string texto = "")
{
    for (int i = 0; i < linhas; i++)
    {
        Console.WriteLine(texto);
    }
}

