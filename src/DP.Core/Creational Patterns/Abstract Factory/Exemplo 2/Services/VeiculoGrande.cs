using DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Services
{
    public class VeiculoGrande : Veiculo
    {
        
        public VeiculoGrande(string modelo) : base(modelo, Porte.Grande)
        {
        }
    }
}
