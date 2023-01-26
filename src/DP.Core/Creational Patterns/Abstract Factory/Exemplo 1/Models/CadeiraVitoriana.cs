using DP.Core.Creational_Patterns.Abstract_Factory.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Abstract_Factory.Models
{
    public class CadeiraVitoriana : ICadeira
    {
        public CadeiraVitoriana()
        {

            Console.WriteLine("Cadeira Vitoriana Criada");
        }
    }
}
