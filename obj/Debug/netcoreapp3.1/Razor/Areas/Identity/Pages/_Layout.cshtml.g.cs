#pragma checksum "C:\Users\dell\Downloads\PracticaJigsaw\PracticaJigsaw\PracticaJigsaw\Areas\Identity\Pages\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd343711f04bce6783856199960c768129d3b990"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_Layout.cshtml")]
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
#line 1 "C:\Users\dell\Downloads\PracticaJigsaw\PracticaJigsaw\PracticaJigsaw\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\Downloads\PracticaJigsaw\PracticaJigsaw\PracticaJigsaw\Areas\Identity\Pages\_ViewImports.cshtml"
using PracticaJigsaw.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\Downloads\PracticaJigsaw\PracticaJigsaw\PracticaJigsaw\Areas\Identity\Pages\_ViewImports.cshtml"
using PracticaJigsaw.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\Downloads\PracticaJigsaw\PracticaJigsaw\PracticaJigsaw\Areas\Identity\Pages\_ViewImports.cshtml"
using PracticaJigsaw.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd343711f04bce6783856199960c768129d3b990", @"/Areas/Identity/Pages/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815acc7283f7f2272004b23d92fefc8a4eb0560b", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\dell\Downloads\PracticaJigsaw\PracticaJigsaw\PracticaJigsaw\Areas\Identity\Pages\_Layout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <div class=""card login-logout-tabs"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs "">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Login'>Ingresar</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href='/Identity/Account/Register'>Registro</a>
                    </li>
                </ul>
            </div>



            <div class=""card-content"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        ");
#nullable restore
#line 24 "C:\Users\dell\Downloads\PracticaJigsaw\PracticaJigsaw\PracticaJigsaw\Areas\Identity\Pages\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 36 "C:\Users\dell\Downloads\PracticaJigsaw\PracticaJigsaw\PracticaJigsaw\Areas\Identity\Pages\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <script>\r\n$(function (){\r\nvar current = location.pathname;\r\n$(\'.nav-tabs li a\').each(function () {\r\nvar $this = $(this);\r\nif (current.indexOf($this.attr(\'href\')) !== -1) {\r\n$this.addClass(\'active\');\r\n}\r\n})\r\n})\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
