#pragma checksum "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2737286a2674965a324d5866ba336a77e1e5ee01"
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
#line 1 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\_ViewImports.cshtml"
using ItlaBanking;

#line default
#line hidden
#line 2 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\_ViewImports.cshtml"
using ItlaBanking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2737286a2674965a324d5866ba336a77e1e5ee01", @"/Views/Client/Beneficiario.cshtml")]
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
            BeginContext(53, 9499, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9c2752619f64d0b8cffee2e9993ae26", async() => {
                BeginContext(100, 426, true);
                WriteLiteral(@"

    <div class=""container bg-warning border border-white rounded shadow-lg p-1 mb-5 bg-white rounded"">

        <div class=""card-header headNombre rounded border border-secondary shadow-sm p-1 bg-white rounded mb-3"">
            <div class=""d-flex justify-content-center letterPagos"">Beneficiarios</div>

        </div>

        <div class=""d-flex justify-content-center "">
            <div class=""W-100 mt-3"">

");
                EndContext();
                BeginContext(553, 1463, true);
                WriteLiteral(@"                <div class=""modal fade "" id=""tarjeta"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-dialog modal-sm"">
                        <div class=""modal-content bg-danger shadow-sm p-1 rounded"">

                            <div class=""modal-header shadow p-1 rounded"">
                                <h5 class=""modal-title text-white font-weight-bolder"" id=""staticBackdropLabel"" style=""font-size:30px;"">Tarjeta!</h5>
                                <button type=""button"" class="" btn btn-danger text-white font-weight-bolder"" data-dismiss=""modal"" aria-label=""Close""><i class=""fa fa-times"" aria-hidden=""true"" style=""font-size:24px;""></i></button>
                            </div>


                            <div class=""modal-body bg-light h6"">
                                ¿Usted esta seguro de que desea eliminar este Beneficiario?


                        ");
                WriteLiteral(@"        <div class=""form-row mt-4"">
                                    <div class=""form-group col-6"">
                                        <input type=""button"" value=""No"" style=""font-size:20px;"" data-dismiss=""modal"" class=""btn btn-outline-danger btn-block  shadow rounded"" />

                                    </div>
                                    <div class=""form-group col-6"">

                                        ");
                EndContext();
                BeginContext(2016, 516, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de7493b7e3e64bf2bcbe93e9e615fde4", async() => {
                    BeginContext(2089, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(2323, 202, true);
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
                BeginContext(2532, 214, true);
                WriteLiteral("\r\n\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n");
                EndContext();
                BeginContext(2794, 1222, true);
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
                BeginContext(4016, 924, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "058ef3245a454d1ea595087d47c4c12e", async() => {
                    BeginContext(4093, 46, true);
                    WriteLiteral("\r\n                                            ");
                    EndContext();
                    BeginContext(4139, 66, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "43d8f5701ee043c785b475a8f22bc362", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 72 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdUsuario);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    BeginWriteTagHelperAttribute();
#line 72 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
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
                    BeginContext(4205, 248, true);
                    WriteLiteral("\r\n                                            <div class=\"form-group\">\r\n                                                <label class=\"labelPago d-flex justify-content-center\">Monto a pagar: </label>\r\n                                                ");
                    EndContext();
                    BeginContext(4453, 174, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "19a0eb5250754259af6f40b97d0010d5", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 75 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
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
                    BeginContext(4627, 306, true);
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
                BeginContext(4940, 455, true);
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
                BeginContext(5395, 131, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ae0f10a03a249d49ffeaf324d72df28", async() => {
                    BeginContext(5502, 20, true);
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
                BeginContext(5526, 424, true);
                WriteLiteral(@"</th>                            
                        </tr>
                        <tr>
                            <th scope=""col""> Numero de Cuenta</th>
                            <th scope=""col"">Nombre</th>
                            <th scope=""col"">Apellido</th>
                            <th scope=""col"">⭐</th>
                        </tr>
                    </thead>
                    <tbody>

");
                EndContext();
#line 105 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                         foreach (var pampara in Model.LosBeneficiarios)
                        {

#line default
#line hidden
                BeginContext(6051, 89, true);
                WriteLiteral("                            <tr class=\"bg-primary\">\r\n                                <td>");
                EndContext();
                BeginContext(6141, 26, false);
#line 108 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                               Write(pampara.CuentaBeneficiario);

#line default
#line hidden
                EndContext();
                BeginContext(6167, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(6211, 14, false);
#line 109 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                               Write(pampara.Nombre);

#line default
#line hidden
                EndContext();
                BeginContext(6225, 43, true);
                WriteLiteral("</td>\r\n                                <td>");
                EndContext();
                BeginContext(6269, 16, false);
#line 110 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
                               Write(pampara.Apellido);

#line default
#line hidden
                EndContext();
                BeginContext(6285, 396, true);
                WriteLiteral(@"</td>
                                <td>
                                    <a data-toggle=""modal"" data-target=""#eliminarBeneficiario"" class=""text-white btn btn-danger ml-auto  btn-sm"">
                                        <i class=""fa fa-trash"" aria-hidden=""true""></i>
                                    </a>
                                </td>
                            </tr>
");
                EndContext();
                BeginContext(6713, 1660, true);
                WriteLiteral(@"                            <div class=""modal fade "" id=""eliminarBeneficiario"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" role=""dialog"" aria-labelledby=""staticBackdropLabel"" aria-hidden=""true"">
                                <div class=""modal-dialog modal-dialog"">
                                    <div class=""modal-content bg-danger shadow-sm p-1 rounded"">

                                        <div class=""modal-header shadow p-1 rounded"">
                                            <h5 class=""modal-title text-white font-weight-bolder"" id=""staticBackdropLabel"" style=""font-size:30px;"">Eliminar Beneficiario</h5>
                                            <button type=""button"" class="" btn btn-danger text-white font-weight-bolder"" data-dismiss=""modal"" aria-label=""Close""><i class=""fa fa-times"" aria-hidden=""true"" style=""font-size:24px;""></i></button>
                                        </div>


                                        <div class=""modal-body bg-light h6"">
        ");
                WriteLiteral(@"                                    ¿Usted esta seguro de que desea eliminar este Beneficiario?


                                            <div class=""form-row mt-4"">
                                                <div class=""form-group col-6"">
                                                    <input type=""button"" value=""No"" style=""font-size:20px;"" data-dismiss=""modal"" class=""btn btn-outline-danger btn-block  shadow rounded"" />

                                                </div>
                                                <div class=""form-group col-6"">

                                                    ");
                EndContext();
                BeginContext(8373, 737, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05e4aa9018ad45018fa981256ab84f24", async() => {
                    BeginContext(8451, 101, true);
                    WriteLiteral("\r\n                                                        <input name=\"IdUsuarioClient\" type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 8552, "\"", 8585, 1);
#line 141 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
WriteAttributeValue("", 8560, pampara.IdUsuarioCliente, 8560, 25, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(8586, 108, true);
                    WriteLiteral(">\r\n                                                        <input name=\"IdUsuarioBeneficiario\" type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 8694, "\"", 8732, 1);
#line 142 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
WriteAttributeValue("", 8702, pampara.IdUsuarioBeneficiario, 8702, 30, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(8733, 105, true);
                    WriteLiteral(">\r\n                                                        <input name=\"CuentaBeneficiario\" type=\"hidden\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 8838, "\"", 8873, 1);
#line 143 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"
WriteAttributeValue("", 8846, pampara.CuentaBeneficiario, 8846, 27, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(8874, 229, true);
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
                BeginContext(9110, 284, true);
                WriteLiteral(@"

                                                </div>
                                            </div>

                                        </div>

                                    </div>
                                </div>
                            </div>
");
                EndContext();
#line 155 "C:\Users\Liam\Desktop\ShitBull\Programacion 3\Miniproyecto_ItlaBanking\ItlaBanking\Views\Client\Beneficiario.cshtml"

                        }

#line default
#line hidden
                BeginContext(9423, 122, true);
                WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n\r\n\r\n            </div>\r\n        </div>\r\n\r\n        \r\n    </div>\r\n");
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
            BeginContext(9552, 4, true);
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
