#pragma checksum "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f0eed6dc4b0aa6019856a654db8d63d65d9f70d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paper_Arabic), @"mvc.1.0.view", @"/Views/Paper/Arabic.cshtml")]
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
#line 1 "E:\AllNews\Allnews\AllNews\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AllNews\Allnews\AllNews\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
using AllNews.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f0eed6dc4b0aa6019856a654db8d63d65d9f70d", @"/Views/Paper/Arabic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Paper_Arabic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllNews.ViewModel.PageinationViewModel<Paper>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"top-title-line mt-1\">\r\n            <h5 class=\"d-none d-md-block\">");
#nullable restore
#line 10 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                                     Write(Localizer["Arabic Papers"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <span class=\"d-md-none\">");
#nullable restore
#line 11 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                               Write(Localizer["Arabic Papers"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"top-box-hot-line\"></div>\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 20 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
     if (Model.PaginatedList != null)
    {
        var i = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
         foreach (var item in Model.PaginatedList)
        {
            ++i;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-6 col-md-3 p-1 mt-2\">\r\n                <div class=\"box-paper d-flex flex-column align-items-center justify-content-start\" data-toggle=\"modal\" data-target=\"#paper_");
#nullable restore
#line 27 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                                                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <img class=\"pin\" src=\"/img/paper-back.png\" alt=\"Alternate Text\" />\r\n                    <br />\r\n                    <br />\r\n");
#nullable restore
#line 31 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                     if (item.Image != null || item.ImageCoverPath != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                         if (item.Image != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img class=\"paper-pic\"");
            BeginWriteAttribute("src", " src=\"", 1251, "\"", 1268, 1);
#nullable restore
#line 35 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 1257, item.Image, 1257, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 36 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                         if (item.ImageCoverPath != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img class=\"paper-pic\"");
            BeginWriteAttribute("src", " src=\"", 1458, "\"", 1523, 3);
#nullable restore
#line 39 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 1464, ViewBag.AdminURL, 1464, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1481, "/Upload/Papers/Images/", 1481, 22, true);
#nullable restore
#line 39 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 1503, item.ImageCoverPath, 1503, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 40 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                         

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img class=\"paper-pic\" src=\"/img/paper-one.png\" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 46 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <br />\r\n                    <p class=\"paper-title\">");
#nullable restore
#line 48 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <span class=\"fas fa-ellipsis-h\"></span>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"modal fade \"");
            BeginWriteAttribute("id", " id=\"", 2003, "\"", 2016, 2);
            WriteAttributeValue("", 2008, "paper_", 2008, 6, true);
#nullable restore
#line 53 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 2014, i, 2014, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                <div class=""modal-dialog modal-lg modal-dialog-centered "" role=""document"">
                    <div class=""modal-content"">


                        <div class=""modal-header d-flex flex-column"">

                            <button type=""button"" class=""close-windows-modal"" data-dismiss=""modal"" aria-label=""Close""><span class=""fas fa-times""></span></button>
                            <br />
                            <div class=""img-header-object"">
                                <p>");
#nullable restore
#line 63 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                              Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                            </div>
                        </div>
                        <div class=""modal-body studies-body-modal"">

                            <div class=""paper-desc-box"">
                                <pre>
                                     ");
#nullable restore
#line 71 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                                Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </pre>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"modal-footer d-flex justify-content-center\">\r\n\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3155, "\"", 3218, 3);
#nullable restore
#line 77 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 3162, ViewBag.AdminURL, 3162, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3179, "/Upload/Papers/Downloads/", 3179, 25, true);
#nullable restore
#line 77 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 3204, item.Download, 3204, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"dl-link\">");
#nullable restore
#line 77 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                                                                                                          Write(Localizer["Download"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\" fas fa-download mr-1\"></span></a>\r\n\r\n\r\n                            <button class=\"dl-link\" data-toggle=\"collapse\" href=\"#share\" role=\"button\" aria-expanded=\"false\" aria-controls=\"share\">");
#nullable restore
#line 80 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                                                                                                                                              Write(Localizer["Share"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class="" fas fa-share-alt mr-1""></span></button>
                            <div class=""collapse share-colaps-modal"" id=""share"">
                                <div class=""card card-body d-flex"">
                                    <div class=""d-flex"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 3785, "\"", 3863, 6);
            WriteAttributeValue("", 3792, "whatsapp://send?text=", 3792, 21, true);
