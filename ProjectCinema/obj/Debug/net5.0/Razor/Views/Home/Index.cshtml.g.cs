#pragma checksum "F:\Projekti\ProjectCinema\ProjectCinema\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f84ee4456373f026abbb91b32c5e16953e27453d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "F:\Projekti\ProjectCinema\ProjectCinema\Views\_ViewImports.cshtml"
using ProjectCinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projekti\ProjectCinema\ProjectCinema\Views\_ViewImports.cshtml"
using ProjectCinema.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f84ee4456373f026abbb91b32c5e16953e27453d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb69b9758a3719a097d24f7efeb2f85dcd44234f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-md-12\"  >\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12 pr-0 pl-0\">\r\n            ");
#nullable restore
#line 8 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Banner"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n");
            WriteLiteral("        </div>        \r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-12 text-left m-3\" style=\"background-color: white; max-width: 93.5%\" >      \r\n            ");
#nullable restore
#line 18 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Home\Index.cshtml"
       Write(await Component.InvokeAsync("Movie", new SearchMovieViewModel()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>      \r\n</div>\r\n");
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
