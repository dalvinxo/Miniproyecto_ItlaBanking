#pragma checksum "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96a53a69b6605e62f6a242863254e81a904c5966"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a53a69b6605e62f6a242863254e81a904c5966", @"/Views/Client/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679e8b9cb41817ef60e96e5e8087b782b5451390", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Index.cshtml"
  
    //Layout = null;

#line default
#line hidden
            BeginContext(29, 2933, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01831eb155cd44c4b023dcd074c4fde2", async() => {
                BeginContext(76, 2879, true);
                WriteLiteral(@"

    <div class=""container bg-warning border border-white rounded shadow-lg p-1 mb-5 bg-white rounded"">

        <div class=""text-center overflow-auto"">

            <div class=""card rounded border-0"">

                <div class=""card-header headNombre rounded border border-secondary shadow-sm p-1 bg-white rounded mb-2"">
                    <div class=""d-flex justify-content-center letterPagos "">Home</div>
                </div>

                <div class=""card-body p-1 mb-2"">
                    <div class="" headNombre"">
                        Rafael Solis Matos
                    </div>
                    <h5 class=""card-title titleCuenta""><span style=""color:olivedrab"" class=""titleProducto"">Cuenta Principal:</span> #203231231</h5>
                    <h6 class=""card-subtitle mb-1 text-muted"">Fecha de Adquisicion: 20/6/2020</h6>
                    <p class=""card-text  dineroAhorro"">Balance: <span class=""simboloDinero"">$</span> 201100.22</p>
                </div>
            </div>");
                WriteLiteral(@"


            <!--Cuentas de Ahorro-->
            <div class=""card w-100 text-left shadow bg-white rounded mb-3"">
                <div class=""card-body p-1"">

                    <h5 class=""card-title titleCuenta""><span style=""color:olivedrab"" class=""titleProducto"">Cuenta de Ahorro:</span> #203231231</h5>
                    <h6 class=""card-subtitle mb-1 text-muted"">Fecha de Adquisicion: 20/6/2020</h6>
                    <p class=""card-text  dineroAhorro"">Balance: <span class=""simboloDinero"">$</span> 201100.22</p>
                </div>
            </div>

            <!--Tarjeta de Credito-->
            <div class=""card w-100 text-left shadow bg-white rounded  mb-3"">
                <div class=""card-body p-1"">

                    <h5 class=""card-title titleCuenta""><span style=""color:orange"" class=""titleProducto"">Tarjeta de Credito:</span> #203231231</h5>
                    <h6 class=""card-subtitle mb-1 font-weight-bold font-italic text-info"">Fecha de Expiración: <span class=""text-dark");
                WriteLiteral(@""">26/5/2020</span></h6>
                    <p class=""card-text  dineroAhorro"">Monto: <span class=""simboloDinero"">$</span> 201100.22</p>
                </div>
            </div>


            <!--Prestamos-->
            <div class=""card w-100 text-left shadow bg-white rounded  mb-3"">
                <div class=""card-body p-1"">

                    <h5 class=""card-title titleCuenta""><span style=""color:darkred"" class=""titleProducto"">Prestamo:</span> #203231231</h5>
                    <h6 class=""card-subtitle mb-1 font-weight-bold font-italic text-info"">Fecha de Expiración: <span class=""text-dark"">26/5/2020</span></h6>
                    <p class=""card-text  dineroAhorro"">Monto: <span class=""simboloDinero"">$</span> 201100.22</p>
                </div>
            </div>



        </div>
    </div>
");
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
            BeginContext(2962, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
