#pragma checksum "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4105c4d9d5f2c523a9910b7a557e35af1743ce4f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4105c4d9d5f2c523a9910b7a557e35af1743ce4f", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb69b9758a3719a097d24f7efeb2f85dcd44234f", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 3 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml"
 if(Model != null)
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-white text-center\">\r\n    <h3>");
#nullable restore
#line 6 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml"
   Write(Model.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <div class=\"row\">\r\n        <div class=\"col-4 text-left\" style=\"margin-left:5%\">\r\n            <label class=\"form-label\">");
#nullable restore
#line 9 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml"
                                 Write(Model.MinutesOfPlay);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mins</label>\r\n            <p>");
#nullable restore
#line 10 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml"
          Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 389, "\"", 424, 2);
            WriteAttributeValue("", 395, "/image/", 395, 7, true);
#nullable restore
#line 13 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml"
WriteAttributeValue("", 402, Model.Image.ImageName, 402, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"592\" alt=\"Alternate Text\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 17 "F:\Projekti\ProjectCinema\ProjectCinema\Views\Movie\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
