#pragma checksum "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4271205ef8bdcfbaa8b6144b3f68288835d3ed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AllNewsCms.Web.Pages.Photos.Pages_Photos_Delete), @"mvc.1.0.razor-page", @"/Pages/Photos/Delete.cshtml")]
namespace AllNewsCms.Web.Pages.Photos
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4271205ef8bdcfbaa8b6144b3f68288835d3ed6", @"/Pages/Photos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d43eb727577fe58a1def6261a0397978b3126af8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Photos_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Delete/Delete.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-auto p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"tab-header-delete alert-danger d-flex align-items-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f4271205ef8bdcfbaa8b6144b3f68288835d3ed65649", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <strong>Are you sure you want to delete this section?</strong>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4271205ef8bdcfbaa8b6144b3f68288835d3ed66852", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f4271205ef8bdcfbaa8b6144b3f68288835d3ed67126", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 13 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Photos.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr />\r\n<div class=\"row\" style=\"text-align:center\">\r\n\r\n    <div class=\"col-12\">\r\n        <div class=\"form-delete p-2\">\r\n            <h6 class=\"alert-danger\">");
#nullable restore
#line 25 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
                                Write(Html.DisplayNameFor(x => x.Photos.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <span>");
#nullable restore
#line 26 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
             Write(Model.Photos.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
     if (Model.Photos.Image != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12\">\r\n            <div class=\"form-delete p-2\">\r\n\r\n                <h6 class=\"alert-danger\">");
#nullable restore
#line 35 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
                                    Write(Html.DisplayNameFor(x => x.Photos.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1131, "\"", 1156, 1);
#nullable restore
#line 36 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
WriteAttributeValue("", 1137, Model.Photos.Image, 1137, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 39 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
     if (Model.Photos.ImageCoverPath != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12\">\r\n            <div class=\"form-delete p-2\">\r\n\r\n                <h6 class=\"alert-danger\">");
#nullable restore
#line 45 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
                                    Write(Html.DisplayNameFor(x => x.Photos.ImageCoverPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f4271205ef8bdcfbaa8b6144b3f68288835d3ed612779", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1479, "~/Upload/Photos/", 1479, 16, true);
#nullable restore
#line 46 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
AddHtmlAttributeValue("", 1495, Model.Photos.ImageCoverPath, 1495, 28, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 49 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
     if (Model.Photos.Description != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12\">\r\n            <div class=\"form-delete p-2\">\r\n                <h6 class=\"alert-danger\">");
#nullable restore
#line 54 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
                                    Write(Html.DisplayNameFor(x => x.Photos.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <span>");
#nullable restore
#line 55 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
                 Write(Model.Photos.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 59 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-12 col-md-6\">\r\n        <div class=\"form-delete p-2\">\r\n            <h6 class=\"alert-danger\">");
#nullable restore
#line 63 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
                                Write(Html.DisplayNameFor(x => x.Photos.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <b>");
#nullable restore
#line 64 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
          Write(Model.Photos.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"col-12 col-md-6\">\r\n        <div class=\"form-delete p-2\">\r\n            <h6 class=\"alert-danger\">");
#nullable restore
#line 70 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
                                Write(Html.DisplayNameFor(x => x.Photos.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <b>");
#nullable restore
#line 71 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
          Write(Model.Photos.CreatedUser?.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"col-12 col-md-6\">\r\n        <div class=\"form-delete p-2\">\r\n            <h6 class=\"alert-danger\">");
#nullable restore
#line 77 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
                                Write(Html.DisplayNameFor(x => x.Photos.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <b>");
#nullable restore
#line 78 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
          Write(Model.Photos.UpdatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"col-12 col-md-6\">\r\n        <div class=\"form-delete p-2\">\r\n            <h6 class=\"alert-danger\">");
#nullable restore
#line 84 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
                                Write(Html.DisplayNameFor(x => x.Photos.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <b>");
#nullable restore
#line 85 "E:\AllNews\Allnews\AllNewsCms.Web\Pages\Photos\Delete.cshtml"
          Write(Model.Photos.UpdatedUser?.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllNewsCms.Web.Pages.Photos.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllNewsCms.Web.Pages.Photos.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllNewsCms.Web.Pages.Photos.DeleteModel>)PageContext?.ViewData;
        public AllNewsCms.Web.Pages.Photos.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
