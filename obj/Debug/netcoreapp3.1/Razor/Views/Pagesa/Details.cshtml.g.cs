#pragma checksum "C:\Users\leu\source\repos\dotnetLMS\Views\Pagesa\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8cd608f0fca16d578d7fa2676d8dac18cff3029"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagesa_Details), @"mvc.1.0.view", @"/Views/Pagesa/Details.cshtml")]
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
#line 1 "C:\Users\leu\source\repos\dotnetLMS\Views\_ViewImports.cshtml"
using Libraryms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leu\source\repos\dotnetLMS\Views\_ViewImports.cshtml"
using Libraryms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8cd608f0fca16d578d7fa2676d8dac18cff3029", @"/Views/Pagesa/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9772b91d4c7d72fb89dffe9f162861797fdfb849", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagesa_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Libraryms.Models.Pagesa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("}\r\n<div>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 6 "C:\Users\leu\source\repos\dotnetLMS\Views\Pagesa\Details.cshtml"
           Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 7 "C:\Users\leu\source\repos\dotnetLMS\Views\Pagesa\Details.cshtml"
           Write(Model.shuma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 8 "C:\Users\leu\source\repos\dotnetLMS\Views\Pagesa\Details.cshtml"
           Write(Model.Klienti_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 9 "C:\Users\leu\source\repos\dotnetLMS\Views\Pagesa\Details.cshtml"
           Write(Model.Active);

#line default
#line hidden
#nullable disable
            WriteLiteral("/td>\r\n");
#nullable restore
#line 10 "C:\Users\leu\source\repos\dotnetLMS\Views\Pagesa\Details.cshtml"
              
                ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("             <td>");
#nullable restore
#line 12 "C:\Users\leu\source\repos\dotnetLMS\Views\Pagesa\Details.cshtml"
            Write(Model.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            </tr>\r\n        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Libraryms.Models.Pagesa> Html { get; private set; }
    }
}
#pragma warning restore 1591
