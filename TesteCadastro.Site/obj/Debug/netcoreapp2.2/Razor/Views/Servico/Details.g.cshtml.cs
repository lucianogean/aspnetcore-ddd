#pragma checksum "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84993ef24fe9d240e0177c8441289c4d46cde6d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servico_Details), @"mvc.1.0.view", @"/Views/Servico/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Servico/Details.cshtml", typeof(AspNetCore.Views_Servico_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84993ef24fe9d240e0177c8441289c4d46cde6d7", @"/Views/Servico/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c82f0822800933dba0b6dcd3bd96c20a9cf1bff6", @"/Views/_ViewImports.cshtml")]
    public class Views_Servico_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TesteCadastro.Domain.Entities.Servico>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(92, 100, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(193, 38, false);
#line 13 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(231, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(275, 34, false);
#line 16 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(309, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(353, 45, false);
#line 19 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(398, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(442, 41, false);
#line 22 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(483, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(527, 40, false);
#line 25 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(567, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(611, 36, false);
#line 28 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayFor(model => model.Data));

#line default
#line hidden
            EndContext();
            BeginContext(647, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(691, 41, false);
#line 31 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(732, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(776, 37, false);
#line 34 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(813, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(857, 47, false);
#line 37 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoServico));

#line default
#line hidden
            EndContext();
            BeginContext(904, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(948, 53, false);
#line 40 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoServico.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1045, 46, false);
#line 43 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroNota));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1135, 42, false);
#line 46 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumeroNota));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1221, 41, false);
#line 49 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tempo));

#line default
#line hidden
            EndContext();
            BeginContext(1262, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1306, 37, false);
#line 52 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tempo));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1387, 43, false);
#line 55 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
            EndContext();
            BeginContext(1430, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1474, 44, false);
#line 58 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cliente.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1566, 92, false);
#line 63 "C:\Users\l.robe\source\repos\TesteCadastro\TesteCadastro.Site\Views\Servico\Details.cshtml"
Write(Html.ActionLink("Editar", "Edit", new { id = Model.Id }, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1666, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84993ef24fe9d240e0177c8441289c4d46cde6d710986", async() => {
                BeginContext(1688, 17, true);
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
            BeginContext(1709, 10, true);
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
