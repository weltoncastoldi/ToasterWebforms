using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Wc.ToasterWebforms
{
    public interface IToaster
    {

        string AdicionarMensagemToaster(string titulo);
        string AdicionarMensagemToaster(string titulo, string mensagem, string icone);
        string AdicionarMensagemToaster(string titulo, string mensagem, string icone, string posicao, int tempoExibicaoMilisegundos);
        string AdicionarMensagemToaster(string titulo, string mensagem, string icone, string posicao, int tempoExibicaoMilisegundos, bool exibirLoader, string corLoader);
        string AdicionarMensagemToaster(string titulo, string mensagem, string icone, string posicao, int tempoExibicaoMilisegundos, bool exibirLoader, string corLoader, string alinhamentoTexto);
        string AdicionarMensagemToaster(string titulo, string mensagem, string icone, string posicao, int tempoExibicaoMilisegundos, bool exibirLoader, string corLoader, string alinhamentoTexto, bool permitirFecharToast, int maximoToastAbertoComEste);

    }
}
