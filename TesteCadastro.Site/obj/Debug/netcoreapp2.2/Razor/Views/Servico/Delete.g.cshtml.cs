#pragma checksum "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "523ce458f9fa6d8cd0f2c10af717be852e92d4aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servico_Delete), @"mvc.1.0.view", @"/Views/Servico/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Servico/Delete.cshtml", typeof(AspNetCore.Views_Servico_Delete))]
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
#line 1 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\_ViewImports.cshtml"
using TesteCadastro.Site;

#line default
#line hidden
#line 2 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\_ViewImports.cshtml"
using TesteCadastro.Site.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"523ce458f9fa6d8cd0f2c10af717be852e92d4aa", @"/Views/Servico/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c82f0822800933dba0b6dcd3bd96c20a9cf1bff6", @"/Views/_ViewImports.cshtml")]
    public class Views_Servico_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TesteCadastro.Domain.Entities.Servico>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
  
    ViewData["Title"] = "Deletar";

#line default
#line hidden
            BeginContext(91, 175, true);
            WriteLiteral("\r\n<h2>Apager Serviço</h2>\r\n\r\n<h3>Você tem certeza que deseja remover?</h3>\r\n<div>\r\n    <h4>Usuario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(267, 38, false);
#line 15 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(305, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(349, 34, false);
#line 18 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(383, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(427, 45, false);
#line 21 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(472, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(516, 41, false);
#line 24 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(557, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(601, 40, false);
#line 27 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(641, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(685, 36, false);
#line 30 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(721, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(765, 41, false);
#line 33 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(806, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(850, 37, false);
#line 36 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(887, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(931, 47, false);
#line 39 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoServico));

#line default
#line hidden
            EndContext();
            BeginContext(978, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1022, 53, false);
#line 42 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TipoServico.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1119, 46, false);
#line 45 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroNota));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1209, 42, false);
#line 48 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumeroNota));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1295, 41, false);
#line 51 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Tempo));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1380, 37, false);
#line 54 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Tempo));

#line default
#line hidden
            EndContext();
            BeginContext(1417, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1461, 43, false);
#line 57 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1548, 44, false);
#line 60 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cliente.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1630, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "523ce458f9fa6d8cd0f2c10af717be852e92d4aa11197", async() => {
                BeginContext(1656, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Deletar\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1740, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "523ce458f9fa6d8cd0f2c10af717be852e92d4aa11672", async() => {
                    BeginContext(1762, 17, true);
                    WriteLiteral("Voltar para lista");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1783, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1796, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TesteCadastro.Domain.Entities.Servico> Html { get; private set; }
    }
}
#pragma warning restore 1591
