using System;
using System.Collections.Generic;
using System.Text;

namespace Wc.ToasterWebforms
{
    public class Toaster : IToaster
    {
        /// <summary>
        /// Adiciona uma mensagem Toaster. Baseado na Biblioteca Jquery Toast Plugin
        /// https://kamranahmed.info/toast#quick-demos
        /// </summary>
        /// <param name="titulo"> Propriedade: {heading} Titulo da mensagem.</param>
        public string AdicionarMensagemToaster(string titulo)
        {
            var sb = new StringBuilder();
            sb.Append("$(document).ready(function () {$.toast({" +
                            "heading:'" + titulo +"'});" +
                      "});");
            return sb.ToString();
        }

        /// <summary>
        /// Adiciona uma mensagem Toaster. Baseado na Biblioteca Jquery Toast Plugin
        /// https://kamranahmed.info/toast#quick-demos
        /// </summary>
        /// <param name="titulo">Propriedade: {heading} - Título da mensagem</param>
        /// <param name="mensagem">Propriedade: {text} - Mensagem do corpo do Toaster.</param>
        /// <param name="icone">Propriedade: {icon} - Define o ícone e cor do Toast use: info, warning, error, success</param>
        public string AdicionarMensagemToaster(string titulo, string mensagem, string icone)
        {
            var sb = new StringBuilder();
            sb.Append("$(document).ready(function () {$.toast({" +
                      "heading:'" + titulo + "'," +
                      "text:'" + mensagem + "'," +
                      "icone:'" + icone +"'});" +
                      "});");
            return sb.ToString();
        }

        /// <summary>
        /// Adiciona uma mensagem Toaster. Baseado na Biblioteca Jquery Toast Plugin
        /// https://kamranahmed.info/toast#quick-demos
        /// </summary>
        /// <param name="titulo">Propriedade: {heading} - Título da mensagem</param>
        /// <param name="mensagem">Propriedade: {text} - Mensagem do corpo do Toaster.</param>
        /// <param name="icone">Propriedade: {icon} - Define o ícone e cor do Toast use: info, warning, error, success</param>
        /// <param name="posicao">Propriedade: {position} - Define posição da mensagem, use: bottom-left or bottom-right or bottom-center or top-left or top-right or top-center or mid-center or an object representing the left, right, top, bottom</param>
        /// <param name="tempoExibicaoMilisegundos">Propriedade: {hideAfter} - Define o tempo de exibição do Toast</param>
        public string AdicionarMensagemToaster(string titulo, string mensagem, string icone, string posicao, int tempoExibicaoMilisegundos)
        {
            var sb = new StringBuilder();
            sb.Append("$(document).ready(function () {$.toast({" +
                      "heading:'" + titulo + "'," +
                      "text:'" + mensagem + "'," +
                      "icon:'" + icone + "'," +
                      "position:'" + posicao + "'," +
                      "hideAfter:" + tempoExibicaoMilisegundos + "});" +
                      "});");
            return sb.ToString();
        }

        /// <summary>
        /// Adiciona uma mensagem Toaster. Baseado na Biblioteca Jquery Toast Plugin
        /// https://kamranahmed.info/toast#quick-demos
        /// </summary>
        /// <param name="titulo">Propriedade: {heading} - Título da mensagem</param>
        /// <param name="mensagem">Propriedade: {text} - Mensagem do corpo do Toaster.</param>
        /// <param name="icone">Propriedade: {icon} - Define o ícone e cor do Toast use: info, warning, error, success</param>
        /// <param name="posicao">Propriedade: {position} - Define posição da mensagem, use: bottom-left or bottom-right or bottom-center or top-left or top-right or top-center or mid-center or an object representing the left, right, top, bottom</param>
        /// <param name="tempoExibicaoMilisegundos">Propriedade: {hideAfter} - Define o tempo de exibição do Toast</param>
        /// <param name="exibirLoader">Propriedade: {loader} - Exibi o loader do tempo de exibição, use: true ou false</param>
        /// <param name="corLoader">Propriedade: {loaderBg} - Define a cor do loader exemplo: "#9EC600"</param>

        public string AdicionarMensagemToaster(string titulo, string mensagem, string icone, string posicao,
            int tempoExibicaoMilisegundos, bool exibirLoader, string corLoader)
        {
            var sb = new StringBuilder();
            sb.Append("$(document).ready(function () {$.toast({" +
                      "heading:'" + titulo + "'," +
                      "text:'" + mensagem + "'," +
                      "icon:'" + icone + "'," +
                      "position:'" + posicao + "'," +
                      "hideAfter:" + tempoExibicaoMilisegundos + "," +
                      "loader:" + exibirLoader + "," +
                      "loaderBg:'" + corLoader + "'});" +
                      "});");
            return sb.ToString();
        }

