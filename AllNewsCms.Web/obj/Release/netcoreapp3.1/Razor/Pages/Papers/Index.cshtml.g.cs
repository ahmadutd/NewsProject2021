#pragma checksum "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87073f3c8a1f6e44e37fa6c65ea790c22a316752"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AllNewsCms.Web.Pages.Papers.Pages_Papers_Index), @"mvc.1.0.razor-page", @"/Pages/Papers/Index.cshtml")]
namespace AllNewsCms.Web.Pages.Papers
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87073f3c8a1f6e44e37fa6c65ea790c22a316752", @"/Pages/Papers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d43eb727577fe58a1def6261a0397978b3126af8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Papers_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info ml-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary m-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("filterNewsCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("more-btn btn btn-light fas fa-pen-alt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("more-btn btn btn-light fas fa-trash-alt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"tab-header d-flex align-items-center alert-info p-2\">\r\n    <strong>Paper List </strong>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87073f3c8a1f6e44e37fa6c65ea790c22a3167527372", async() => {
                WriteLiteral("Create Paper");
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
<div class=""row"">
    <div class=""col-12 col-md-6"">
        <input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Search"">
    </div>
    <div class=""col-12 col-md-6 d-flex align-items-center justify-content-center"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87073f3c8a1f6e44e37fa6c65ea790c22a3167529095", async() => {
                WriteLiteral("<span class=\"fas fa-grip-horizontal\"></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 21 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
         foreach (var filterbtn in Model.CategoryPapers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87073f3c8a1f6e44e37fa6c65ea790c22a31675210635", async() => {
#nullable restore
#line 23 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                                                                                                  Write(filterbtn.CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                      WriteLiteral(filterbtn.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
AddHtmlAttributeValue("", 877, filterbtn.Id, 877, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 24 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        \r\n\r\n        <table id=\"myTable\">\r\n            <tr class=\"header\">\r\n                <th scope=\"col\">#</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 36 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Papers[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\" class=\" d-none d-md-table-cell\">");
#nullable restore
#line 37 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                           Write(Html.DisplayNameFor(x => x.Papers[0].Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\" class=\"d-none d-lg-table-cell\">");
#nullable restore
#line 38 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                          Write(Html.DisplayNameFor(x => x.Papers[0].CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">View</th>\r\n                <th scope=\"col\">Edit</th>\r\n                <th scope=\"col\">Delete</th>\r\n            </tr>\r\n");
#nullable restore
#line 43 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
             if (Model.Papers != null)
            {
                var i = 0;
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                 foreach (var papers in Model.Papers)
                {
                    ++i;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td scope=\"row\">");
#nullable restore
#line 50 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"font-revo\">");
#nullable restore
#line 51 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                         Write(papers.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"font-revo d-none d-md-table-cell\">");
#nullable restore
#line 52 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                Write(papers?.Category?.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"d-none d-lg-table-cell\">");
#nullable restore
#line 53 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                      Write(papers.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a data-toggle=\"modal\" data-target=\"#exampleModalCenter_");
#nullable restore
#line 54 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"more-btn btn btn-light fas fa-eye\"></a></td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87073f3c8a1f6e44e37fa6c65ea790c22a31675217481", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                 WriteLiteral(papers.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87073f3c8a1f6e44e37fa6c65ea790c22a31675219912", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                 WriteLiteral(papers.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n                            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2637, "\"", 2663, 2);
            WriteAttributeValue("", 2642, "exampleModalCenter_", 2642, 19, true);
#nullable restore
#line 59 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
WriteAttributeValue("", 2661, i, 2661, 2, false);

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
#line 70 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                     Write(Html.DisplayNameFor(x => x.Papers[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                <span>");
#nullable restore
#line 71 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                 Write(papers.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                            </div>\r\n");
#nullable restore
#line 74 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                             if (papers.Image != null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"form-view p-1\">\r\n                                                    <h6 class=\"alert-primary\">");
#nullable restore
#line 77 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                         Write(Html.DisplayNameFor(x => x.Papers[0].Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                    <img");
            BeginWriteAttribute("src", " src=\"", 4117, "\"", 4136, 1);
#nullable restore
#line 78 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
WriteAttributeValue("", 4123, papers.Image, 4123, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\r\n                                                </div>\r\n");
#nullable restore
#line 81 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                             if (papers.ImageCoverPath != null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"form-view p-1\">\r\n                                                    <h6 class=\"alert-primary\">");
#nullable restore
#line 85 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                         Write(Html.DisplayNameFor(x => x.Papers[0].Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                    <img");
            BeginWriteAttribute("src", " src=\"", 4658, "\"", 4708, 2);
            WriteAttributeValue("", 4664, "/Upload/Papers/Images/", 4664, 22, true);
#nullable restore
#line 86 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
WriteAttributeValue("", 4686, papers.ImageCoverPath, 4686, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n\r\n                                                </div>\r\n");
#nullable restore
#line 89 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        \r\n");
#nullable restore
#line 91 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                             if (papers.Description != null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"form-view p-1\">\r\n                                                    <h6 class=\"alert-primary\">");
#nullable restore
#line 94 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                         Write(Html.DisplayNameFor(x => x.Papers[0].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                                                    <div class=\"modal-desc\">\r\n                                                        <pre>");
#nullable restore
#line 97 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                        Write(papers.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 100 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                             if (papers.Download != null)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"form-view p-1\">\r\n                                                    <h6 class=\"alert-primary\">");
#nullable restore
#line 104 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                         Write(Html.DisplayNameFor(x => x.Papers[0].Download));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87073f3c8a1f6e44e37fa6c65ea790c22a31675229775", async() => {
                WriteLiteral("Download");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5963, "~/Upload/Papers/Downloads/", 5963, 26, true);
#nullable restore
#line 105 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
AddHtmlAttributeValue("", 5989, papers.Download, 5989, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                                </div>\r\n");
#nullable restore
#line 108 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <div class=\"form-view p-1 d-flex\">\r\n                                                <div class=\"form-view p-1 w-50\">\r\n                                                    <h6 class=\"alert-primary\">");
#nullable restore
#line 112 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                         Write(Html.DisplayNameFor(x => x.Papers[0].CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                    <span>");
#nullable restore
#line 113 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                     Write(papers.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                                </div>\r\n                                                <div class=\"form-view p-1 w-50\">\r\n                                                    <h6 class=\"alert-primary\">");
#nullable restore
#line 117 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                         Write(Html.DisplayNameFor(x => x.Papers[0].CreatedUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                    <span>");
#nullable restore
#line 118 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                     Write(papers.CreatedUser?.UserName);

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
#line 124 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                         Write(Html.DisplayNameFor(x => x.Papers[0].UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                    <span>");
#nullable restore
#line 125 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                     Write(papers.UpdatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                                </div>\r\n                                                <div class=\"form-view p-1 w-50\">\r\n                                                    <h6 class=\"alert-primary\">");
#nullable restore
#line 129 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                                         Write(Html.DisplayNameFor(x => x.Papers[0].UpdatedUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                                    <span>");
#nullable restore
#line 130 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                                                     Write(papers.UpdatedUser?.UserName);

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
#line 141 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Papers\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllNewsCms.Web.Pages.Papers.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllNewsCms.Web.Pages.Papers.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllNewsCms.Web.Pages.Papers.IndexModel>)PageContext?.ViewData;
        public AllNewsCms.Web.Pages.Papers.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
