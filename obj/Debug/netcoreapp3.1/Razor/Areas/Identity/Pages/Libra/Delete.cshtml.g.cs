#pragma checksum "C:\Users\leu\Source\Repos\dotnetLMS\Areas\Identity\Pages\Libra\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06222efdf7f32b510f524b8d7eb17c5a81bc07ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Libra_Delete), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Libra/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06222efdf7f32b510f524b8d7eb17c5a81bc07ad", @"/Areas/Identity/Pages/Libra/Delete.cshtml")]
    public class Areas_Identity_Pages_Libra_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\leu\Source\Repos\dotnetLMS\Areas\Identity\Pages\Libra\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Libra</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\leu\Source\Repos\dotnetLMS\Areas\Identity\Pages\Libra\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Libra.Titulli));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\leu\Source\Repos\dotnetLMS\Areas\Identity\Pages\Libra\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Libra.Titulli));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\leu\Source\Repos\dotnetLMS\Areas\Identity\Pages\Libra\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Libra.Autori));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\leu\Source\Repos\dotnetLMS\Areas\Identity\Pages\Libra\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Libra.Autori));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\leu\Source\Repos\dotnetLMS\Areas\Identity\Pages\Libra\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Libra.E_Lire));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\leu\Source\Repos\dotnetLMS\Areas\Identity\Pages\Libra\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Libra.E_Lire));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form method=\"post\">\r\n        <input type=\"hidden\" asp-for=\"Libra.id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-page=\"./Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Libraryms.Areas.Identity.Pages.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Libraryms.Areas.Identity.Pages.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Libraryms.Areas.Identity.Pages.DeleteModel>)PageContext?.ViewData;
        public Libraryms.Areas.Identity.Pages.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
