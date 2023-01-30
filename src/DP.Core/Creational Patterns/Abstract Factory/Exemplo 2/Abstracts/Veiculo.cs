using DP.Core.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Creational_Patterns.Abstract_Factory.Exemplo_2.Abstracts
{
    public abstract class Veiculo
    {
        public string Modelo{ get; set; }
        public Porte Porte { get; set; }
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }
        public Veiculo(string modelo, Porte porte)
        {
            Modelo = modelo;
            Console.WriteLine($"Veiculo: {modelo} - Porte: {porte.GetDescription()}");
        }
    }

    public enum Porte
    {
        [Description("Pequeno")]
        Pequeno = 1,
        [Description("Médio")]
        Medio = 2,
        [Description("Grande")]
        Grande = 3,

        
    }
}
