#pragma checksum "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a11ec351e0f9e1cb56405362bd5b7de6aae17665"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Index), @"mvc.1.0.view", @"/Views/Administrador/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Index.cshtml", typeof(AspNetCore.Views_Administrador_Index))]
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
#line 1 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\_ViewImports.cshtml"
using ItlaBanking;

#line default
#line hidden
#line 2 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\_ViewImports.cshtml"
using ItlaBanking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a11ec351e0f9e1cb56405362bd5b7de6aae17665", @"/Views/Administrador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679e8b9cb41817ef60e96e5e8087b782b5451390", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItlaBanking.ViewModels.EstadisticaAdministradorViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FondoAdministrador"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
  
    Layout = "_LayoutAdministrador";

#line default
#line hidden
            BeginContext(110, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(120, 3001, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abad6679348546ee86f944d1f1a2508e", async() => {
                BeginContext(167, 269, true);
                WriteLiteral(@"
    <div class=""card container bg-white border border-white rounded shadow-lg p-1 mb-5"">

        <div class=""card-header p-2 bg-white text-center"">
            <h2 style=""font-size:40px; font-family:cursive; font-weight:bolder"">Estadisticas</h2>
        </div>
");
                EndContext();
#line 13 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
         foreach (var stats in Model.stats)
        {

#line default
#line hidden
                BeginContext(492, 291, true);
                WriteLiteral(@"            <div class=""card-body  FondoCard"">

                <div class=""card-header p-1 bg-transparent form-inline border-bottom border-primary"">
                    <h2 style=""color:lawngreen"" class=""mr-auto"">TOTAL DE TRANSACCIONES: <span style=""font-size:32px; color:lavenderblush"">");
                EndContext();
                BeginContext(784, 24, false);
#line 18 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                                     Write(stats.TotalTransacciones);

#line default
#line hidden
                EndContext();
                BeginContext(808, 264, true);
                WriteLiteral(@"</span></h2>
                </div>

                <div class=""card-header p-1 bg-transparent form-inline  border-bottom border-primary"">
                    <h2 style=""color:lawngreen"">TRANSACCIONES DE HOY: <span style=""font-size:32px; color:lavenderblush"">");
                EndContext();
                BeginContext(1073, 22, false);
#line 22 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                   Write(stats.TransaccionesHoy);

#line default
#line hidden
                EndContext();
                BeginContext(1095, 399, true);
                WriteLiteral(@"</span></h2>
                </div>

                <div class=""card-header bg-transparent"">
                    <h2 style=""color:lawngreen"">CANTIDAD DE PAGOS: </h2>
                </div>

                <div class=""card-body border-bottom border-primary"">
                    <h3 class=""card-title"" style=""color:yellow"">TOTAL DE PAGOS:  <span style=""font-size:32px; color:lavenderblush"">");
                EndContext();
                BeginContext(1495, 16, false);
#line 30 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                              Write(stats.TotalPagos);

#line default
#line hidden
                EndContext();
                BeginContext(1511, 155, true);
                WriteLiteral("</span> </h3>\r\n                    <h3 class=\"card-title mt-2\" style=\"color:lightskyblue\">PAGOS DE HOY:  <span style=\"font-size:32px; color:lavenderblush\">");
                EndContext();
                BeginContext(1667, 14, false);
#line 31 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                                       Write(stats.PagosHoy);

#line default
#line hidden
                EndContext();
                BeginContext(1681, 406, true);
                WriteLiteral(@"</span></h3>
                </div>

                <div class=""card-header bg-transparent"">
                    <h2 style=""color:lawngreen"">CANTIDAD DE CLIENTES: </h2>
                </div>

                <div class=""card-body border-bottom border-primary"">
                    <h3 class=""card-title"" style=""color:mediumspringgreen"">ACTIVOS:  <span style=""font-size:32px; color:lavenderblush"">");
                EndContext();
                BeginContext(2088, 24, false);
#line 39 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                                  Write(stats.TotalClientActivos);

#line default
#line hidden
                EndContext();
                BeginContext(2112, 143, true);
                WriteLiteral("</span> </h3>\r\n                    <h3 class=\"card-title mt-2\" style=\"color:red\">INACTIVOS:  <span style=\"font-size:32px; color:lavenderblush\">");
                EndContext();
                BeginContext(2256, 27, false);
#line 40 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                           Write(stats.TotalClienteInactivos);

#line default
#line hidden
                EndContext();
                BeginContext(2283, 384, true);
                WriteLiteral(@"</span></h3>
                </div>

                <div class=""card-header bg-transparent"">
                    <h2 style=""color:lawngreen"">CANTIDAD DE PRODUCTOS: </h2>
                </div>

                <div class=""card-body"">
                    <h3 class=""card-title"" style=""color:mediumseagreen"">CUENTA DE AHORRO:  <span style=""font-size:32px; color:lavenderblush"">");
                EndContext();
                BeginContext(2668, 17, false);
#line 48 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                                        Write(stats.TotalCuenta);

#line default
#line hidden
                EndContext();
                BeginContext(2685, 154, true);
                WriteLiteral("</span></h3>\r\n                    <h3 class=\"card-title mt-2\" style=\"color:orange\">TARJETA DE CREDITO:  <span style=\"font-size:32px; color:lavenderblush\">");
                EndContext();
                BeginContext(2840, 18, false);
#line 49 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                                       Write(stats.TotalTarjeta);

#line default
#line hidden
                EndContext();
                BeginContext(2858, 148, true);
                WriteLiteral("</span></h3>\r\n                    <h3 class=\"card-title mt-2\" style=\"color:orangered\">PRESTAMOS:  <span style=\"font-size:32px; color:lavenderblush\">");
                EndContext();
                BeginContext(3007, 19, false);
#line 50 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                                 Write(stats.TotalPrestamo);

#line default
#line hidden
                EndContext();
                BeginContext(3026, 61, true);
                WriteLiteral("</span> </h3>\r\n                </div>\r\n\r\n            </div>\r\n");
                EndContext();
#line 54 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(3098, 16, true);
                WriteLiteral("\r\n    </div>\r\n\r\n");
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
            BeginContext(3121, 13, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItlaBanking.ViewModels.EstadisticaAdministradorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
