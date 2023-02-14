using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Singleton.Exemplo_1
{
    public sealed class LoadBalancer
    {
        private static readonly LoadBalancer loadBalancer = new LoadBalancer();

        private Random random = new Random();
        private List<Server> servers;

        private LoadBalancer()
        {
            servers = new List<Server>
            {
                new Server {Name="Server 1"},
                new Server {Name="Server 2"},
                new Server {Name="Server 3"},
                new Server {Name="Server 4"},
            };
        }


        public static LoadBalancer GetLoadBalancer()
        {
            return loadBalancer;
        }


        public Server NextServer { 
            get 
            {
                var x = random.Next(servers.Count);
                return servers[x];
            } 
        }


    }
}
