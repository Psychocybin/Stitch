#pragma checksum "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Videos\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efa861325403344deb7f4af7f03087cba5c3e0fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Videos_ById), @"mvc.1.0.view", @"/Views/Videos/ById.cshtml")]
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
#line 1 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\_ViewImports.cshtml"
using PletkaRedka.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\_ViewImports.cshtml"
using PletkaRedka.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efa861325403344deb7f4af7f03087cba5c3e0fc", @"/Views/Videos/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aea13cfa353c0c8fa21c0b905909d5b39959117", @"/Views/_ViewImports.cshtml")]
    public class Views_Videos_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PletkaRedka.Web.ViewModels.Videos.ShowAllVideos>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Videos\ById.cshtml"
  
    this.ViewData["Title"] = "Видеа";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-center mt-2 mb-4\">");
#nullable restore
#line 6 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Videos\ById.cshtml"
                             Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Videos\ById.cshtml"
         foreach (var video in Model.Videos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-6 mt-2\">\r\n                <div class=\"blog_inner_matter\">\r\n                    <div class=\"youtube\">\r\n                        <iframe width=\"300\"");
            BeginWriteAttribute("src", " src=\"", 457, "\"", 478, 1);
#nullable restore
#line 15 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Videos\ById.cshtml"
WriteAttributeValue("", 463, video.VideoUrl, 463, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" class=\"wow fadeInDown animated\"></iframe>\r\n                    </div>\r\n                    <h3 class=\"wow fadeInDown animated\"><a>");
#nullable restore
#line 17 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Videos\ById.cshtml"
                                                      Write(video.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                    <p class=\"wow fadeInDown animated\">");
#nullable restore
#line 18 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Videos\ById.cshtml"
                                                  Write(video.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 21 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Videos\ById.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PletkaRedka.Web.ViewModels.Videos.ShowAllVideos> Html { get; private set; }
    }
}
#pragma warning restore 1591
