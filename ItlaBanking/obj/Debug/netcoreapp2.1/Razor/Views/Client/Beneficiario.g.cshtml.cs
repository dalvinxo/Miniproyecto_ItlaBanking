#pragma checksum "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01ce31828f40e394759dc9b7ab9d60fe96e9e519"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Beneficiario), @"mvc.1.0.view", @"/Views/Client/Beneficiario.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Beneficiario.cshtml", typeof(AspNetCore.Views_Client_Beneficiario))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01ce31828f40e394759dc9b7ab9d60fe96e9e519", @"/Views/Client/Beneficiario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"679e8b9cb41817ef60e96e5e8087b782b5451390", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Beneficiario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItlaBanking.ViewModels.BeneficiarioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Producto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTarjeta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-lg rounded-pill border border-dark shadow-lg p-3  bg-white rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Ingresar Monto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AgregarBeneficiario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBeneficiario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success  btn-block text-white mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EliminarBeneficiario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("CardViewFormulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 10697, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79d3561ca11b40baa32880fcfe8b8d1f", async() => {
                BeginContext(100, 559, true);
                WriteLiteral(@"

    <div class=""container bg-warning border border-white rounded shadow-lg p-1 mb-5 bg-white rounded"">

        <div class=""card-header headNombre rounded border border-secondary shadow-sm p-1 bg-white rounded mb-3"">
            <a data-toggle=""modal"" data-target=""#agg"" class=""btn btn-success mr-auto  btn-sm text-white"">Agregar Beneficiario</a>

            <div class=""d-flex justify-content-center letterPagos"">Beneficiarios</div>

        </div>

        <div class=""d-flex justify-content-center "">
            <div class=""W-100 mt-3"">

");
                EndContext();
                BeginContext(686, 1469, true);
                WriteLiteral(@"                <div class=""modal fade "" id=""tarjeta"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-dialog modal-sm"">
                        <div class=""modal-content bg-danger shadow-sm p-1 rounded"">

                            <div class=""modal-header shadow p-1 rounded"">
                                <h5 class=""modal-title text-white font-weight-bolder"" id=""staticBackdropLabel"" style=""font-size:30px;"">Tarjeta!</h5>
                                <button type=""button"" class="" btn btn-danger text-white font-weight-bolder"" data-dismiss=""modal"" aria-label=""Close""><i class=""fa fa-times"" aria-hidden=""true"" style=""font-size:24px;""></i></button>
                            </div>


                            <div class=""modal-body bg-light h6"">
                                ¿Usted esta seguro de que desea eliminar este Tarjeta de crédito?


                  ");
                WriteLiteral(@"              <div class=""form-row mt-4"">
                                    <div class=""form-group col-6"">
                                        <input type=""button"" value=""No"" style=""font-size:20px;"" data-dismiss=""modal"" class=""btn btn-outline-danger btn-block  shadow rounded"" />

                                    </div>
                                    <div class=""form-group col-6"">

                                        ");
                EndContext();
                BeginContext(2155, 516, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b135a83c86d540ee81ed902ea2672dff", async() => {
                    BeginContext(2228, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(2462, 202, true);
                    WriteLiteral("                                            <input value=\"Si\" type=\"submit\" style=\"font-size:20px;\" class=\"btn btn-outline-primary btn-block  shadow rounded\" />\r\n                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2671, 214, true);
                WriteLiteral("\r\n\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n");
                EndContext();
                BeginContext(2933, 1222, true);
                WriteLiteral(@"
                <div class=""modal fade "" id=""agg"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-dialog modal-sm"">
                        <div class=""modal-content bg-danger shadow-sm p-1 rounded"">

                            <div class=""modal-header shadow p-1 rounded"">
                                <h5 class=""modal-title text-white font-weight-bolder"" id=""staticBackdropLabel"" style=""font-size:30px;"">Beneficiarios</h5>
                                <button type=""button"" class="" btn btn-danger text-white font-weight-bolder"" data-dismiss=""modal"" aria-label=""Close""><i class=""fa fa-times"" aria-hidden=""true"" style=""font-size:24px;""></i></button>
                            </div>


                            <div class=""modal-body bg-light h6"">
                                Ingrese el numero de cuenta para agregar en su lista de beneficiarios


           ");
                WriteLiteral("                     <div class=\"form-row mt-4\">\r\n                                    \r\n                                    <div class=\"form-group col-6\">\r\n\r\n                                        ");
                EndContext();
                BeginContext(4155, 924, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "326f023c667b41568e7634771f41b597", async() => {
                    BeginContext(4232, 46, true);
                    WriteLiteral("\r\n                                            ");
                    EndContext();
                    BeginContext(4278, 66, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ec8b9f31a1f144558f471d904bf47b96", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 74 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdUsuario);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    BeginWriteTagHelperAttribute();
#line 74 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                                                                                WriteLiteral(Model.IdUsuario);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4344, 248, true);
                    WriteLiteral("\r\n                                            <div class=\"form-group\">\r\n                                                <label class=\"labelPago d-flex justify-content-center\">Monto a pagar: </label>\r\n                                                ");
                    EndContext();
                    BeginContext(4592, 174, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9807010e81ca450093293fc71192fdad", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 77 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NumeroCuenta);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4766, 306, true);
                    WriteLiteral(@"

                                            </div>                                           
                                            <input value=""Agregar"" type=""submit"" style=""font-size:20px;"" class=""btn btn-outline-primary btn-block  shadow rounded"" />
                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5079, 455, true);
                WriteLiteral(@"

                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>
                </div>


                <table class=""table table-striped table-dark text-center shadow rounded table-borderless"">
                    <thead>
                        <tr>                            
                            <th colspan=""4"">");
                EndContext();
                BeginContext(5534, 131, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c58151314b19495c9b7b5ec7666e5fe5", async() => {
                    BeginContext(5641, 20, true);
                    WriteLiteral("Agregar Beneficiario");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5665, 438, true);
                WriteLiteral(@"</th>                            
                        </tr>
                        <tr>
                            <th scope=""col""> Numero de Cuenta</th>
                            <th scope=""col"">Nombre</th>
                            <th scope=""col"">Apellido</th>
<<<<<<< HEAD
                            <th scope=""col"">⭐</th>
                        </tr>
                    </thead>
                    <tbody>

");
                EndContext();
#line 108 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                         foreach (var pampara in Model.LosBeneficiarios)
                        {

#line default
#line hidden
                BeginContext(6204, 89, true);
                WriteLiteral("                            <tr class=\"bg-primary\">\r\n                                <td>");
                EndContext();
                BeginContext(6294, 26, false);
#line 111 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                               Write(pampara.CuentaBeneficiario);

#line default
#line hidden
                EndContext();
                BeginContext(6320, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(6364, 14, false);
#line 112 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                               Write(pampara.Nombre);

#line default
#line hidden
                EndContext();
                BeginContext(6378, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(6422, 16, false);
#line 113 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                               Write(pampara.Apellido);

#line default
#line hidden
                EndContext();
                BeginContext(6438, 396, true);
                WriteLiteral(@"</td>
                                <td>
                                    <a data-toggle=""modal"" data-target=""#eliminarBeneficiario"" class=""text-white btn btn-danger ml-auto  btn-sm"">
                                        <i class=""fa fa-trash"" aria-hidden=""true""></i>
                                    </a>
                                </td>
                            </tr>
");
                EndContext();
                BeginContext(6866, 1666, true);
                WriteLiteral(@"                            <div class=""modal fade "" id=""eliminarBeneficiario"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
                                <div class=""modal-dialog modal-dialog"">
                                    <div class=""modal-content bg-danger shadow-sm p-1 rounded"">

                                        <div class=""modal-header shadow p-1 rounded"">
                                            <h5 class=""modal-title text-white font-weight-bolder"" id=""staticBackdropLabel"" style=""font-size:30px;"">Eliminar Beneficiario</h5>
                                            <button type=""button"" class="" btn btn-danger text-white font-weight-bolder"" data-dismiss=""modal"" aria-label=""Close""><i class=""fa fa-times"" aria-hidden=""true"" style=""font-size:24px;""></i></button>
                                        </div>


                                        <div class=""modal-body bg-light h6"">
        ");
                WriteLiteral(@"                                    ¿Usted esta seguro de que desea eliminar este Tarjeta de crédito?


                                            <div class=""form-row mt-4"">
                                                <div class=""form-group col-6"">
                                                    <input type=""button"" value=""No"" style=""font-size:20px;"" data-dismiss=""modal"" class=""btn btn-outline-danger btn-block  shadow rounded"" />

                                                </div>
                                                <div class=""form-group col-6"">

                                                    ");
                EndContext();
                BeginContext(8532, 737, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1901eb047c1b4a078c0b02b55d2d4e9f", async() => {
                    BeginContext(8610, 101, true);
                    WriteLiteral("\r\n                                                        <input name=\"IdUsuarioClient\" type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 8711, "\"", 8744, 1);
#line 144 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
WriteAttributeValue("", 8719, pampara.IdUsuarioCliente, 8719, 25, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(8745, 108, true);
                    WriteLiteral(">\r\n                                                        <input name=\"IdUsuarioBeneficiario\" type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 8853, "\"", 8891, 1);
#line 145 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
WriteAttributeValue("", 8861, pampara.IdUsuarioBeneficiario, 8861, 30, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(8892, 105, true);
                    WriteLiteral(">\r\n                                                        <input name=\"CuentaBeneficiario\" type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 8997, "\"", 9032, 1);
#line 146 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
WriteAttributeValue("", 9005, pampara.CuentaBeneficiario, 9005, 27, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(9033, 229, true);
                    WriteLiteral(">\r\n                                                        <input value=\"Si\" type=\"submit\" style=\"font-size:20px;\" class=\"btn btn-outline-primary btn-block  shadow rounded\" />\r\n                                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9269, 284, true);
                WriteLiteral(@"

                                                </div>
                                            </div>

                                        </div>

                                    </div>
                                </div>
                            </div>
");
                EndContext();
#line 158 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"

                        }

#line default
#line hidden
                BeginContext(9582, 150, true);
                WriteLiteral("=======\r\n\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n                        <tr class=\"bg-primary\">\r\n");
                EndContext();
#line 166 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                             foreach (var bene in Model.cuenta)
                            {

#line default
#line hidden
                BeginContext(9828, 48, true);
                WriteLiteral("                                <th scope=\"row\">");
                EndContext();
                BeginContext(9877, 17, false);
#line 168 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                                           Write(bene.NumeroCuenta);

#line default
#line hidden
                EndContext();
                BeginContext(9894, 7, true);
                WriteLiteral("</th>\r\n");
                EndContext();
#line 169 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                            }

#line default
#line hidden
                BeginContext(9932, 28, true);
                WriteLiteral("                            ");
                EndContext();
#line 170 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                             foreach (var usu in Model.usuario)
                            {

#line default
#line hidden
                BeginContext(10028, 36, true);
                WriteLiteral("                                <td>");
                EndContext();
                BeginContext(10065, 10, false);
#line 172 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                               Write(usu.Nombre);

#line default
#line hidden
                EndContext();
                BeginContext(10075, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(10119, 12, false);
#line 173 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                               Write(usu.Apellido);

#line default
#line hidden
                EndContext();
                BeginContext(10131, 348, true);
                WriteLiteral(@"</td>
                                <td>
                                    <a data-toggle=""modal"" data-target=""#tarjeta"" class=""text-white btn btn-danger ml-auto  btn-sm"">
                                        <i class=""fa fa-trash"" aria-hidden=""true""></i>
                                    </a>
                                </td>
");
                EndContext();
#line 179 "C:\Users\Pablo Molina\source\repos\ItlaBankings\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                            }

#line default
#line hidden
                BeginContext(10510, 233, true);
                WriteLiteral("                            </tr>\r\n                        \r\n>>>>>>> 210e86134700a8d31e8b4e3eefbf3645b79adb5e\r\n\r\n                    </tbody>\r\n                </table>\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n        \r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10750, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItlaBanking.ViewModels.BeneficiarioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
