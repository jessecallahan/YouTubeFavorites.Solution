#pragma checksum "/Users/jcallahan/Desktop/YouTubeFavorites.Solution/YouTubeFavorites/Views/YouTubePages/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8928c42ed69f5e8ccc4f54e4ba5cdc1bb1afe6cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YouTubePages_Show), @"mvc.1.0.view", @"/Views/YouTubePages/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8928c42ed69f5e8ccc4f54e4ba5cdc1bb1afe6cf", @"/Views/YouTubePages/Show.cshtml")]
    public class Views_YouTubePages_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/jcallahan/Desktop/YouTubeFavorites.Solution/YouTubeFavorites/Views/YouTubePages/Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>To Do List Page Details: </h1>\n\n<h2>");
#nullable restore
#line 7 "/Users/jcallahan/Desktop/YouTubeFavorites.Solution/YouTubeFavorites/Views/YouTubePages/Show.cshtml"
Write(Model["youtubepage"].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h3>Category: ");
#nullable restore
#line 8 "/Users/jcallahan/Desktop/YouTubeFavorites.Solution/YouTubeFavorites/Views/YouTubePages/Show.cshtml"
         Write(Model["category"].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n<a");
            BeginWriteAttribute("href", " href=\'", 153, "\'", 210, 3);
            WriteAttributeValue("", 160, "/categories/", 160, 12, true);
#nullable restore
#line 10 "/Users/jcallahan/Desktop/YouTubeFavorites.Solution/YouTubeFavorites/Views/YouTubePages/Show.cshtml"
WriteAttributeValue("", 172, Model["category"].Id, 172, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 193, "/youtubepages/new", 193, 17, true);
            EndWriteAttribute();
            WriteLiteral(">Add another page</a>\n<a href=\'/categories\'>View all categories</a>");
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