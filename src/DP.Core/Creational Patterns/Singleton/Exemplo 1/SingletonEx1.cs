using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Singleton.Exemplo_1
{
    public static class SingletonEx1
    {
        public static void Executar()
        {
            var s1 = LoadBalancer.GetLoadBalancer();
            var s2 = LoadBalancer.GetLoadBalancer();
            var s3 = LoadBalancer.GetLoadBalancer();
            var s4 = LoadBalancer.GetLoadBalancer();


            if(s1 == s2 && s2 == s3 && s3 == s4)
            {
                Console.WriteLine("Mesma instância");
            }
            for (int i = 0; i < 10; i++)
            {
                var name = s1.NextServer.Name;
                var id = s2.NextServer.Id;
                Console.WriteLine($"Servidor: {name},\nID: {id}");
            }
        }
    }
}
