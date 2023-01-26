using DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Abstracts;
using DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Interfaces;
using DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2
{
    public class VeiculoFactory : IVeiculoFactory
    {
        public Veiculo CriarVeiculo(Porte porte)
        {
            Veiculo veiculo;
            switch (porte)
            {
                case Porte.Pequeno:
                    veiculo = new VeiculoPequeno("Celta");
                    break;
                case Porte.Medio:
                    veiculo = new VeiculoMedio("Doblo");
                    break;
                case Porte.Grande:
                    veiculo = new VeiculoGrande("Jeep");
                    break;
                default:
                    throw new ArgumentException("Porte de veículo não encontrado.");
            }
            return veiculo;
        }
    }
}