#nullable restore
#line 84 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 3813, item.Title, 3813, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3824, "-", 3824, 1, true);
#nullable restore
#line 84 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 3825, ViewBag.ShareURL, 3825, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3842, "/Paper/Index/", 3842, 13, true);
#nullable restore
#line 84 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 3855, item.Id, 3855, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-action=\"share/whatsapp/share\" class=\"fab fa-whatsapp text-success\"></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3985, "\"", 4076, 6);
            WriteAttributeValue("", 3992, "https://telegram.me/share/url?url=", 3992, 34, true);
#nullable restore
#line 85 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4026, item.Title, 4026, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4037, "-", 4037, 1, true);
#nullable restore
#line 85 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4038, ViewBag.ShareURL, 4038, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4055, "/Paper/Index/", 4055, 13, true);
#nullable restore
#line 85 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4068, item.Id, 4068, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fab fa-telegram text-info\"></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4160, "\"", 4240, 6);
            WriteAttributeValue("", 4167, "mailto:?=&subject=", 4167, 18, true);
#nullable restore
#line 86 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4185, item.Title, 4185, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4196, "&body=", 4196, 6, true);
#nullable restore
#line 86 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4202, ViewBag.ShareURL, 4202, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4219, "/Paper/Index/", 4219, 13, true);
#nullable restore
#line 86 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4232, item.Id, 4232, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-envelope text-secondary\"></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4329, "\"", 4431, 6);
            WriteAttributeValue("", 4336, "https://www.facebook.com/sharer/sharer.php?u=", 4336, 45, true);
#nullable restore
#line 87 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4381, item.Title, 4381, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4392, "-", 4392, 1, true);
#nullable restore
#line 87 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4393, ViewBag.ShareURL, 4393, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4410, "/Paper/Index/", 4410, 13, true);
#nullable restore
#line 87 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4423, item.Id, 4423, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fab fa-facebook text-primary\"></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4518, "\"", 4613, 6);
            WriteAttributeValue("", 4525, "https://twitter.com/intent/tweet?text=", 4525, 38, true);
#nullable restore
#line 88 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4563, item.Title, 4563, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4574, "-", 4574, 1, true);
#nullable restore
#line 88 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4575, ViewBag.ShareURL, 4575, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4592, "/Paper/Index/", 4592, 13, true);
#nullable restore
#line 88 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 4605, item.Id, 4605, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""fab fa-twitter text-info""></a>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 97 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n<hr />\r\n<div class=\"d-flex align-items-center justify-content-center\">\r\n    <div class=\"pagination pagination-sm\">\r\n\r\n        <a href=\"/Paper/Arabic?page=1\"");
            BeginWriteAttribute("class", " class=\"", 5072, "\"", 5119, 1);
#nullable restore
#line 109 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 5080, Model.CurrentPage <= 1?"disabled":"", 5080, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 109 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                                                                                  Write(Localizer["First"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 111 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
         for (int i = 1; i <= Model.TotalPage; i++)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 5228, "\"", 5256, 2);
            WriteAttributeValue("", 5235, "/Paper/Arabic?page=", 5235, 19, true);
#nullable restore
#line 114 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 5254, i, 5254, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5257, "\"", 5300, 1);
#nullable restore
#line 114 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 5265, i==Model.CurrentPage?"active":"", 5265, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 114 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 115 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 5335, "\"", 5379, 2);
            WriteAttributeValue("", 5342, "/Paper/Arabic?page=", 5342, 19, true);
#nullable restore
#line 118 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 5361, Model.TotalPage, 5361, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5380, "\"", 5441, 1);
#nullable restore
#line 118 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
WriteAttributeValue("", 5388, Model.CurrentPage >= Model.TotalPage?"disabled":"", 5388, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 118 "E:\AllNews\Allnews\AllNews\Views\Paper\Arabic.cshtml"
                                                                                                                 Write(Localizer["Last"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllNews.ViewModel.PageinationViewModel<Paper>> Html { get; private set; }
    }
}
#pragma warning restore 1591
