#pragma checksum "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Galleries\ShowAllPictures.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b425106422dc3e082e5483c70a81b42ab5b862dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Galleries_ShowAllPictures), @"mvc.1.0.view", @"/Views/Galleries/ShowAllPictures.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b425106422dc3e082e5483c70a81b42ab5b862dd", @"/Views/Galleries/ShowAllPictures.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aea13cfa353c0c8fa21c0b905909d5b39959117", @"/Views/_ViewImports.cshtml")]
    public class Views_Galleries_ShowAllPictures : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PletkaRedka.Web.ViewModels.Galleries.ShowPicturesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Galleries\ShowAllPictures.cshtml"
  
    this.ViewData["Title"] = "Снимки";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nbingo\r\n\r\n");
#nullable restore
#line 8 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Galleries\ShowAllPictures.cshtml"
 foreach (var picture in Model.Galleries)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>");
#nullable restore
#line 10 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Galleries\ShowAllPictures.cshtml"
    Write(picture.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 11 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Galleries\ShowAllPictures.cshtml"
    


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PletkaRedka.Web.ViewModels.Galleries.ShowPicturesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
