#pragma checksum "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d73246eb43b59d88e321c0484ff0eb06b8e63647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorldNews_Index), @"mvc.1.0.view", @"/Views/WorldNews/Index.cshtml")]
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
#line 1 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
using AllNews.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d73246eb43b59d88e321c0484ff0eb06b8e63647", @"/Views/WorldNews/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_WorldNews_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllNews.ViewModel.PageinationViewModel<News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NewsPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("politic-card"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    <br />\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"top-title-line mt-1\">\r\n            <h5 class=\"d-none d-md-block\">");
#nullable restore
#line 10 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                                     Write(Localizer["WorldNews"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <span class=\"d-md-none\">");
#nullable restore
#line 11 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                               Write(Localizer["WorldNews"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"top-box-hot-line\"></div>\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"row \">\r\n");
#nullable restore
#line 18 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
     foreach (var item in Model.PaginatedList)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-6 col-md-3 p-1\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d73246eb43b59d88e321c0484ff0eb06b8e636475729", async() => {
                WriteLiteral("\r\n                <div class=\"img-card-box\">\r\n");
#nullable restore
#line 24 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                     if (item.FirstImage != null || item.ImageCoverPath != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                         if (item.FirstImage != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 1004, "\"", 1026, 1);
#nullable restore
#line 28 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
WriteAttributeValue("", 1010, item.FirstImage, 1010, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 29 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                         if (item.ImageCoverPath != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 1198, "\"", 1261, 3);
#nullable restore
#line 32 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
WriteAttributeValue("", 1204, ViewBag.AdminURL, 1204, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1221, "/Upload/News/Images/", 1221, 20, true);
#nullable restore
#line 32 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
WriteAttributeValue("", 1241, item.ImageCoverPath, 1241, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 33 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                         
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                         if (item.Video != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 1496, "\"", 1554, 3);
                WriteAttributeValue("", 1502, "https://img.youtube.com/vi/", 1502, 27, true);
#nullable restore
#line 39 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
WriteAttributeValue("", 1529, item.Video, 1529, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1540, "/mqdefault.jpg", 1540, 14, true);
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 40 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                         if (item.VideoCoverPath != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 1726, "\"", 1785, 3);
#nullable restore
#line 43 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
WriteAttributeValue("", 1732, ViewBag.AdminURL, 1732, 17, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1749, "/Upload/News/VideoImg/", 1749, 22, true);
#nullable restore
#line 43 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
WriteAttributeValue("", 1771, item.VideoImg, 1771, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 44 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 47 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                     if (item.Video != null || item.VideoCoverPath != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <span class=\"video-avatar fab fa-youtube text-white\"></span>\r\n");
#nullable restore
#line 50 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                    }
                    else
                    {

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"news-card-text-box\">\r\n\r\n                    <h6 class=\"card-text-news\">\r\n                        ");
#nullable restore
#line 59 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h6>\r\n                </div>\r\n                <div class=\"date-box d-flex align-items-center justify-content-start\">\r\n\r\n                    <span class=\"fas fa-calendar-alt\"></span>\r\n                    <span class=\"datetime-now\">");
#nullable restore
#line 65 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
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
#line 22 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
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
#line 69 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<hr />\r\n<div class=\"d-flex align-items-center justify-content-center\">\r\n    <div class=\"pagination pagination-sm\">\r\n\r\n        <a href=\"/WorldNews?page=1\"");
            BeginWriteAttribute("class", " class=\"", 2816, "\"", 2863, 1);
#nullable restore
#line 77 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
WriteAttributeValue("", 2824, Model.CurrentPage <= 1?"disabled":"", 2824, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 77 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                                                                               Write(Localizer["First"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 79 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
         for (int i = 1; i <= Model.TotalPage; i++)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 2972, "\"", 2997, 2);
            WriteAttributeValue("", 2979, "/WorldNews?page=", 2979, 16, true);
#nullable restore
#line 82 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
WriteAttributeValue("", 2995, i, 2995, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2998, "\"", 3041, 1);
#nullable restore
#line 82 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
WriteAttributeValue("", 3006, i==Model.CurrentPage?"active":"", 3006, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                                                                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 83 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 3076, "\"", 3117, 2);
            WriteAttributeValue("", 3083, "/WorldNews?page=", 3083, 16, true);
#nullable restore
#line 86 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
WriteAttributeValue("", 3099, Model.TotalPage, 3099, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3118, "\"", 3179, 1);
#nullable restore
#line 86 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
WriteAttributeValue("", 3126, Model.CurrentPage >= Model.TotalPage?"disabled":"", 3126, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 86 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\WorldNews\Index.cshtml"
                                                                                                              Write(Localizer["Last"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n\r\n    </div>\r\n</div>\r\n<br />");
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
