#pragma checksum "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f18e05ddc1103782f564e6925bfe7d164eca602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlArabia_Index), @"mvc.1.0.view", @"/Views/AlArabia/Index.cshtml")]
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
#line 1 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
using AllNews.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f18e05ddc1103782f564e6925bfe7d164eca602", @"/Views/AlArabia/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_AlArabia_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllNews.ViewModel.PageinationViewModel<News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NewsPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("our-news-card"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"top-title-line mt-1\">\r\n            <h5 class=\"d-none d-md-block\">");
#nullable restore
#line 10 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                                     Write(Localizer["ArabNews"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <span class=\"d-md-none\">");
#nullable restore
#line 11 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                               Write(Localizer["ArabNews"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"top-box-hot-line\"></div>\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row \">\r\n");
#nullable restore
#line 18 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
     foreach (var item in Model.PaginatedList)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-6 col-md-3 p-1\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f18e05ddc1103782f564e6925bfe7d164eca6025705", async() => {
                WriteLiteral("\r\n                <div class=\"img-card-box\">\r\n");
#nullable restore
#line 23 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                     if (item.FirstImage != null || item.ImageCoverPath != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                         if (item.FirstImage != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 991, "\"", 1013, 1);
#nullable restore
#line 27 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
WriteAttributeValue("", 997, item.FirstImage, 997, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 28 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                         if (item.ImageCoverPath != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 1185, "\"", 1248, 3);
#nullable restore
#line 31 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
WriteAttributeValue("", 1191, ViewBag.AdminURL, 1191, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1208, "/Upload/News/Images/", 1208, 20, true);
#nullable restore
#line 31 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
WriteAttributeValue("", 1228, item.ImageCoverPath, 1228, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 32 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                         
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                         if (item.Video != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 1483, "\"", 1542, 3);
                WriteAttributeValue("", 1489, "https://img.youtube.com/vi/", 1489, 27, true);
#nullable restore
#line 38 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
WriteAttributeValue("", 1516, item.Video, 1516, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1527, "?/mqdefault.jpg", 1527, 15, true);
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 39 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                         if (item.VideoCoverPath != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 1714, "\"", 1773, 3);
#nullable restore
#line 42 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
WriteAttributeValue("", 1720, ViewBag.AdminURL, 1720, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1737, "/Upload/News/VideoImg/", 1737, 22, true);
#nullable restore
#line 42 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
WriteAttributeValue("", 1759, item.VideoImg, 1759, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 43 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 46 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                     if (item.Video != null || item.VideoCoverPath != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <span class=\"video-avatar fab fa-youtube text-white\"></span>\r\n");
#nullable restore
#line 49 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                    }
                    else
                    {

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"news-card-text-box\">\r\n\r\n                    <h6 class=\"card-text-news\">\r\n                        ");
#nullable restore
#line 58 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h6>\r\n                </div>\r\n                <div class=\"date-box d-flex align-items-center justify-content-start\">\r\n                    <span class=\"fas fa-calendar-alt\"></span>\r\n                    <span class=\"datetime-now\">");
#nullable restore
#line 63 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                                          Write(item.UpdatedDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 67 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<hr />\r\n<div class=\"d-flex align-items-center justify-content-center\">\r\n\r\n    <div class=\"pagination pagination-sm\">\r\n\r\n        <a href=\"/AlArabia?page=1\"");
            BeginWriteAttribute("class", " class=\"", 2801, "\"", 2848, 1);
#nullable restore
#line 75 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
WriteAttributeValue("", 2809, Model.CurrentPage <= 1?"disabled":"", 2809, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 75 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                                                                              Write(Localizer["First"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 77 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
         for (int i = 1; i <= Model.TotalPage; i++)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 2957, "\"", 2981, 2);
            WriteAttributeValue("", 2964, "/AlArabia?page=", 2964, 15, true);
#nullable restore
#line 80 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
WriteAttributeValue("", 2979, i, 2979, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2982, "\"", 3025, 1);
#nullable restore
#line 80 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
WriteAttributeValue("", 2990, i==Model.CurrentPage?"active":"", 2990, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 80 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 81 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3060, "\"", 3100, 2);
            WriteAttributeValue("", 3067, "/AlArabia?page=", 3067, 15, true);
#nullable restore
#line 84 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
WriteAttributeValue("", 3082, Model.TotalPage, 3082, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3101, "\"", 3162, 1);
#nullable restore
#line 84 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
WriteAttributeValue("", 3109, Model.CurrentPage >= Model.TotalPage?"disabled":"", 3109, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 84 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\AlArabia\Index.cshtml"
                                                                                                             Write(Localizer["Last"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n<br />");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllNews.ViewModel.PageinationViewModel<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
