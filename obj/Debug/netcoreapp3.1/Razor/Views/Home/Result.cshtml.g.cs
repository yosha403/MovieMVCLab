#pragma checksum "C:\Users\YKunnummal\source\FrontEnd\MovieMVC\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20b1c35f33a3b96e1da08d320cf1072ebbae74d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "C:\Users\YKunnummal\source\FrontEnd\MovieMVC\Views\_ViewImports.cshtml"
using MovieMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YKunnummal\source\FrontEnd\MovieMVC\Views\_ViewImports.cshtml"
using MovieMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20b1c35f33a3b96e1da08d320cf1072ebbae74d7", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01163e14bf44c5c41c2eff6cc1cab684a4b7ef9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h3><b>");
#nullable restore
#line 4 "C:\Users\YKunnummal\source\FrontEnd\MovieMVC\Views\Home\Result.cshtml"
  Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> has been registered!</h3>\r\n<p>ID: ");
#nullable restore
#line 5 "C:\Users\YKunnummal\source\FrontEnd\MovieMVC\Views\Home\Result.cshtml"
  Write(Model.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Title: ");
#nullable restore
#line 6 "C:\Users\YKunnummal\source\FrontEnd\MovieMVC\Views\Home\Result.cshtml"
     Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Genre: ");
#nullable restore
#line 7 "C:\Users\YKunnummal\source\FrontEnd\MovieMVC\Views\Home\Result.cshtml"
     Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Year: ");
#nullable restore
#line 8 "C:\Users\YKunnummal\source\FrontEnd\MovieMVC\Views\Home\Result.cshtml"
    Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Actors: ");
#nullable restore
#line 9 "C:\Users\YKunnummal\source\FrontEnd\MovieMVC\Views\Home\Result.cshtml"
      Write(Model.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Directors: ");
#nullable restore
#line 10 "C:\Users\YKunnummal\source\FrontEnd\MovieMVC\Views\Home\Result.cshtml"
         Write(Model.Directors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
