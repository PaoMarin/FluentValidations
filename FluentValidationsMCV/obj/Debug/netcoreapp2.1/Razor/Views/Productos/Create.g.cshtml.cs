#pragma checksum "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b9e1e52bd9038d30bbd632268cb1a272a7ee07d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_Create), @"mvc.1.0.view", @"/Views/Productos/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Productos/Create.cshtml", typeof(AspNetCore.Views_Productos_Create))]
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
#line 1 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\_ViewImports.cshtml"
using FluentValidationsMCV;

#line default
#line hidden
#line 2 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\_ViewImports.cshtml"
using FluentValidationsMCV.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b9e1e52bd9038d30bbd632268cb1a272a7ee07d", @"/Views/Productos/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ede18089b268dab042367c599461e5af1ea25c", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FluentValidationsMVC.Models.productos>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml"
  

    ViewBag.Title = "Create";


#line default
#line hidden
            BeginContext(90, 24, true);
            WriteLiteral("\r\n<h2>Productos</h2>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml"
 using (Html.BeginForm())
{

    

#line default
#line hidden
            BeginContext(151, 28, false);
#line 14 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(183, 157, true);
            WriteLiteral("    <fieldset>\r\n\r\n            <legend>\r\n                Nombre del Producto:\r\n            </legend>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(341, 37, false);
#line 22 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml"
           Write(Html.EditorFor(model => model.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(378, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(397, 48, false);
#line 23 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.nombre));

#line default
#line hidden
            EndContext();
            BeginContext(445, 168, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <legend>\r\n                Precio:\r\n            </legend>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(614, 37, false);
#line 30 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml"
           Write(Html.EditorFor(model => model.precio));

#line default
#line hidden
            EndContext();
            BeginContext(651, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(670, 48, false);
#line 31 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.precio));

#line default
#line hidden
            EndContext();
            BeginContext(718, 168, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <legend>Descripción del Producto:\r\n            </legend>\r\n            <div class=\"editor-field\">\r\n                ");
            EndContext();
            BeginContext(887, 42, false);
#line 37 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml"
           Write(Html.EditorFor(model => model.descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(929, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(948, 53, false);
#line 38 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 151, true);
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <p>\r\n                <input type=\"submit\" value=\"Create\"/>\r\n            </p>\r\n\r\n    </fieldset>\r\n");
            EndContext();
#line 46 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml"

}

#line default
#line hidden
            BeginContext(1157, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1179, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 51 "C:\Users\joska\Documents\Paola\FluentValidationsMCV\FluentValidationsMCV\Views\Productos\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FluentValidationsMVC.Models.productos> Html { get; private set; }
    }
}
#pragma warning restore 1591
