#pragma checksum "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosExpreso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ecdf0baa0ab1502c01964cf969220de5d748b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_PagosExpreso), @"mvc.1.0.view", @"/Views/Client/PagosExpreso.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/PagosExpreso.cshtml", typeof(AspNetCore.Views_Client_PagosExpreso))]
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
#line 1 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\_ViewImports.cshtml"
using ItlaBanking;

#line default
#line hidden
#line 2 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\_ViewImports.cshtml"
using ItlaBanking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ecdf0baa0ab1502c01964cf969220de5d748b9e", @"/Views/Client/PagosExpreso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679e8b9cb41817ef60e96e5e8087b782b5451390", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_PagosExpreso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("CardViewFormulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(11, 10, true);
            WriteLiteral("<html>\r\n\r\n");
            EndContext();
            BeginContext(21, 2022, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ac747e13c0048b5aad24f9a7e9c8fa2", async() => {
                BeginContext(68, 379, true);
                WriteLiteral(@"
       

    <div class=""container bg-warning border border-white rounded shadow-lg p-1 mb-5 bg-white rounded"">

        <div>
            <div class=""card-header headNombre rounded border border-secondary shadow-sm p-1 bg-white rounded mb-3"">
                <div class=""d-flex justify-content-center letterPagos"">Pagos Expresos</div>
            </div>

            ");
                EndContext();
                BeginContext(447, 1551, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b0cc9c1df944c3183ad20aa26ff748f", async() => {
                    BeginContext(453, 1538, true);
                    WriteLiteral(@"

                <div class=""form-row"">
                    <div class=""form-group col-md-6"">
                        <label class=""labelPago ml-3"">Número de cuenta del destinatario: </label>
                        <input type=""number"" min=""0"" class=""form-control form-control-lg rounded-pill border border-success shadow-sm p-3 bg-white rounded"" placeholder=""Ingresar número de cuenta"">
                    </div>
                    <div class=""form-group col-md-6"">
                        <label class=""labelPago ml-3"">Número de cuenta de ahorro: </label>
                        <input type=""number"" min=""0"" class=""form-control form-control-lg rounded-pill border border-success shadow-sm p-3 bg-white rounded"" placeholder=""Ingresar número de cuenta"">
                    </div>
                </div>


                <div class=""input-group mb-3 w-50 "">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text labelPago"">Monto a pagar</span>
   ");
                    WriteLiteral(@"                     <span class=""input-group-text simboloDinero"">$</span>
                    </div>
                    <input type=""number"" min=""0.01"" step=""0.01"" class=""form-control rounded-right border border-success shadow-sm p-3"" aria-label=""Sizing example input"" aria-describedby=""inputGroup-sizing-default"">
                    <div class=""ml-2"">
                        <button class=""btn btn-success"" type=""submit"">Pagar</button>
                    </div>

                </div>

            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1998, 38, true);
                WriteLiteral("\r\n\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2043, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
