#pragma checksum "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04e017c197cd27cec37376d7932dc76292a51998"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SisMarcas_Index), @"mvc.1.0.view", @"/Views/SisMarcas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SisMarcas/Index.cshtml", typeof(AspNetCore.Views_SisMarcas_Index))]
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
#line 1 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\_ViewImports.cshtml"
using FrotaSisWeb;

#line default
#line hidden
#line 2 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
using FrotaSisWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04e017c197cd27cec37376d7932dc76292a51998", @"/Views/SisMarcas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3339ef6392be4246b43fccb69b8fc9f19e17a9d3", @"/Views/_ViewImports.cshtml")]
    public class Views_SisMarcas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FrotaSisWeb.Models.SisModels.SisMarcas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Appjs/Modal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(87, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(130, 137, true);
            WriteLiteral("\r\n<div class=\"\">\r\n    <div class=\"col-12\">\r\n        <h4>Cadastro de Marcas</h4>\r\n        <p class=\"btn btn-primary btn-sm\">\r\n            ");
            EndContext();
            BeginContext(267, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60f1a9c4c3284d14942ed6c2e81d164b", async() => {
                BeginContext(290, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(304, 219, true);
            WriteLiteral("\r\n        </p>\r\n        <div class=\"\">\r\n            <table class=\"table table-sm table-bordered table-hover\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                           ");
            EndContext();
            BeginContext(524, 43, false);
#line 19 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                      Write(Html.DisplayNameFor(model => model.IdMarca));

#line default
#line hidden
            EndContext();
            BeginContext(567, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(659, 45, false);
#line 22 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.DescMarca));

#line default
#line hidden
            EndContext();
            BeginContext(704, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(796, 45, false);
#line 25 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Usacadmat));

#line default
#line hidden
            EndContext();
            BeginContext(841, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(933, 46, false);
#line 28 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Usacadveic));

#line default
#line hidden
            EndContext();
            BeginContext(979, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1071, 41, false);
#line 31 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 208, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            Opções\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 39 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1393, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1490, 41, false);
#line 43 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                           Write(Html.DisplayFor(modelIem => item.IdMarca));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1635, 44, false);
#line 46 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DescMarca));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1783, 44, false);
#line 49 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Usacadmat));

#line default
#line hidden
            EndContext();
            BeginContext(1827, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1931, 45, false);
#line 52 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Usacadveic));

#line default
#line hidden
            EndContext();
            BeginContext(1976, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2080, 40, false);
#line 55 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(2120, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2223, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f39d93d2b9954c35a202a345819cdf01", async() => {
                BeginContext(2312, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                                                                                              WriteLiteral(item.IdMarca);

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
            BeginContext(2322, 109, true);
            WriteLiteral("\r\n                                <!--<a class=\"btn btn-sm btn-outline-info\" data-toggle=\"modal\" data-modal=\"");
            EndContext();
            BeginContext(2432, 12, false);
#line 59 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                                                                                                      Write(item.IdMarca);

#line default
#line hidden
            EndContext();
            BeginContext(2444, 60, true);
            WriteLiteral("\" data-target=\"#myModal\" asp-action=\"Details\" asp-route-id=\"");
            EndContext();
            BeginContext(2505, 12, false);
#line 59 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                                                                                                                                                                               Write(item.IdMarca);

#line default
#line hidden
            EndContext();
            BeginContext(2517, 124, true);
            WriteLiteral("\">Visualizar</a>-->\r\n                                <a href=\"#\" class=\"btn btn-sm btn-outline-info btnDetails\" data-value=\"");
            EndContext();
            BeginContext(2642, 12, false);
#line 60 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                                                                                                  Write(item.IdMarca);

#line default
#line hidden
            EndContext();
            BeginContext(2654, 125, true);
            WriteLiteral("\">Detalhes01</a>\r\n                                <!--<a class=\"btn btn-sm btn-outline-info\" data-toggle=\"modal\" data-modal=\"");
            EndContext();
            BeginContext(2780, 12, false);
#line 61 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                                                                                                      Write(item.IdMarca);

#line default
#line hidden
            EndContext();
            BeginContext(2792, 61, true);
            WriteLiteral("\" data-target=\"#myModal2\" asp-action=\"Details\" asp-route-id=\"");
            EndContext();
            BeginContext(2854, 12, false);
#line 61 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                                                                                                                                                                                Write(item.IdMarca);

#line default
#line hidden
            EndContext();
            BeginContext(2866, 53, true);
            WriteLiteral("\">Detalhes02</a>-->\r\n                                ");
            EndContext();
            BeginContext(2919, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3a0be64042044e39ddf1c23c1677e5c", async() => {
                BeginContext(3009, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                                                                                               WriteLiteral(item.IdMarca);

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
            BeginContext(3020, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 65 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3111, 865, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>

<!-- modal placeholder -->
<div id=""myModal"" class=""modal fade"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <div id=""myModalContent""></div>
            </div>
        </div>
    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" id=""myModal2"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                Marca - Detalhes
            </div>
            <div class=""modal-body"">
                <div id=""conteudoModal""></div>
            </div>  
            <div class=""modal-footer"">                
                ");
            EndContext();
            BeginContext(3976, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff38e629cb384a03bacb3e7babde3428", async() => {
                BeginContext(4020, 6, true);
                WriteLiteral("Fechar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4030, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4107, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4113, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e03f890ce4749f89c5069642e7b71b0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 101 "D:\AspNetProjetos\SistemaFrotaWeb\FrotaSisWeb\FrotaSisWeb\Views\SisMarcas\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4182, 427, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {
            $("".btnDetails"").click(function () {
                var id = $(this).data(""value"");
                $(""#conteudoModal"").load(""/SisMarcas/Details/"" + id,
                    function () {
                        $('#myModal2').modal('show');
                    }
                );
            })
        })
    </script>
");
                EndContext();
            }
            );
            BeginContext(4612, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FrotaSisWeb.Models.SisModels.SisMarcas>> Html { get; private set; }
    }
}
#pragma warning restore 1591
