#pragma checksum "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d9be08cd3c1ab4d629cc95b5a0c787e40aed909"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9be08cd3c1ab4d629cc95b5a0c787e40aed909", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb69b9758a3719a097d24f7efeb2f85dcd44234f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n<div class=\"text-white text-center\">\r\n    <h3>");
#nullable restore
#line 4 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml"
   Write(Model.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <div class=\"row\">\r\n        <div class=\"col-4 text-left\" style=\"margin-left:5%\">\r\n            <label class=\"form-label\">");
#nullable restore
#line 7 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml"
                                 Write(Model.MinutesOfPlay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mins</label>\r\n            <p>");
#nullable restore
#line 8 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml"
          Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 365, "\"", 400, 2);
            WriteAttributeValue("", 371, "/image/", 371, 7, true);
#nullable restore
#line 11 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml"
WriteAttributeValue("", 378, Model.Image.ImageName, 378, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"592\" alt=\"Alternate Text\" />\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
