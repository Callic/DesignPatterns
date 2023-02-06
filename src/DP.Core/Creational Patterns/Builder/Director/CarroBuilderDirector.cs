using DP.Core.Creational_Patterns.Builder.Builders.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Builder.Director
{
    public class CarroBuilderDirector
    {
       
        public void FabricarCarro(ICarroBuilder carroBuilder, string modelo)
        {
            carroBuilder.FabricarChassi(modelo);
            carroBuilder.FabricarPortas();
            carroBuilder.FabricarBancos();
        }
    }
}
