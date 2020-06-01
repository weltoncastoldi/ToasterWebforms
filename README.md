# Toast for Webforms

Esta é uma biblioteca que permite controlar a exibição de mensages Toast pelo code-behind do asp.net webforms.

## Instalação

Use nuget package manager [ToastWebforms](https://www.nuget.org/packages/Wc.ToasterWebforms/) para instalar a biblitoeca.

```bash
Install-Package Wc.ToasterWebforms -Version 1.0.0.2
```

## Como usar

Primeiro você deverá baixar e referênciar as dependências Javascript [Jquery-Toast-Plugin](https://github.com/kamranahmedse/jquery-toast-plugin/) em seu projeto conforme o link.

Agora em seu código você poderá instanciar o ToasterWebforms da seguinte forma:

#### Code-behind

```c#
using Wc.ToasterWebforms

public partial class SuaPagina: Page
{
    private readonly Toaster _toaster = new Toaster();

    protected void Page_Load(object sender, EventArgs e)
    {
          if(txtQualquercoisa.Text == "")
          {

             ScriptManager.RegisterStartupScript(this, GetType(), "Toaster", 
                _toaster.AdicionarMensagemToaster("Título da mensagem",
                    "Mensagem do Toaster", 
                    "success", 
                    "top-rigth",
                    5000), true);     
          } 
     }
}
```
## License
[MIT](https://choosealicense.com/licenses/mit/)
