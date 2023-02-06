using DP.Core.Creational_Patterns.Builder.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Builder.Builders.Base
{
    public interface ICarroBuilder
    {
        void FabricarChassi(string modelo);
        void FabricarPortas();
        void FabricarBancos();
    }
}
