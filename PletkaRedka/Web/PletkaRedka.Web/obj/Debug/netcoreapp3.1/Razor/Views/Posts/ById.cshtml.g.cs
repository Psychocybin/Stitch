#pragma checksum "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Posts\ById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe413b9f608b7866560f85f86c1288869fda1c15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_ById), @"mvc.1.0.view", @"/Views/Posts/ById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe413b9f608b7866560f85f86c1288869fda1c15", @"/Views/Posts/ById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aea13cfa353c0c8fa21c0b905909d5b39959117", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_ById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PletkaRedka.Web.ViewModels.Posts.PostViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Posts\ById.cshtml"
  
    this.ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"media border border-info rounded col-9\">\r\n    <img src=\"/snimka2.jpg\" width=\"100\" class=\"mr-3\" alt=\"TEST\">\r\n    <div class=\"media-body\">\r\n        <h5 class=\"mt-0\">");
#nullable restore
#line 9 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Posts\ById.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        ");
#nullable restore
#line 10 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Posts\ById.cshtml"
   Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"text-muted ml-3\">\r\n        <div class=\"list-group-item-action\">\r\n            <div>\r\n                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 462, "\"", 497, 4);
            WriteAttributeValue("", 472, "sendVote(", 472, 9, true);
#nullable restore
#line 15 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Posts\ById.cshtml"
WriteAttributeValue("", 481, Model.Id, 481, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 490, ",", 490, 1, true);
            WriteAttributeValue(" ", 491, "true)", 492, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fa fa-thumbs-up\"></i>\r\n                </a>\r\n            </div>\r\n            <div id=\"votesCount\">");
#nullable restore
#line 19 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Posts\ById.cshtml"
                            Write(Model.VotesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>\r\n                <a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 700, "\"", 736, 4);
            WriteAttributeValue("", 710, "sendVote(", 710, 9, true);
#nullable restore
#line 21 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Posts\ById.cshtml"
WriteAttributeValue("", 719, Model.Id, 719, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 728, ",", 728, 1, true);
            WriteAttributeValue(" ", 729, "false)", 730, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    <i class=""fa fa-thumbs-down""></i>
                </a>
            </div>
        </div>
    </div>
</div>
<p class=""text-sm-left"">
    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-file-person"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
        <path fill-rule=""evenodd"" d=""M12 1H4a1 1 0 0 0-1 1v10.755S4 11 8 11s5 1.755 5 1.755V2a1 1 0 0 0-1-1zM4 0a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h8a2 2 0 0 0 2-2V2a2 2 0 0 0-2-2H4z"" />
        <path fill-rule=""evenodd"" d=""M8 10a3 3 0 1 0 0-6 3 3 0 0 0 0 6z"" />
    </svg>");
#nullable restore
#line 32 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Posts\ById.cshtml"
     Write(Model.UserUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;<span class=\"text-sm-right\"><i class=\"far fa-clock\"></i>");
#nullable restore
#line 32 "C:\Users\user\Desktop\Stitch\PletkaRedka\Web\PletkaRedka.Web\Views\Posts\ById.cshtml"
                                                                                       Write(Model.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</p>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function sendVote(postId, isUpVote) {
            var token = $(""#votesForm input[name=__RequestVerificationToken]"").val();
            var json = { postId: postId, isUpVote: isUpVote };
            $.ajax({
                url: ""/api/votes"",
                type: ""POST"",
                data: JSON.stringify(json),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                headers: { 'X-CSRF-TOKEN': token },
                success: function (data) {
                    $(""#votesCount"").html(data.votesCount);
                }
            });
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PletkaRedka.Web.ViewModels.Posts.PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
