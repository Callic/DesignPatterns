using DP.Core.Creational_Patterns.Abstract_Factory;
using DP.Core.Creational_Patterns.Abstract_Factory.Interfaces;

namespace DP.App.Console.Services
{
    public static class MobiliaCreator
    {
        
        public static void HandleMobilia()
        {
            System.Console.WriteLine("######  Mobilia Vitoriana ######");
            CriarMobilia(new MobiliaVitorianaFactory());


            System.Console.WriteLine("######  Mobilia Moderna ######");
            CriarMobilia(new MobiliaModernaFactory());
        }
        private static void CriarMobilia(IMobiliaFactory _mobiliaFactory)
        {
            _mobiliaFactory.CriarMesa();
            _mobiliaFactory.CriarCadeira();
        }
    }
}
