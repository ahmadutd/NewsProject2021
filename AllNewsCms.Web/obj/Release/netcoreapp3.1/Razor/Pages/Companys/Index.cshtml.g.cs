#pragma checksum "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ade8687ede2deddeecf27bb63e676b3b8676472"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AllNewsCms.Web.Pages.Companys.Pages_Companys_Index), @"mvc.1.0.razor-page", @"/Pages/Companys/Index.cshtml")]
namespace AllNewsCms.Web.Pages.Companys
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
#line 1 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\_ViewImports.cshtml"
using AllNewsCms.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\_ViewImports.cshtml"
using AllNewsCms.Web.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ade8687ede2deddeecf27bb63e676b3b8676472", @"/Pages/Companys/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d43eb727577fe58a1def6261a0397978b3126af8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Companys_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info ml-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("more-btn btn btn-light fas fa-pen-alt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("more-btn btn btn-light fas fa-trash-alt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"tab-header d-flex align-items-center alert-info p-2\">\r\n    <strong>Company List </strong>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ade8687ede2deddeecf27bb63e676b3b86764725851", async() => {
                WriteLiteral("Create Company");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    

</div>
<hr />

<div class=""row "">
    <div class=""col"">
        <input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Search"">

        <table id=""myTable"">
            <tr class=""header"">
                <th scope=""col"">#</th>
                <th scope=""col"" class=""d-none d-md-table-cell"">");
#nullable restore
#line 22 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                          Write(Html.DisplayNameFor(x => x.Companys[0].Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 23 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Companys[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\" class=\"d-none d-lg-table-cell\">");
#nullable restore
#line 24 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                          Write(Html.DisplayNameFor(x => x.Companys[0].CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">View</th>\r\n                <th scope=\"col\">Edit</th>\r\n                <th scope=\"col\">Delete</th>\r\n            </tr>\r\n");
#nullable restore
#line 29 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
             if (Model.Companys != null)
            {
                var i = 0;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                 foreach (var companys in Model.Companys)
                {
                    ++i;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                    <td scope=\"row\">");
#nullable restore
#line 36 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                     if (companys.Image != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"d-none d-md-table-cell\"><img style=\"width:30px\"");
            BeginWriteAttribute("src", " src=\"", 1444, "\"", 1465, 1);
#nullable restore
#line 39 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
WriteAttributeValue("", 1450, companys.Image, 1450, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" /></td>\r\n");
#nullable restore
#line 40 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                     if (companys.ImageCoverPath != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"d-none d-md-table-cell\"><img style=\"width:30px\"");
            BeginWriteAttribute("src", " src=\"", 1684, "\"", 1735, 2);
            WriteAttributeValue("", 1690, "/Upload/Organisation/", 1690, 21, true);
#nullable restore
#line 43 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
WriteAttributeValue("", 1711, companys.ImageCoverPath, 1711, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" /></td>\r\n");
#nullable restore
#line 44 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"font-revo\">");
#nullable restore
#line 45 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                     Write(companys.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"d-none d-lg-table-cell\">");
#nullable restore
#line 46 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                  Write(companys.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a data-toggle=\"modal\" data-target=\"#exampleModalCenter_");
#nullable restore
#line 47 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"more-btn btn btn-light fas fa-eye\"></a></td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ade8687ede2deddeecf27bb63e676b3b867647212511", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                             WriteLiteral(companys.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ade8687ede2deddeecf27bb63e676b3b867647214938", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                             WriteLiteral(companys.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n                        <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2439, "\"", 2465, 2);
            WriteAttributeValue("", 2444, "exampleModalCenter_", 2444, 19, true);
#nullable restore
#line 52 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
WriteAttributeValue("", 2463, i, 2463, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                            <div class=""modal-dialog modal-lg modal-dialog-centered rtl"" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header"">
                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                            <span aria-hidden=""true"">&times;</span>
                                        </button>
                                    </div>
                                    <div class=""modal-body"" style=""text-align:center"">

                                        <div class=""form-view p-1"">
                                            <h6 class=""alert-primary"">");
#nullable restore
#line 63 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                                 Write(Html.DisplayNameFor(x => x.Companys[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                            <span>");
#nullable restore
#line 64 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                             Write(companys.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                        </div>\r\n");
#nullable restore
#line 67 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                         if (companys.Image != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"form-view p-1\">\r\n                                                <h6 class=\"alert-primary\">");
#nullable restore
#line 70 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                                     Write(Html.DisplayNameFor(x => x.Companys[0].Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 3859, "\"", 3880, 1);
#nullable restore
#line 71 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
WriteAttributeValue("", 3865, companys.Image, 3865, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\r\n                                            </div>\r\n");
#nullable restore
#line 74 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                         if (companys.ImageCoverPath != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"form-view p-1\">\r\n                                                <h6 class=\"alert-primary\">");
#nullable restore
#line 78 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                                     Write(Html.DisplayNameFor(x => x.Companys[0].Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 4378, "\"", 4429, 2);
            WriteAttributeValue("", 4384, "/Upload/Organisation/", 4384, 21, true);
#nullable restore
#line 79 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
WriteAttributeValue("", 4405, companys.ImageCoverPath, 4405, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\r\n                                            </div>\r\n");
#nullable restore
#line 82 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"form-view p-1\">\r\n                                            <h6 class=\"alert-primary\">");
#nullable restore
#line 84 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                                 Write(Html.DisplayNameFor(x => x.Companys[0].Information));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                            <div class=\"modal-desc\">\r\n                                                <pre>");
#nullable restore
#line 86 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                Write(companys.Information);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</pre>
                                            </div>

                                        </div>

                                        <div class=""form-view p-1 d-flex"">
                                            <div class=""form-view p-1 w-50"">
                                                <h6 class=""alert-primary"">");
#nullable restore
#line 93 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                                     Write(Html.DisplayNameFor(x => x.Companys[0].CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <span>");
#nullable restore
#line 94 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                 Write(companys.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                            </div>\r\n                                            <div class=\"form-view p-1 w-50\">\r\n                                                <h6 class=\"alert-primary\">");
#nullable restore
#line 98 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                                     Write(Html.DisplayNameFor(x => x.Companys[0].CreatedUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <span>");
#nullable restore
#line 99 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                 Write(companys.CreatedUser?.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

                                            </div>
                                        </div>
                                        <div class=""form-view p-1 d-flex"">
                                            <div class=""form-view p-1 w-50"">
                                                <h6 class=""alert-primary"">");
#nullable restore
#line 105 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                                     Write(Html.DisplayNameFor(x => x.Companys[0].UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <span>");
#nullable restore
#line 106 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                 Write(companys.UpdatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                            </div>\r\n                                            <div class=\"form-view p-1 w-50\">\r\n                                                <h6 class=\"alert-primary\">");
#nullable restore
#line 110 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                                     Write(Html.DisplayNameFor(x => x.Companys[0].UpdatedUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <span>");
#nullable restore
#line 111 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                                                 Write(companys.UpdatedUser?.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>

                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </td>
                    </tr>
");
#nullable restore
#line 122 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Companys\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllNewsCms.Web.Pages.Companys.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllNewsCms.Web.Pages.Companys.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllNewsCms.Web.Pages.Companys.IndexModel>)PageContext?.ViewData;
        public AllNewsCms.Web.Pages.Companys.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
