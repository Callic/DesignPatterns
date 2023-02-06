using DP.Core.Creational_Patterns.Factory_Method.Domain;
using DP.Core.Creational_Patterns.Factory_Method.Domain.ValueObj;
using DP.Core.Creational_Patterns.Factory_Method.Manage.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.App.Console.Services.Factory_Method
{
    public static class HandleProcessoTransacao
    {
        public static void SimularProcessoTransacao()
        {
            MontarTransacaoCredito();
            MontarTransacaoDebito();
            MontarTransacaoBoleto();
        }


        private static void MontarTransacaoCredito()
        {
            System.Console.WriteLine("################ TRANSAÇÃO CARTÃO DE CRÉDITO ################");
            var processarTransacaoCC = ProcessoTransacaoFactory.CriarProcessoTransacao(TransacaoTipo.CartaoCredito);

            var transacaoCC = new TransacaoCartaoCredito(10.51, "Gustavo Miranda", 222, "12345678911");

            var transInfo = processarTransacaoCC.ProcessarTransacao(transacaoCC);
            System.Console.WriteLine(transInfo.ToString());

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

        }

        private static void MontarTransacaoDebito()
        {
            System.Console.WriteLine("################ TRANSAÇÃO CARTÃO DE DÉBITO ################");
            var processarTransacaoCD = ProcessoTransacaoFactory.CriarProcessoTransacao(TransacaoTipo.CartaoDebito);

            var transacaoCD = new TransacaoCartaoDebito(10.51);

            var transInfo = processarTransacaoCD.ProcessarTransacao(transacaoCD);
            System.Console.WriteLine(transInfo.ToString());

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

        }

        private static void MontarTransacaoBoleto()
        {
            System.Console.WriteLine("################ TRANSAÇÃO CARTÃO DE BOLETO ################");
            var processarTransacaoBoleto = ProcessoTransacaoFactory.CriarProcessoTransacao(TransacaoTipo.Boleto);

            var transacaoBoelto = new TransacaoBoleto(10.51, "45645645612312313", DateTime.Now.AddDays(-10));

            var transInfo = processarTransacaoBoleto.ProcessarTransacao(transacaoBoelto);
            System.Console.WriteLine(transInfo.ToString());

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

        }

    }
}
