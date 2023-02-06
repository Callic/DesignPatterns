using DP.Core.Creational_Patterns.Builder.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Builder.Builders.Base
{
    public abstract class CarroBuilder
    {
        protected Carro Carro;
        protected void Init()
        {
            Carro = new Carro();
        }
        public Carro BuscarCarro()
        {
            return Carro;
        }
    }
}
