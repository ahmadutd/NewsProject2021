#pragma checksum "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6804fe70fb26511b8c75b9e9f6ceff2f48c74e51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Library_Index), @"mvc.1.0.view", @"/Views/Library/Index.cshtml")]
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
#line 1 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
using AllNews.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6804fe70fb26511b8c75b9e9f6ceff2f48c74e51", @"/Views/Library/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Library_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllNews.ViewModel.PageinationViewModel<Studies>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"top-title-line mt-1\">\r\n            <h5 class=\"d-none d-md-block\">");
#nullable restore
#line 10 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                     Write(Localizer["Studies"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <span class=\"d-md-none\">");
#nullable restore
#line 11 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                               Write(Localizer["Studies"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"top-box-hot-line\"></div>\r\n    </div>\r\n</div>\r\n<br />\r\n<div class=\"container p-2\">\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 20 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
         if (Model.PaginatedList != null)
        {
            var i = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
             foreach (var item in Model.PaginatedList)
            {
                ++i;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-6 col-md-2 p-1\">\r\n                    <div class=\"studies-box\">\r\n                        <div class=\"image-relativ\">\r\n                            \r\n                            \r\n");
#nullable restore
#line 32 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                             if (item.Image != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 1062, "\"", 1079, 1);
#nullable restore
#line 34 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 1068, item.Image, 1068, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 35 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                             if (item.ImageCoverPath != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <img");
            BeginWriteAttribute("src", " src=\"", 1267, "\"", 1333, 3);
#nullable restore
#line 38 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 1273, ViewBag.AdminURL, 1273, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1290, "/Upload/Studies/Images/", 1290, 23, true);
#nullable restore
#line 38 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 1313, item.ImageCoverPath, 1313, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 39 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \r\n                        <div class=\"overlay d-flex flex-column align-items-center justify-content-center\">\r\n\r\n                            <button class=\"dl-link\" data-toggle=\"modal\" data-target=\"#exampleModalCenter_");
#nullable restore
#line 43 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 43 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                                                                                        Write(Localizer["View"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\" fas fa-eye mr-1\"></span></button>\r\n                            <br />\r\n                            <a class=\"dl-link\"");
            BeginWriteAttribute("href", " href=\"", 1790, "\"", 1858, 3);
#nullable restore
#line 45 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 1797, ViewBag.AdminURL, 1797, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1814, "/Upload/Studies/Downloads/", 1814, 26, true);
#nullable restore
#line 45 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 1840, item.DownloadLink, 1840, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                                                                                               Write(Localizer["Download"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class="" fas fa-download mr-1""></span></a>
                            <br />
                            
                            <div class=""dropdown"" id=""share"">
                                <button class=""dl-link dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                     ");
#nullable restore
#line 50 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                Write(Localizer["Share"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class="" fas fa-share-alt mr-1 ml-1""></span>
                                </button>
                                <div class=""dropdown-menu share-colaps-book dropdown-menu-center"" aria-labelledby=""dropdownMenuButton"">
                                    <div class=""d-flex"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 2627, "\"", 2728, 6);
            WriteAttributeValue("", 2634, "whatsapp://send?text=", 2634, 21, true);
#nullable restore
#line 54 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 2655, item.Title, 2655, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2666, "-", 2666, 1, true);
#nullable restore
#line 54 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 2667, ViewBag.AdminURL, 2667, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2684, "/Upload/Studies/Downloads/", 2684, 26, true);
#nullable restore
#line 54 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 2710, item.DownloadLink, 2710, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-action=\"share/whatsapp/share\"><span class=\"fab fa-whatsapp text-success\"></span></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2863, "\"", 2956, 6);
            WriteAttributeValue("", 2870, "https://telegram.me/share/url?url=", 2870, 34, true);
#nullable restore
#line 55 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 2904, item.Title, 2904, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2915, "-", 2915, 1, true);
#nullable restore
#line 55 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 2916, ViewBag.ShareURL, 2916, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2933, "/Library/Index/", 2933, 15, true);
#nullable restore
#line 55 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 2948, item.Id, 2948, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"fab fa-telegram text-info\"></span></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3053, "\"", 3135, 6);
            WriteAttributeValue("", 3060, "mailto:?=&subject=", 3060, 18, true);
