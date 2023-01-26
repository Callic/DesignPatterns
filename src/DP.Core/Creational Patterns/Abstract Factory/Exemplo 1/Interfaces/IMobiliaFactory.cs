using DP.Core.Creational_Patterns.Abstract_Factory.Model.Interfaces;
using DP.Core.Creational_Patterns.Abstract_Factory.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Abstract_Factory.Interfaces
{
    public interface IMobiliaFactory
    {
        IMesa CriarMesa();
        ICadeira CriarCadeira();

    }
}
