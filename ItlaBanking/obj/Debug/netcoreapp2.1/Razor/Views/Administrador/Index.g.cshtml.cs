#pragma checksum "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bedf8d0fa1f11bbcd8c8694f035c42cc4ea3e8e5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bedf8d0fa1f11bbcd8c8694f035c42cc4ea3e8e5", @"/Views/Administrador/Index.cshtml")]
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
            BeginContext(120, 2818, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8a2267b20744df793ddf97c503aeee7", async() => {
                BeginContext(167, 550, true);
                WriteLiteral(@"
    <div class=""card container bg-white border border-white rounded shadow-lg p-1 mb-5"">

        <div class=""card-header p-2 bg-white text-center"">
            <h2 style=""font-size:40px; font-family:cursive; font-weight:bolder"">Estadisticas</h2>
        </div>

        <div class=""card-body  FondoCard"">

            <div class=""card-header p-1 bg-transparent form-inline border-bottom border-primary"">
                <h2 style=""color:lawngreen"" class=""mr-auto"">TOTAL DE TRANSACCIONES: <span style=""font-size:32px; color:lavenderblush"">");
                EndContext();
                BeginContext(718, 24, false);
#line 17 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                                 Write(Model.TotalTransacciones);

#line default
#line hidden
                EndContext();
                BeginContext(742, 252, true);
                WriteLiteral("</span></h2>\r\n            </div>\r\n\r\n            <div class=\"card-header p-1 bg-transparent form-inline  border-bottom border-primary\">\r\n                <h2 style=\"color:lawngreen\">TRANSACCIONES DE HOY: <span style=\"font-size:32px; color:lavenderblush\">");
                EndContext();
                BeginContext(995, 22, false);
#line 21 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                               Write(Model.TransaccionesHoy);

#line default
#line hidden
                EndContext();
                BeginContext(1017, 375, true);
                WriteLiteral(@"</span></h2>
            </div>

            <div class=""card-header bg-transparent"">
                <h2 style=""color:lawngreen"">CANTIDAD DE PAGOS: </h2>
            </div>

            <div class=""card-body border-bottom border-primary"">
                <h3 class=""card-title"" style=""color:yellow"">TOTAL DE PAGOS:  <span style=""font-size:32px; color:lavenderblush"">");
                EndContext();
                BeginContext(1393, 16, false);
#line 29 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                          Write(Model.TotalPagos);

#line default
#line hidden
                EndContext();
                BeginContext(1409, 151, true);
                WriteLiteral("</span> </h3>\r\n                <h3 class=\"card-title mt-2\" style=\"color:lightskyblue\">PAGOS DE HOY:  <span style=\"font-size:32px; color:lavenderblush\">");
                EndContext();
                BeginContext(1561, 14, false);
#line 30 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                                   Write(Model.PagosHoy);

#line default
#line hidden
                EndContext();
                BeginContext(1575, 382, true);
                WriteLiteral(@"</span></h3>
            </div>

            <div class=""card-header bg-transparent"">
                <h2 style=""color:lawngreen"">CANTIDAD DE CLIENTES: </h2>
            </div>

            <div class=""card-body border-bottom border-primary"">
                <h3 class=""card-title"" style=""color:mediumspringgreen"">ACTIVOS:  <span style=""font-size:32px; color:lavenderblush"">");
                EndContext();
                BeginContext(1958, 24, false);
#line 38 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                              Write(Model.TotalClientActivos);

#line default
#line hidden
                EndContext();
                BeginContext(1982, 139, true);
                WriteLiteral("</span> </h3>\r\n                <h3 class=\"card-title mt-2\" style=\"color:red\">INACTIVOS:  <span style=\"font-size:32px; color:lavenderblush\">");
                EndContext();
                BeginContext(2122, 27, false);
#line 39 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                       Write(Model.TotalClienteInactivos);

#line default
#line hidden
                EndContext();
                BeginContext(2149, 360, true);
                WriteLiteral(@"</span></h3>
            </div>

            <div class=""card-header bg-transparent"">
                <h2 style=""color:lawngreen"">CANTIDAD DE PRODUCTOS: </h2>
            </div>

            <div class=""card-body"">
                <h3 class=""card-title"" style=""color:mediumseagreen"">CUENTA DE AHORRO:  <span style=""font-size:32px; color:lavenderblush"">");
                EndContext();
                BeginContext(2510, 17, false);
#line 47 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                                    Write(Model.TotalCuenta);

#line default
#line hidden
                EndContext();
                BeginContext(2527, 150, true);
                WriteLiteral("</span></h3>\r\n                <h3 class=\"card-title mt-2\" style=\"color:orange\">TARJETA DE CREDITO:  <span style=\"font-size:32px; color:lavenderblush\">");
                EndContext();
                BeginContext(2678, 18, false);
#line 48 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                                   Write(Model.TotalTarjeta);

#line default
#line hidden
                EndContext();
                BeginContext(2696, 144, true);
                WriteLiteral("</span></h3>\r\n                <h3 class=\"card-title mt-2\" style=\"color:orangered\">PRESTAMOS:  <span style=\"font-size:32px; color:lavenderblush\">");
                EndContext();
                BeginContext(2841, 19, false);
#line 49 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Administrador\Index.cshtml"
                                                                                                                             Write(Model.TotalPrestamo);

#line default
#line hidden
                EndContext();
                BeginContext(2860, 71, true);
                WriteLiteral("</span> </h3>\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n");
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
            BeginContext(2938, 13, true);
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
