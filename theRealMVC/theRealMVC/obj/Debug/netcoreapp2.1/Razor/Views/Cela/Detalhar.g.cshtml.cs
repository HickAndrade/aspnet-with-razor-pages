#pragma checksum "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bb834ac56d2515afd2394871e5dca42e947ecf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cela_Detalhar), @"mvc.1.0.view", @"/Views/Cela/Detalhar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cela/Detalhar.cshtml", typeof(AspNetCore.Views_Cela_Detalhar))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\_ViewImports.cshtml"
using theRealMVC;

#line default
#line hidden
#line 2 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\_ViewImports.cshtml"
using theRealMVC.Models;

#line default
#line hidden
#line 3 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\_ViewImports.cshtml"
using theRealMVC.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bb834ac56d2515afd2394871e5dca42e947ecf0", @"/Views/Cela/Detalhar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fe8818f746ac513f9e97414f8f9643aeca67e59", @"/Views/_ViewImports.cshtml")]
    public class Views_Cela_Detalhar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetalheCelaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
  
    ViewData["Title"] = "Detalhar";

#line default
#line hidden
            BeginContext(75, 53, true);
            WriteLiteral("\r\n<h2>Detalhar</h2>\r\n\r\n<h1><span class=\"text-danger\">");
            EndContext();
            BeginContext(129, 15, false);
#line 9 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
                         Write(Model.Cela.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(144, 69, true);
            WriteLiteral("</span></h1>\r\n<h5>\r\n    Quantidade Maxima: <span class=\"text-danger\">");
            EndContext();
            BeginContext(214, 27, false);
#line 11 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
                                            Write(Model.Cela.QuantidadeMaxima);

#line default
#line hidden
            EndContext();
            BeginContext(241, 58, true);
            WriteLiteral("</span>\r\n    Quantidade Atual:  <span class=\"text-danger\">");
            EndContext();
            BeginContext(300, 24, false);
#line 12 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
                                            Write(Model.Presidiarios.Count);

#line default
#line hidden
            EndContext();
            BeginContext(324, 50, true);
            WriteLiteral("</span>\r\n    Ocupação:  <span class=\"text-danger\">");
            EndContext();
            BeginContext(375, 14, false);
#line 13 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
                                    Write(Model.Ocupacao);

#line default
#line hidden
            EndContext();
            BeginContext(389, 41, true);
            WriteLiteral(" %</span>\r\n</h5>\r\n\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 18 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
     foreach (var item in Model.Presidiarios)
    {

#line default
#line hidden
            BeginContext(484, 150, true);
            WriteLiteral("        <div class=\"col-3 mb-3\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(635, 9, false);
#line 23 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
                                      Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(644, 85, true);
            WriteLiteral(" </h5>\r\n                    <p class=\"card-text\">\r\n                        Nível: <b>");
            EndContext();
            BeginContext(730, 22, false);
#line 25 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
                             Write(item.nivelEscolaridade);

#line default
#line hidden
            EndContext();
            BeginContext(752, 84, true);
            WriteLiteral("</b><br />\r\n                        Data Entrada:<br />\r\n                        <b>");
            EndContext();
            BeginContext(837, 16, false);
#line 27 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
                      Write(item.dataEntrada);

#line default
#line hidden
            EndContext();
            BeginContext(853, 56, true);
            WriteLiteral("</b><br />\r\n                        Data Saída:<br /><b>");
            EndContext();
            BeginContext(910, 34, false);
#line 28 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
                                       Write(item.dataSaida.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(944, 89, true);
            WriteLiteral("</b><br />\r\n                        <br />\r\n                        Saída Temporária: <b>");
            EndContext();
            BeginContext(1035, 36, false);
#line 30 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
                                         Write(item.saidaTemporaria ? "Sim" : "Não");

#line default
#line hidden
            EndContext();
            BeginContext(1072, 336, true);
            WriteLiteral(@"</b>
                    </p>
                    <!-- Botão para acionar modal -->
                    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#modalExemplo"">
                        Saída temporária
                    </button>
                </div>
            </div>
        </div>
");
            EndContext();
#line 39 "C:\Users\Henri\Desktop\Samurai\Perdidos\theRealMVC\theRealMVC\Views\Cela\Detalhar.cshtml"
    }

#line default
#line hidden
            BeginContext(1415, 931, true);
            WriteLiteral(@"</div>


<!-- Modal -->
<div class=""modal fade"" id=""modalExemplo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Título do modal</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ...
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                <button type=""button"" class=""btn btn-primary"">Salvar mudanças</button>
            </div>
        </div>
    </div>
</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetalheCelaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591