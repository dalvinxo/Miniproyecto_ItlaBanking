#pragma checksum "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3193cea32384b2d03f3a9805ccbc3efc585e2dc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_PagosTarjeta), @"mvc.1.0.view", @"/Views/Client/PagosTarjeta.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/PagosTarjeta.cshtml", typeof(AspNetCore.Views_Client_PagosTarjeta))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3193cea32384b2d03f3a9805ccbc3efc585e2dc9", @"/Views/Client/PagosTarjeta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679e8b9cb41817ef60e96e5e8087b782b5451390", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_PagosTarjeta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItlaBanking.ViewModels.PagosViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-select custom-select-lg mb-3 rounded-pill shadow bg-white rounded border border-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("0.01"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("step", new global::Microsoft.AspNetCore.Html.HtmlString("0.01"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-lg rounded-pill border border-dark shadow-lg p-3  bg-white rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ingresar Monto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PagosTarjeta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("CardViewFormulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(56, 2824, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291bd3fcdb054155b03b8049460c9fbf", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fb4d89ea0eb40a39aadf1396edb4a51", async() => {
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527
                BeginContext(103, 376, true);
                WriteLiteral(@"

    <div class=""container bg-warning border border-white rounded shadow-lg p-1 mb-5 bg-white rounded"">
        <div>
            <div class=""card-header headNombre rounded border border-secondary shadow-sm p-1 bg-white rounded mb-3"">
                <div class=""d-flex justify-content-center letterPagos"">Pagos Tarjeta de Crédito</div>
            </div>
            ");
                EndContext();
                BeginContext(479, 2356, false);
<<<<<<< HEAD
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb7d7f4df3044cd4853ac6927ff9a595", async() => {
=======
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "261443e4371647ea9c450418ed6c489c", async() => {
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527
                    BeginContext(549, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(567, 66, false);
<<<<<<< HEAD
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d5cf548ae504a73b93287b3350cf1a7", async() => {
=======
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3c846d9e9f04f2aa5e904906308c07e", async() => {
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 12 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(633, 231, true);
                    WriteLiteral("\r\n\r\n                <div class=\"form-row\">\r\n                    <div class=\"form-group col-md-6\">\r\n                        <label class=\"labelPago ml-3\">Seleccionar cuenta de la tarjeta de credito:</label>\r\n                        ");
                    EndContext();
                    BeginContext(864, 494, false);
<<<<<<< HEAD
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c6df90b7df4345c6b75e461ea961132f", async() => {
=======
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf01535f9ab8402c8be7bdb64b7e6ccb", async() => {
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527
                        BeginContext(1005, 30, true);
                        WriteLiteral("\r\n                            ");
                        EndContext();
                        BeginContext(1035, 47, false);
<<<<<<< HEAD
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03bd6159bf084d05aa2a1b2ff546089a", async() => {
=======
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e14f1b59e7c452cb8ca139829ad25ff", async() => {
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527
                            BeginContext(1062, 11, true);
                            WriteLiteral("Seleccionar");
                            EndContext();
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        BeginWriteTagHelperAttribute();
                        __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                        __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1082, 2, true);
                        WriteLiteral("\r\n");
                        EndContext();
#line 19 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
                             foreach (var tarjetas in Model.tarjetas)
                            {

#line default
#line hidden
                        BeginContext(1186, 32, true);
                        WriteLiteral("                                ");
                        EndContext();
                        BeginContext(1218, 72, false);
<<<<<<< HEAD
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be2d7dcf0f9e44ebba9795d23a3b1361", async() => {
=======
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e58501a0c90647b99a54baeb86a86a2a", async() => {
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527
                            BeginContext(1259, 22, false);
#line 21 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
                                                                   Write(tarjetas.NumeroTarjeta);

#line default
#line hidden
                            EndContext();
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                        BeginWriteTagHelperAttribute();
#line 21 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
                                   WriteLiteral(tarjetas.NumeroTarjeta);

#line default
#line hidden
                        __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                        __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1290, 2, true);
                        WriteLiteral("\r\n");
                        EndContext();
#line 22 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
                            }

#line default
#line hidden
                        BeginContext(1323, 26, true);
                        WriteLiteral("\r\n                        ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 17 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NumeroCuentaPagar);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1358, 209, true);
                    WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"form-group col-md-6\">\r\n                        <label class=\"labelPago ml-3\">¿Desde que cuenta la quiere pagar?</label>\r\n                        ");
                    EndContext();
                    BeginContext(1567, 477, false);
<<<<<<< HEAD
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8bff69a2a3e4aa6a58ee987e94c9bc4", async() => {
=======
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1ba698aba664aad89306eabea666cb9", async() => {
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527
                        BeginContext(1703, 30, true);
                        WriteLiteral("\r\n                            ");
                        EndContext();
                        BeginContext(1733, 47, false);
<<<<<<< HEAD
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d18f2ee4f5f495f9720ec38e5268880", async() => {
=======
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb297c1fc7624b588b1331dda441d221", async() => {
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527
                            BeginContext(1760, 11, true);
                            WriteLiteral("Seleccionar");
                            EndContext();
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        BeginWriteTagHelperAttribute();
                        __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                        __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1780, 2, true);
                        WriteLiteral("\r\n");
                        EndContext();
#line 31 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
                             foreach (var cuenta in Model.cuenta)
                            {

#line default
#line hidden
                        BeginContext(1880, 32, true);
                        WriteLiteral("                                ");
                        EndContext();
                        BeginContext(1912, 66, false);
<<<<<<< HEAD
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "494b6e22a96647968555b5d05097123e", async() => {
=======
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0b1d2268c06491eb2b0c81af5ac4d85", async() => {
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527
                            BeginContext(1950, 19, false);
#line 33 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
                                                                Write(cuenta.NumeroCuenta);

#line default
#line hidden
                            EndContext();
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                        BeginWriteTagHelperAttribute();
#line 33 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
                                   WriteLiteral(cuenta.NumeroCuenta);

#line default
#line hidden
                        __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                        __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                        __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1978, 2, true);
                        WriteLiteral("\r\n");
                        EndContext();
#line 34 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
                            }

#line default
#line hidden
                        BeginContext(2011, 24, true);
                        WriteLiteral("                        ");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 29 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NumeroCuenta);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2044, 295, true);
                    WriteLiteral(@"
                    </div>


                </div>

                <div class=""d-flex justify-content-center"">
                    <div class=""form-group"">
                        <label class=""labelPago d-flex justify-content-center"">Monto a pagar: </label>
                        ");
                    EndContext();
                    BeginContext(2339, 190, false);
<<<<<<< HEAD
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b63c760fa8684c6aa98e7c01a368a933", async() => {
=======
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7963c306ca94432b84fd014465165906", async() => {
>>>>>>> 69028b1c1de789fdf32b721a6036c1e941488527
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 44 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\PagosTarjeta.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Monto);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2529, 299, true);
                    WriteLiteral(@"
                    </div>
                </div>


                <div class=""d-flex justify-content-center mt-3 mb-2"">
                    <input type=""submit"" value=""Pagar"" class=""btn btn-outline-success font-weight-bold  shadow-lg rounded w-25"">

                </div>

            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2835, 38, true);
                WriteLiteral("\r\n\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2880, 13, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItlaBanking.ViewModels.PagosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
