using System;
using System.Collections.Generic;
using System.Text;

namespace Wc.ToasterWebforms
{
    public class Toaster : IToaster
    {
        /// <summary>
        /// <para>MENSAGEM TOAST</para>
        /// <para>Baseado na Biblioteca Jquery Toast Plugin</para>
        /// <para>https://kamranahmed.info/toast#quick-demos</para>
        /// </summary>
        /// <param name="titulo"> ToastJs: {heading} - string: Titulo da mensagem.</param>
        /// <returns>Retorna string javascript do Toast</returns>  
        public string AdicionarMensagemToaster(string titulo)
        {
            var sb = new StringBuilder();
            sb.Append("$(document).ready(function () {$.toast({" +
                            "heading:'" + titulo +"'});" +
                      "});");
            return sb.ToString();
        }

        /// <summary>
        /// <para>MENSAGEM TOAST</para>
        /// <para>Baseado na Biblioteca Jquery Toast Plugin</para>
        /// <para>https://kamranahmed.info/toast#quick-demos</para>
        /// </summary>
        /// <param name="titulo"> ToastJs: {heading} - string: Titulo da mensagem.</param>
        /// <param name="mensagem">ToastJs: {text} - string: Mensagem do corpo do Toaster.</param>
        /// <param name="icone">ToastJs: {icon} - string: info, warning, error, success</param>
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
        /// <para>MENSAGEM TOAST</para>
        /// <para>Baseado na Biblioteca Jquery Toast Plugin</para>
        /// <para>https://kamranahmed.info/toast#quick-demos</para>
        /// </summary>
        /// <param name="titulo"> ToastJs: {heading} - string: Titulo da mensagem.</param>
        /// <param name="mensagem">ToastJs: {text} - string: Mensagem do corpo do Toaster.</param>
        /// <param name="icone">ToastJs: {icon} - string: info ou warning ou error ou success</param>
        /// <param name="posicao">ToastJs: {position} - string: bottom-left ou bottom-right ou bottom-center ou top-left ou top-right ou top-center ou mid-center ou an object representing the left, right, top, bottom</param>
        /// <param name="tempoExibicaoMilisegundos">ToastJs: {hideAfter} - int: tempo de exibição do Toast</param>
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
        /// <para>MENSAGEM TOAST</para>
        /// <para>Baseado na Biblioteca Jquery Toast Plugin</para>
        /// <para>https://kamranahmed.info/toast#quick-demos</para>
        /// </summary>
        /// <param name="titulo"> ToastJs: {heading} - string: Titulo da mensagem.</param>
        /// <param name="mensagem">ToastJs: {text} - string: Mensagem do corpo do Toaster.</param>
        /// <param name="icone">ToastJs: {icon} - string: info ou warning ou error ou success</param>
        /// <param name="posicao">ToastJs: {position} - string: bottom-left ou bottom-right ou bottom-center ou top-left ou top-right ou top-center ou mid-center ou an object representing the left, right, top, bottom</param>
        /// <param name="tempoExibicaoMilisegundos">ToastJs: {hideAfter} - int: tempo de exibição do Toast</param>
        /// <param name="exibirLoader">ToastJs: {loader} - bool: true ou false</param>
        /// <param name="corLoader">ToastJs: {loaderBg} - string: exemplo "#9EC600"ou info ou warning ou error ou success</param>

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
        /// <para>MENSAGEM TOAST</para>
        /// <para>Baseado na Biblioteca Jquery Toast Plugin</para>
        /// <para>https://kamranahmed.info/toast#quick-demos</para>
        /// </summary>
        /// <param name="titulo"> ToastJs: {heading} - string: Titulo da mensagem.</param>
        /// <param name="mensagem">ToastJs: {text} - string: Mensagem do corpo do Toaster.</param>
        /// <param name="icone">ToastJs: {icon} - string: info ou warning ou error ou success</param>
        /// <param name="posicao">ToastJs: {position} - string: bottom-left ou bottom-right ou bottom-center ou top-left ou top-right ou top-center ou mid-center ou an object representing the left, right, top, bottom</param>
        /// <param name="tempoExibicaoMilisegundos">ToastJs: {hideAfter} - int: tempo de exibição do Toast</param>
        /// <param name="exibirLoader">ToastJs: {loader} - bool: true ou false</param>
        /// <param name="corLoader">ToastJs: {loaderBg} - string: exemplo "#9EC600"ou info ou warning ou error ou success</param>
        /// <param name="alinhamentoTexto">ToastJs: {textAlign} - string: left ou right ou center</param>

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
        /// <para>MENSAGEM TOAST</para>
        /// <para>Baseado na Biblioteca Jquery Toast Plugin</para>
        /// <para>https://kamranahmed.info/toast#quick-demos</para>
        /// </summary>
        /// <param name="titulo"> ToastJs: {heading} - string: Titulo da mensagem.</param>
        /// <param name="mensagem">ToastJs: {text} - string: Mensagem do corpo do Toaster.</param>
        /// <param name="icone">ToastJs: {icon} - string: info ou warning ou error ou success</param>
        /// <param name="posicao">ToastJs: {position} - string: bottom-left ou bottom-right ou bottom-center ou top-left ou top-right ou top-center ou mid-center ou an object representing the left, right, top, bottom</param>
        /// <param name="tempoExibicaoMilisegundos">ToastJs: {hideAfter} - int: tempo de exibição do Toast</param>
        /// <param name="exibirLoader">ToastJs: {loader} - bool: true ou false</param>
        /// <param name="corLoader">ToastJs: {loaderBg} - string: exemplo "#9EC600"ou info ou warning ou error ou success</param>
        /// <param name="alinhamentoTexto">ToastJs: {textAlign} - string: left ou right ou center</param>
        /// <param name="permitirFecharToast">ToastJs: {allowToastClose} - bool: true ou false</param>
        /// <param name="maximoToastAbertoComEste">ToastJs: {stack} - int: Número que representando o máximo de toast abertos com este</param>

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
