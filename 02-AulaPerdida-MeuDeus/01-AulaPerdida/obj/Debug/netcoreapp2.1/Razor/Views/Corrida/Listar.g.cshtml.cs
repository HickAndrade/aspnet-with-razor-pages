#pragma checksum "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86ddf7f7e48437c005c5856be1ef844b368956d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Corrida_Listar), @"mvc.1.0.view", @"/Views/Corrida/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Corrida/Listar.cshtml", typeof(AspNetCore.Views_Corrida_Listar))]
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
#line 1 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\_ViewImports.cshtml"
using _01_AulaPerdida;

#line default
#line hidden
#line 2 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\_ViewImports.cshtml"
using _01_AulaPerdida.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86ddf7f7e48437c005c5856be1ef844b368956d7", @"/Views/Corrida/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36f917bbf827b1a46355474283e6d2b88d66f555", @"/Views/_ViewImports.cshtml")]
    public class Views_Corrida_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Corrida>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pesquisar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:5.5px;border:2px solid black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::_06_Fiap.Web.AspNet.TagHelpers.MensagemTagHelper ___06_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(65, 21, true);
            WriteLiteral("\r\n<h2>Listar</h2>\r\n\r\n");
            EndContext();
            BeginContext(86, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("mensagem", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0e7e79ad7f8464592fa532d79b43560", async() => {
            }
            );
            ___06_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper = CreateTagHelper<global::_06_Fiap.Web.AspNet.TagHelpers.MensagemTagHelper>();
            __tagHelperExecutionContext.Add(___06_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper);
            BeginWriteTagHelperAttribute();
#line 8 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
     WriteLiteral(TempData["mensagem"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            ___06_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper.Texto = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("texto", ___06_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper.Texto, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(137, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(141, 269, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9834d681c8b481189ba860ce9627aff", async() => {
                BeginContext(203, 200, true);
                WriteLiteral("\r\n    <input placeholder=\"Digite o nome\" class=\"form-control\" type=\"text\" name=\"termoPesquisa\" />\r\n    <input type=\"submit\" class=\"btn btn-success\" value=\"Pesquisar\" style=\"border:2px solid black\"/>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(410, 241, true);
            WriteLiteral("\r\n<br/>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Distancia</th>\r\n        <th>Premiação</th>\r\n        <th>Categoria</th>\r\n        <th>Local Inicio</th>\r\n        <th>Distancia </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 26 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(692, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(723, 9, false);
#line 29 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(732, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(756, 14, false);
#line 30 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
           Write(item.Distancia);

#line default
#line hidden
            EndContext();
            BeginContext(770, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(795, 30, false);
#line 31 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
            Write(item.Premiacao ? "Sim" : "Não");

#line default
#line hidden
            EndContext();
            BeginContext(826, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(850, 14, false);
#line 32 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
           Write(item.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(864, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(888, 24, false);
#line 33 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
           Write(item.Trajeto.LocalInicio);

#line default
#line hidden
            EndContext();
            BeginContext(912, 23, true);
            WriteLiteral("</td>\r\n            <th>");
            EndContext();
            BeginContext(936, 22, false);
#line 34 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
           Write(item.Trajeto.Distancia);

#line default
#line hidden
            EndContext();
            BeginContext(958, 42, true);
            WriteLiteral(" </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1000, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5ba811d7eb1467a9595291b0109cfcd", async() => {
                BeginContext(1129, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
                                                                                                                    WriteLiteral(item.CorridaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1139, 25, true);
            WriteLiteral("\r\n                <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1164, "\"", 1205, 3);
            WriteAttributeValue("", 1174, "caralho.value", 1174, 13, true);
            WriteAttributeValue(" ", 1187, "=", 1188, 2, true);
#line 37 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
WriteAttributeValue(" ", 1189, item.CorridaId, 1190, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1206, 242, true);
            WriteLiteral("\r\n                        class=\"btn btn-danger\" style=\"border-radius:5.5px;border:2px solid black\" data-toggle=\"modal\" data-target=\"#modalExemplo\">\r\n                    Excluir\r\n                </button>\r\n            </th>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 44 "C:\Users\logonrmlocal\Desktop\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Corrida\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(1455, 753, true);
            WriteLiteral(@"

    <div class=""modal fade"" id=""modalExemplo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Confirmação</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    Deseja realmente excluir?
                </div>
                <div class=""modal-footer"">
                    ");
            EndContext();
            BeginContext(2208, 395, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62908e347a8148aabfd9632bd0586e1c", async() => {
                BeginContext(2235, 361, true);
                WriteLiteral(@"
                        <input name=""caralho"" type=""hidden"" id=""caralho"" /> <!--Esse name e/ou id está referenciando o int id da action deletar?-->
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Não</button>
                        <button type=""submit"" class=""btn btn-danger"">Sim</button>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2603, 84, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Corrida>> Html { get; private set; }
    }
}
#pragma warning restore 1591
