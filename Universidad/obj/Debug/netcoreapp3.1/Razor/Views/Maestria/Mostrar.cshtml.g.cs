#pragma checksum "C:\Users\Usuario\source\repos\Tarea3ASP\Ejercicio3\Universidad\Views\Maestria\Mostrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6737851c9fbd2fefe0372b01208ab4efb2f4a01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Maestria_Mostrar), @"mvc.1.0.view", @"/Views/Maestria/Mostrar.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\Tarea3ASP\Ejercicio3\Universidad\Views\_ViewImports.cshtml"
using Universidad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\Tarea3ASP\Ejercicio3\Universidad\Views\_ViewImports.cshtml"
using Universidad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6737851c9fbd2fefe0372b01208ab4efb2f4a01", @"/Views/Maestria/Mostrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5c84e73cd8d39b1e7af3d46894082cdad095f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Maestria_Mostrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Maestria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agregar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Usuario\source\repos\Tarea3ASP\Ejercicio3\Universidad\Views\Maestria\Mostrar.cshtml"
  
    ViewData["Title"] = "Mostrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Maestrias</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6737851c9fbd2fefe0372b01208ab4efb2f4a013723", async() => {
                WriteLiteral("Agregar Maestria");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Id</th>\r\n            <th scope=\"col\">Nombre</th>\r\n            <th scope=\"col\">Duracion</th>\r\n     \r\n          \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Usuario\source\repos\Tarea3ASP\Ejercicio3\Universidad\Views\Maestria\Mostrar.cshtml"
         foreach (Maestria maestria in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 27 "C:\Users\Usuario\source\repos\Tarea3ASP\Ejercicio3\Universidad\Views\Maestria\Mostrar.cshtml"
                Write(maestria.ID_Maestria);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td scope=\"row\">");
#nullable restore
#line 28 "C:\Users\Usuario\source\repos\Tarea3ASP\Ejercicio3\Universidad\Views\Maestria\Mostrar.cshtml"
                           Write(maestria.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td scope=\"row\">");
#nullable restore
#line 29 "C:\Users\Usuario\source\repos\Tarea3ASP\Ejercicio3\Universidad\Views\Maestria\Mostrar.cshtml"
                           Write(maestria.Duracion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n             \r\n                <td scope=\"row\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\Usuario\source\repos\Tarea3ASP\Ejercicio3\Universidad\Views\Maestria\Mostrar.cshtml"
               Write(Html.ActionLink("Editar", "Edit", new { id = maestria.ID_Maestria }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 34 "C:\Users\Usuario\source\repos\Tarea3ASP\Ejercicio3\Universidad\Views\Maestria\Mostrar.cshtml"
               Write(Html.ActionLink("Eliminar", "Delete", new { id = maestria.ID_Maestria }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Usuario\source\repos\Tarea3ASP\Ejercicio3\Universidad\Views\Maestria\Mostrar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Maestria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
