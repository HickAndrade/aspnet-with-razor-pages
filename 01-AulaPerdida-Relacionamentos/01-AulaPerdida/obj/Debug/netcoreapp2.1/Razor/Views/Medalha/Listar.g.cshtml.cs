#pragma checksum "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Medalha\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b96f4edd924d2004d09d1c046485d2b780039271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medalha_Listar), @"mvc.1.0.view", @"/Views/Medalha/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Medalha/Listar.cshtml", typeof(AspNetCore.Views_Medalha_Listar))]
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
#line 1 "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\_ViewImports.cshtml"
using _01_AulaPerdida;

#line default
#line hidden
#line 2 "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\_ViewImports.cshtml"
using _01_AulaPerdida.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96f4edd924d2004d09d1c046485d2b780039271", @"/Views/Medalha/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36f917bbf827b1a46355474283e6d2b88d66f555", @"/Views/_ViewImports.cshtml")]
    public class Views_Medalha_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Medalha>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "corridaBusca", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "listar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Medalha", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::_06_Fiap.Web.AspNet.TagHelpers.MensagemTagHelper ___06_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Medalha\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(65, 21, true);
            WriteLiteral("\r\n<h2>Listar</h2>\r\n\r\n");
            EndContext();
            BeginContext(86, 270, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e93d975d6c749649730a227662d299f", async() => {
                BeginContext(150, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(156, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47e2b2bedf1d4d23aab3dcca02672657", async() => {
                    BeginContext(235, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(241, 26, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed35b97cc7504eeaaa86663300841c68", async() => {
                        BeginContext(249, 9, true);
                        WriteLiteral("Selecione");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 9 "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Medalha\Listar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.corridas;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(276, 73, true);
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Pesquisar\"  class=\"btn btn-primary\"/>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(356, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(360, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("mensagem", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57447417a2084a9c8c5dc4422e3b816b", async() => {
            }
            );
            ___06_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper = CreateTagHelper<global::_06_Fiap.Web.AspNet.TagHelpers.MensagemTagHelper>();
            __tagHelperExecutionContext.Add(___06_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper);
            BeginWriteTagHelperAttribute();
#line 14 "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Medalha\Listar.cshtml"
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
            BeginContext(411, 154, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Peso</th>\r\n        <th>Quantidade</th>\r\n        <th>Categoria</th>\r\n        <th>Corrida</th>\r\n    </tr>\r\n");
            EndContext();
#line 23 "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Medalha\Listar.cshtml"
     foreach (var item in Model) {


#line default
#line hidden
            BeginContext(603, 14, true);
            WriteLiteral("<tr>\r\n    <td>");
            EndContext();
            BeginContext(618, 9, false);
#line 26 "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Medalha\Listar.cshtml"
   Write(item.Peso);

#line default
#line hidden
            EndContext();
            BeginContext(627, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(643, 15, false);
#line 27 "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Medalha\Listar.cshtml"
   Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(658, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(674, 14, false);
#line 28 "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Medalha\Listar.cshtml"
   Write(item.Categoria);

#line default
#line hidden
            EndContext();
            BeginContext(688, 15, true);
            WriteLiteral("</td>\r\n    <td>");
            EndContext();
            BeginContext(704, 17, false);
#line 29 "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Medalha\Listar.cshtml"
   Write(item.Corrida.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(721, 35, true);
            WriteLiteral("</td>\r\n    <td></td>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 33 "C:\Users\Henri\Desktop\Samurai\Perdidos\01-AulaPerdida-Relacionamentos\01-AulaPerdida\Views\Medalha\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(763, 14, true);
            WriteLiteral("\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Medalha>> Html { get; private set; }
    }
}
#pragma warning restore 1591
