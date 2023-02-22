using DP.Core.Structural_Patterns.Composite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Composite
{
    public class ExecucaoComposite
    {
        public void Executar()
        {
            var validaoCadastro = new Mensagem("O cadastro nao foi realizado!");
            var falhaValidacaoCadastro = new Mensagem("Os seguintes campos estão errados:");
            
            validaoCadastro.AdicionarMensagemFilha(falhaValidacaoCadastro);

            var filhaFalhaValidacaoCadastro = new ValidateFormMessage("O campo nome deve conter no mínimo 3 caracteres");
            var filha2FalhaValidacaoCadastro = new ValidateFormMessage("O campo Data deve ser preenchido");

            falhaValidacaoCadastro.AdicionarMensagemFilha(new List<IMessage> { filhaFalhaValidacaoCadastro, filha2FalhaValidacaoCadastro});


            var falhaValidacaoDominio = new Mensagem("Problemas ao processar o cadastro do usuário");

            validaoCadastro.AdicionarMensagemFilha(falhaValidacaoDominio);

            var filhaFalhaValidacaoDomain = new ValidateFormMessage("O CPF informado já está em uso");
            var filha2FalhaValidacaoDomain = new ValidateFormMessage("E-mail informado já está em uso");

            falhaValidacaoDominio.AdicionarMensagemFilha(new List<IMessage> { filhaFalhaValidacaoDomain, filha2FalhaValidacaoDomain });

            validaoCadastro.ExibirMensagens(2);

        }
    }
}