#nullable restore
#line 56 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 3078, item.Title, 3078, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3089, "&body=", 3089, 6, true);
#nullable restore
#line 56 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 3095, ViewBag.ShareURL, 3095, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3112, "/Library/Index/", 3112, 15, true);
#nullable restore
#line 56 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 3127, item.Id, 3127, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"fas fa-envelope text-secondary\"></span></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3237, "\"", 3341, 6);
            WriteAttributeValue("", 3244, "https://www.facebook.com/sharer/sharer.php?u=", 3244, 45, true);
#nullable restore
#line 57 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 3289, item.Title, 3289, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3300, "-", 3300, 1, true);
#nullable restore
#line 57 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 3301, ViewBag.ShareURL, 3301, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3318, "/Library/Index/", 3318, 15, true);
#nullable restore
#line 57 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 3333, item.Id, 3333, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"fab fa-facebook text-primary\"></span></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3441, "\"", 3538, 6);
            WriteAttributeValue("", 3448, "https://twitter.com/intent/tweet?text=", 3448, 38, true);
#nullable restore
#line 58 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 3486, item.Title, 3486, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3497, "-", 3497, 1, true);
#nullable restore
#line 58 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 3498, ViewBag.ShareURL, 3498, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3515, "/Library/Index/", 3515, 15, true);
#nullable restore
#line 58 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 3530, item.Id, 3530, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><span class=""fab fa-twitter text-info""></span></a>
                                    </div>
                                </div>

                            </div>




                        </div>
                        </div>
                        <div class=""studies-option d-flex justify-content-center"">
                            <img src=""/img/BookLogo.png"" alt=""Alternate Text"" />
                        </div>

                    </div>

                </div>
");
            WriteLiteral("                <div class=\"modal fade \"");
            BeginWriteAttribute("id", " id=\"", 4082, "\"", 4108, 2);
            WriteAttributeValue("", 4087, "exampleModalCenter_", 4087, 19, true);
#nullable restore
#line 77 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 4106, i, 4106, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-lg modal-dialog-centered"" role=""document"">
                        <div class=""modal-content"">


                            <div class=""modal-header p-0"">
                                <button type=""button"" class=""close-windows-modal"" data-dismiss=""modal"" aria-label=""Close""><span class=""fas fa-times""></span></button>

                                <div class=""img-header-object d-flex align-items-center"">


");
#nullable restore
#line 88 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                     if (item.Image != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img");
            BeginWriteAttribute("src", " src=\"", 4822, "\"", 4839, 1);
#nullable restore
#line 90 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 4828, item.Image, 4828, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 91 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                     if (item.ImageCoverPath != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <img");
            BeginWriteAttribute("src", " src=\"", 5059, "\"", 5125, 3);
#nullable restore
#line 94 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 5065, ViewBag.AdminURL, 5065, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5082, "/Upload/Studies/Images/", 5082, 23, true);
#nullable restore
#line 94 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 5105, item.ImageCoverPath, 5105, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 95 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <p>");
#nullable restore
#line 97 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
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
#line 106 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </pre>\r\n                                </div>\r\n                            </div>\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 115 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"





            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n<hr />\r\n<div class=\"d-flex align-items-center justify-content-center\">\r\n    <div class=\"pagination pagination-sm\">\r\n\r\n        <a href=\"/Library?page=1\"");
            BeginWriteAttribute("class", " class=\"", 5996, "\"", 6043, 1);
#nullable restore
#line 134 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 6004, Model.CurrentPage <= 1?"disabled":"", 6004, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 134 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                                                             Write(Localizer["First"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 136 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
         for (int i = 1; i <= Model.TotalPage; i++)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 6152, "\"", 6175, 2);
            WriteAttributeValue("", 6159, "/Library?page=", 6159, 14, true);
#nullable restore
#line 139 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 6173, i, 6173, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 6176, "\"", 6219, 1);
#nullable restore
#line 139 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 6184, i==Model.CurrentPage?"active":"", 6184, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 139 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 140 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 6254, "\"", 6293, 2);
            WriteAttributeValue("", 6261, "/Library?page=", 6261, 14, true);
#nullable restore
#line 143 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 6275, Model.TotalPage, 6275, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 6294, "\"", 6355, 1);
#nullable restore
#line 143 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
WriteAttributeValue("", 6302, Model.CurrentPage >= Model.TotalPage?"disabled":"", 6302, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 143 "E:\AllNews\Allnews\AllNews\Views\Library\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllNews.ViewModel.PageinationViewModel<Studies>> Html { get; private set; }
    }
}
#pragma warning restore 1591