        /// <summary>
        /// Adiciona uma mensagem Toaster. Baseado na Biblioteca Jquery Toast Plugin
        /// https://kamranahmed.info/toast#quick-demos
        /// </summary>
        /// <param name="titulo">Propriedade: {heading} - Título da mensagem</param>
        /// <param name="mensagem">Propriedade: {text} - Mensagem do corpo do Toaster.</param>
        /// <param name="icone">Propriedade: {icon} - Define o ícone e cor do Toast use: info, warning, error, success</param>
        /// <param name="posicao">Propriedade: {position} - Define posição da mensagem, use: bottom-left or bottom-right or bottom-center or top-left or top-right or top-center or mid-center or an object representing the left, right, top, bottom</param>
        /// <param name="tempoExibicaoMilisegundos">Propriedade: {hideAfter} - Define o tempo de exibição do Toast</param>
        /// <param name="exibirLoader">Propriedade: {loader} - Exibi o loader do tempo de exibição, use: true ou false</param>
        /// <param name="corLoader">Propriedade: {} - Define a cor do loader exemplo: "#9EC600"</param>
        /// <param name="alinhamentoTexto">Propriedade: {textAlign} - Define alinhamento do texto, use: left, right ou center</param>

        public string AdicionarMensagemToaster(string titulo, string mensagem, string icone, string posicao,
            int tempoExibicaoMilisegundos, bool exibirLoader, string corLoader, string alinhamentoTexto)
        {
            var sb = new StringBuilder();
            sb.Append("$(document).ready(function () {$.toast({" +
                      "heading:'" + titulo + "'," +
                      "text:'" + mensagem + "'," +
                      "icon:'" + icone + "'," +
                      "position:'" + posicao + "'," +
                      "hideAfter:" + tempoExibicaoMilisegundos + "," +
                      "loader:" + exibirLoader + "," +
                      "loaderBg:'" + corLoader + "'," +
                      "textAlign:'" + alinhamentoTexto + "'});" +
                      "});");
            return sb.ToString();
        }

        /// <summary>
        /// Adiciona uma mensagem Toaster. Baseado na Biblioteca Jquery Toast Plugin
        /// https://kamranahmed.info/toast#quick-demos
        /// </summary>
        /// <param name="titulo">Propriedade: {heading} - Título da mensagem</param>
        /// <param name="mensagem">Propriedade: {text} - Mensagem do corpo do Toaster.</param>
        /// <param name="icone">Propriedade: {icon} - Define o ícone e cor do Toast use: info, warning, error, success</param>
        /// <param name="posicao">Propriedade: {position} - Define posição da mensagem, use: bottom-left or bottom-right or bottom-center or top-left or top-right or top-center or mid-center or an object representing the left, right, top, bottom</param>
        /// <param name="tempoExibicaoMilisegundos">Propriedade: {hideAfter} - Define o tempo de exibição do Toast</param>
        /// <param name="exibirLoader">Propriedade: {loader} - Exibi o loader do tempo de exibição, use: true ou false</param>
        /// <param name="corLoader">Propriedade: {loaderBg} - Define a cor do loader exemplo: "#9EC600"</param>
        /// <param name="alinhamentoTexto">Propriedade: {textAlign} - Define alinhamento do texto, use: left, right ou center</param>
        /// <param name="permitirFecharToast">Propriedade: {allowToastClose} - Permissao de fechar o Toast, use: true ou false</param>
        /// <param name="maximoToastAbertoComEste">Propriedade: {stack} - Número que representando o máximo de toast abertos com este</param>

        public string AdicionarMensagemToaster(string titulo, string mensagem, string icone, string posicao,
            int tempoExibicaoMilisegundos, bool exibirLoader, string corLoader, string alinhamentoTexto,
            bool permitirFecharToast, int maximoToastAbertoComEste)
        {
            var sb = new StringBuilder();
            sb.Append("$(document).ready(function () {$.toast({" +
                      "heading:'" + titulo + "'," +
                      "text:'" + mensagem + "'," +
                      "icon:'" + icone + "'," +
                      "position:'" + posicao + "'," +
                      "hideAfter:" + tempoExibicaoMilisegundos + "," +
                      "loader:" + exibirLoader + "," +
                      "loaderBg:'" + corLoader + "'," +
                      "textAlign:'" + alinhamentoTexto + "'," +
                      "allowToastClose:" + permitirFecharToast + "," +
                      "stack:" + maximoToastAbertoComEste + "});" +
                      "});");
            return sb.ToString();
        }

    }
}
