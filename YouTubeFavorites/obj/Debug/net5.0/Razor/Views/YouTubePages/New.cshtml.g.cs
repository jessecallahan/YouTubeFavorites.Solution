#pragma checksum "/Users/jcallahan/Desktop/YouTubeFavorites.Solution/YouTubeFavorites/Views/YouTubePages/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a8b364906010f7f3c241daca0393f9f8b6b4b63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_YouTubePages_New), @"mvc.1.0.view", @"/Views/YouTubePages/New.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a8b364906010f7f3c241daca0393f9f8b6b4b63", @"/Views/YouTubePages/New.cshtml")]
    public class Views_YouTubePages_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/jcallahan/Desktop/YouTubeFavorites.Solution/YouTubeFavorites/Views/YouTubePages/New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Add a new page to ");
#nullable restore
#line 5 "/Users/jcallahan/Desktop/YouTubeFavorites.Solution/YouTubeFavorites/Views/YouTubePages/New.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<form");
            BeginWriteAttribute("action", " action=\"", 73, "\"", 109, 3);
            WriteAttributeValue("", 82, "/categories/", 82, 12, true);
#nullable restore
#line 7 "/Users/jcallahan/Desktop/YouTubeFavorites.Solution/YouTubeFavorites/Views/YouTubePages/New.cshtml"
WriteAttributeValue("", 94, Model.Id, 94, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 103, "/pages", 103, 6, true);
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\n  <input id=\"categoryId\" name=\"categoryId\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 182, "\"", 199, 1);
#nullable restore
#line 8 "/Users/jcallahan/Desktop/YouTubeFavorites.Solution/YouTubeFavorites/Views/YouTubePages/New.cshtml"
WriteAttributeValue("", 190, Model.Id, 190, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
  <label for=""pageTitle"">Page Title</label>
  <input id=""pageTitle"" name=""pageTitle"" type=""text"">
  <label for=""pageDescription"">Page Description</label>
  <input id=""pageDescription"" name=""pageDescription"" type=""text"">
  <label for=""pageLink"">Page Link</label>
  <input id=""pageLink"" name=""pageLink"" type=""text"">
  <button type='submit'>Add Item</button>
</form>");
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