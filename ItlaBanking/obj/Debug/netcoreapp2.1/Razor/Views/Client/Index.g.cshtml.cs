#pragma checksum "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de0763363f6212e81ca6d9d08329264a49ee66ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Index), @"mvc.1.0.view", @"/Views/Client/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Index.cshtml", typeof(AspNetCore.Views_Client_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de0763363f6212e81ca6d9d08329264a49ee66ed", @"/Views/Client/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679e8b9cb41817ef60e96e5e8087b782b5451390", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItlaBanking.ViewModels.TraerProductosViewModels>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
  
//Layout = null;

#line default
#line hidden
            BeginContext(81, 3596, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ee8ea2e82894e7a908c85ae9bed5def", async() => {
                BeginContext(128, 159, true);
                WriteLiteral("\r\n\r\n    <div class=\"container bg-warning border border-white rounded shadow-lg p-1 mb-5 bg-white rounded\">\r\n\r\n        <div class=\"text-center overflow-auto\">\r\n");
                EndContext();
#line 10 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
             foreach (var cuenta in Model.Cuenta)
            {
                if (cuenta.Categoria == 1)
                {

#line default
#line hidden
                BeginContext(416, 464, true);
                WriteLiteral(@"                    <div class=""card rounded border-0"">

                        <div class=""card-header headNombre rounded border border-secondary shadow-sm p-1 bg-white rounded mb-2"">
                            <div class=""d-flex justify-content-center letterPagos "">Home</div>
                        </div>

                        <div class=""card-body p-1 mb-2"">
                            <div class="" headNombre"">
                                ");
                EndContext();
                BeginContext(881, 17, false);
#line 22 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                           Write(Model.user.Nombre);

#line default
#line hidden
                EndContext();
                BeginContext(898, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(901, 19, false);
#line 22 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                               Write(Model.user.Apellido);

#line default
#line hidden
                EndContext();
                BeginContext(920, 179, true);
                WriteLiteral("\r\n                            </div>\r\n                            <h5 class=\"card-title titleCuenta\"><span style=\"color:olivedrab\" class=\"titleProducto\">Cuenta Principal:</span> #");
                EndContext();
                BeginContext(1100, 19, false);
#line 24 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                                                                        Write(cuenta.NumeroCuenta);

#line default
#line hidden
                EndContext();
                BeginContext(1119, 99, true);
                WriteLiteral("</h5>\r\n                            <h6 class=\"card-subtitle mb-1 text-muted\">Fecha de Adquisicion: ");
                EndContext();
                BeginContext(1219, 23, false);
#line 25 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                       Write(cuenta.FechaAdquisicion);

#line default
#line hidden
                EndContext();
                BeginContext(1242, 116, true);
                WriteLiteral("</h6>\r\n                            <p class=\"card-text  dineroAhorro\">Balance: <span class=\"simboloDinero\">$</span> ");
                EndContext();
                BeginContext(1359, 14, false);
#line 26 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                                        Write(cuenta.Balance);

#line default
#line hidden
                EndContext();
                BeginContext(1373, 66, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 29 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                }
                else
                {


#line default
#line hidden
                BeginContext(1501, 311, true);
                WriteLiteral(@"                <!--Cuentas de Ahorro-->
                <div class=""card w-100 text-left shadow bg-white rounded mb-3"">
                    <div class=""card-body p-1"">

                        <h5 class=""card-title titleCuenta""><span style=""color:olivedrab"" class=""titleProducto"">Cuenta de Ahorro:</span> #");
                EndContext();
                BeginContext(1813, 19, false);
#line 37 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                                                                    Write(cuenta.NumeroCuenta);

#line default
#line hidden
                EndContext();
                BeginContext(1832, 95, true);
                WriteLiteral("</h5>\r\n                        <h6 class=\"card-subtitle mb-1 text-muted\">Fecha de Adquisicion: ");
                EndContext();
                BeginContext(1928, 23, false);
#line 38 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                   Write(cuenta.FechaAdquisicion);

#line default
#line hidden
                EndContext();
                BeginContext(1951, 112, true);
                WriteLiteral("</h6>\r\n                        <p class=\"card-text  dineroAhorro\">Balance: <span class=\"simboloDinero\">$</span> ");
                EndContext();
                BeginContext(2064, 14, false);
#line 39 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                                    Write(cuenta.Balance);

#line default
#line hidden
                EndContext();
                BeginContext(2078, 58, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
                EndContext();
#line 42 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                }
            }

#line default
#line hidden
                BeginContext(2170, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 45 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
             foreach (var credito in Model.Credito) {

#line default
#line hidden
                BeginContext(2227, 296, true);
                WriteLiteral(@"            <!--Tarjeta de Credito-->
            <div class=""card w-100 text-left shadow bg-white rounded  mb-3"">
                <div class=""card-body p-1"">

                    <h5 class=""card-title titleCuenta""><span style=""color:orange"" class=""titleProducto"">Tarjeta de Credito:</span> #");
                EndContext();
                BeginContext(2524, 21, false);
#line 50 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                                                               Write(credito.NumeroTarjeta);

#line default
#line hidden
                EndContext();
                BeginContext(2545, 142, true);
                WriteLiteral("</h5>\r\n                    <h6 class=\"card-subtitle mb-1 font-weight-bold font-italic text-info\">Fecha de Expiración: <span class=\"text-dark\">");
                EndContext();
                BeginContext(2688, 23, false);
#line 51 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                                                                  Write(credito.FechaExpiracion);

#line default
#line hidden
                EndContext();
                BeginContext(2711, 120, true);
                WriteLiteral("</span></h6>\r\n                    <p class=\"card-text  dineroAhorro\">Monto Limite: <span class=\"simboloDinero\">$</span> ");
                EndContext();
                BeginContext(2832, 19, false);
#line 52 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                                     Write(credito.MontoLimite);

#line default
#line hidden
                EndContext();
                BeginContext(2851, 50, true);
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 55 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2916, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 57 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
             foreach (var prestamo in Model.Prestamos) {

#line default
#line hidden
                BeginContext(2976, 278, true);
                WriteLiteral(@"            <!--Prestamos-->
            <div class=""card w-100 text-left shadow bg-white rounded  mb-3"">
                <div class=""card-body p-1"">

                    <h5 class=""card-title titleCuenta""><span style=""color:darkred"" class=""titleProducto"">Prestamo:</span> #");
                EndContext();
                BeginContext(3255, 23, false);
#line 62 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                                                      Write(prestamo.NumeroPrestamo);

#line default
#line hidden
                EndContext();
                BeginContext(3278, 142, true);
                WriteLiteral("</h5>\r\n                    <h6 class=\"card-subtitle mb-1 font-weight-bold font-italic text-info\">Fecha de Expiración: <span class=\"text-dark\">");
                EndContext();
                BeginContext(3421, 24, false);
#line 63 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                                                                  Write(prestamo.FechaExpiracion);

#line default
#line hidden
                EndContext();
                BeginContext(3445, 113, true);
                WriteLiteral("</span></h6>\r\n                    <p class=\"card-text  dineroAhorro\">Monto: <span class=\"simboloDinero\">$</span> ");
                EndContext();
                BeginContext(3559, 14, false);
#line 64 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
                                                                                              Write(prestamo.Monto);

#line default
#line hidden
                EndContext();
                BeginContext(3573, 50, true);
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 67 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(3638, 32, true);
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(3677, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItlaBanking.ViewModels.TraerProductosViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
