#pragma checksum "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcb067d2c144315c6680041d441df318c4923989"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cursos_Views_Cursos_Cursos), @"mvc.1.0.view", @"/Areas/Cursos/Views/Cursos/Cursos.cshtml")]
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
#nullable restore
#line 1 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\_ViewImports.cshtml"
using SistemasWeb.Areas.Cursos.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\_ViewImports.cshtml"
using SistemasWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcb067d2c144315c6680041d441df318c4923989", @"/Areas/Cursos/Views/Cursos/Cursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7aee442ffa9500677dd2e630b98fa351e7601ffe", @"/Areas/Cursos/Views/Cursos/_ViewImports.cshtml")]
    public class Areas_Cursos_Views_Cursos_Cursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataPaginador<TCursos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Cursos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cursos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cursos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateEstado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ModalRegistrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
  
    ViewData["Title"] = "Cursos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cursos</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcb067d2c144315c6680041d441df318c49239896404", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-xs-8 col-md-3"">
            <input id=""filtrar"" name=""Search"" placeholder=""Buscar Cursos"" class=""form-control"" />
        </div>
        <div class=""col-xs-6 col-md-3"">
            <div class=""col-md-2"">
                <button type=""submit"" class='btn btn-info'>Buscar</button>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</br>\r\n<div class=\"form-group\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <a data-toggle=\'modal\' data-target=\'#modalRegistrar\' class=\'btn btn-info text-white\'>Crear Curso</a>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcb067d2c144315c6680041d441df318c49239899084", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-5"">
                    <input type=""number"" name=""Registros"" class=""form-control"" value=""5"" min=""1"" max=""50"" step=""1"">
                </div>
                <div class=""col-md-3"">
                    <input type=""submit"" class=""btn btn-success"" value=""N Registros"">
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
           Write(Html.DisplayNameFor(model => model.Input.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
           Write(Html.DisplayNameFor(model => model.Input.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
           Write(Html.DisplayNameFor(model => model.Input.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
           Write(Html.DisplayNameFor(model => model.Input.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Opciones\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 60 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
         foreach (var item in Model.List)
        {
            var image = "data:image/jpg;base64," + Convert.ToBase64String(item.Image, 0,
                item.Image.Length);


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"tdImagen\" width=\"100px\">\r\n        <img class=\'img-fluid img-thumbnail rounded-circle\'");
            BeginWriteAttribute("src", " src=\"", 2222, "\"", 2234, 1);
#nullable restore
#line 67 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
WriteAttributeValue("", 2228, image, 2228, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bcb067d2c144315c6680041d441df318c492398914796", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2634, "\"", 2655, 1);
#nullable restore
#line 78 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
WriteAttributeValue("", 2642, item.CursoID, 2642, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 79 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
                     if (item.Estado)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"submit\" class=\"btn-sm btn-success text-light\" value=\"Activa\" />\r\n");
#nullable restore
#line 82 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"submit\" class=\"btn-sm btn-danger text-light\" value=\"No activa\" />\r\n");
#nullable restore
#line 86 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 90 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
                  
//var data = JsonConvert.SerializeObject(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a data-toggle=\'modal\' onclick=\"categorias.EditCategoria()\" data-target=\'#modal1\' class=\'btn btn-info text-white\'>Editar</a>\r\n");
            WriteLiteral("                    <a data-toggle=\'modal\' data-target=\'#ModalEliminar\' onclick=\"categorias.GetCategoria()\" class=\'btn btn-danger text-white\'>Eliminar</a>\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 98 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    Resultados ");
#nullable restore
#line 102 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
          Write(Html.Raw(Model.Pagi_info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 104 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
   Write(Html.Raw(Model.Pagi_navegacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bcb067d2c144315c6680041d441df318c492398919964", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 109 "C:\Users\SOTEC JR\Downloads\27SistemasWeb\SistemasWeb\SistemasWeb\Areas\Cursos\Views\Cursos\Cursos.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataPaginador<TCursos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
