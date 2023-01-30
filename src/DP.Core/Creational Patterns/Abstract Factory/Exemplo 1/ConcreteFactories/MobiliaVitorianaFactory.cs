using DP.Core.Creational_Patterns.Abstract_Factory.Interfaces;
using DP.Core.Creational_Patterns.Abstract_Factory.Model.Interfaces;
using DP.Core.Creational_Patterns.Abstract_Factory.Models;
using DP.Core.Creational_Patterns.Abstract_Factory.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Abstract_Factory
{
    public class MobiliaVitorianaFactory : IMobiliaFactory
    {
        public ICadeira CriarCadeira()
        {
            return new CadeiraVitoriana();
        }
        public IMesa CriarMesa()
        {
            return new MesaVitoriana();
        }

    }
}
