#pragma checksum "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16deba22c24056b4858dbdb675754c6d5f56aa86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paper_Index), @"mvc.1.0.view", @"/Views/Paper/Index.cshtml")]
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
#line 1 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
using AllNews.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16deba22c24056b4858dbdb675754c6d5f56aa86", @"/Views/Paper/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Paper_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllNews.ViewModel.PageinationViewModel<Paper>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"top-title-line mt-1\">\r\n            <h5 class=\"d-none d-md-block\">");
#nullable restore
#line 10 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                     Write(Localizer["Paper"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <span class=\"d-md-none\">");
#nullable restore
#line 11 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                               Write(Localizer["Paper"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"top-box-hot-line\"></div>\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 20 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
     if (Model.PaginatedList != null)
    {
        var i = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
         foreach (var item in Model.PaginatedList)
        {
            ++i;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-6 col-md-3 p-1 mt-2\">\r\n                <div class=\"box-paper d-flex flex-column align-items-center justify-content-start\" data-toggle=\"modal\" data-target=\"#paper_");
#nullable restore
#line 27 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <img class=\"pin\" src=\"/img/paper-back.png\" alt=\"Alternate Text\" />\r\n                    <br />\r\n                    <br />\r\n");
#nullable restore
#line 31 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                     if (item.Image != null || item.ImageCoverPath != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                         if (item.Image != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img class=\"paper-pic\"");
            BeginWriteAttribute("src", " src=\"", 1235, "\"", 1252, 1);
#nullable restore
#line 35 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 1241, item.Image, 1241, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 36 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                         if (item.ImageCoverPath != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img class=\"paper-pic\"");
            BeginWriteAttribute("src", " src=\"", 1442, "\"", 1507, 3);
#nullable restore
#line 39 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 1448, ViewBag.AdminURL, 1448, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1465, "/Upload/Papers/Images/", 1465, 22, true);
#nullable restore
#line 39 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 1487, item.ImageCoverPath, 1487, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 40 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                         

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img class=\"paper-pic\" src=\"/img/paper-one.png\" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 46 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br />\r\n                    <p class=\"paper-title\">");
#nullable restore
#line 48 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <span class=\"fas fa-ellipsis-h\"></span>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"modal fade \"");
            BeginWriteAttribute("id", " id=\"", 1986, "\"", 1999, 2);
            WriteAttributeValue("", 1991, "paper_", 1991, 6, true);
#nullable restore
#line 53 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 1997, i, 1997, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                <div class=""modal-dialog modal-lg modal-dialog-centered"" role=""document"">
                    <div class=""modal-content"">


                        <div class=""modal-header"">

                            <button type=""button"" class=""close-windows-modal"" data-dismiss=""modal"" aria-label=""Close""><span class=""fas fa-times""></span></button>
                            <div class=""img-header-object d-flex align-items-center"">


");
#nullable restore
#line 64 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                 if (item.Image != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img style=\"height:50px !important\"");
            BeginWriteAttribute("src", " src=\"", 2708, "\"", 2725, 1);
#nullable restore
#line 66 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 2714, item.Image, 2714, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 67 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                 if (item.ImageCoverPath != null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <img style=\"height:50px !important\"");
            BeginWriteAttribute("src", " src=\"", 2960, "\"", 3025, 3);
#nullable restore
#line 70 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 2966, ViewBag.AdminURL, 2966, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2983, "/Upload/Papers/Images/", 2983, 22, true);
#nullable restore
#line 70 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 3005, item.ImageCoverPath, 3005, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" />\r\n");
#nullable restore
#line 71 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <p>");
#nullable restore
#line 73 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
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
#line 81 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </pre>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"modal-footer d-flex justify-content-center\">\r\n\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3657, "\"", 3720, 3);
#nullable restore
#line 87 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 3664, ViewBag.AdminURL, 3664, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3681, "/Upload/Papers/Downloads/", 3681, 25, true);
#nullable restore
#line 87 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 3706, item.Download, 3706, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"dl-link\">");
#nullable restore
#line 87 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                                                                                          Write(Localizer["Download"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\" fas fa-download mr-1\"></span></a>\r\n\r\n\r\n                            <button class=\"dl-link\" data-toggle=\"collapse\" href=\"#share\" role=\"button\" aria-expanded=\"false\" aria-controls=\"share\">");
#nullable restore
#line 90 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                                                                                                                              Write(Localizer["Share"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <span class="" fas fa-share-alt mr-1""></span></button>
                            <div class=""collapse share-colaps-modal"" id=""share"">
                                <div class=""card card-body d-flex"">
                                    <div class=""d-flex"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 4287, "\"", 4365, 6);
            WriteAttributeValue("", 4294, "whatsapp://send?text=", 4294, 21, true);
#nullable restore
#line 94 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4315, item.Title, 4315, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4326, "-", 4326, 1, true);
#nullable restore
#line 94 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4327, ViewBag.ShareURL, 4327, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4344, "/Paper/Index/", 4344, 13, true);
#nullable restore
#line 94 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4357, item.Id, 4357, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-action=\"share/whatsapp/share\" class=\"fab fa-whatsapp text-success\"></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4487, "\"", 4578, 6);
            WriteAttributeValue("", 4494, "https://telegram.me/share/url?url=", 4494, 34, true);
#nullable restore
#line 95 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4528, item.Title, 4528, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4539, "-", 4539, 1, true);
#nullable restore
#line 95 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4540, ViewBag.ShareURL, 4540, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4557, "/Paper/Index/", 4557, 13, true);
#nullable restore
#line 95 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4570, item.Id, 4570, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fab fa-telegram text-info\"></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4662, "\"", 4742, 6);
            WriteAttributeValue("", 4669, "mailto:?=&subject=", 4669, 18, true);
#nullable restore
#line 96 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4687, item.Title, 4687, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4698, "&body=", 4698, 6, true);
#nullable restore
#line 96 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4704, ViewBag.ShareURL, 4704, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4721, "/Paper/Index/", 4721, 13, true);
#nullable restore
#line 96 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4734, item.Id, 4734, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fas fa-envelope text-secondary\"></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 4831, "\"", 4933, 6);
            WriteAttributeValue("", 4838, "https://www.facebook.com/sharer/sharer.php?u=", 4838, 45, true);
#nullable restore
#line 97 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4883, item.Title, 4883, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4894, "-", 4894, 1, true);
#nullable restore
#line 97 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4895, ViewBag.ShareURL, 4895, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4912, "/Paper/Index/", 4912, 13, true);
#nullable restore
#line 97 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 4925, item.Id, 4925, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fab fa-facebook text-primary\"></a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 5020, "\"", 5115, 6);
            WriteAttributeValue("", 5027, "https://twitter.com/intent/tweet?text=", 5027, 38, true);
#nullable restore
#line 98 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 5065, item.Title, 5065, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5076, "-", 5076, 1, true);
#nullable restore
#line 98 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 5077, ViewBag.ShareURL, 5077, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5094, "/Paper/Index/", 5094, 13, true);
#nullable restore
#line 98 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 5107, item.Id, 5107, 8, false);

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
#line 107 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n<hr />\r\n<div class=\"d-flex align-items-center justify-content-center\">\r\n    <div class=\"pagination pagination-sm\">\r\n\r\n        <a href=\"/Paper?page=1\"");
            BeginWriteAttribute("class", " class=\"", 5567, "\"", 5614, 1);
#nullable restore
#line 119 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 5575, Model.CurrentPage <= 1?"disabled":"", 5575, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 119 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                                                           Write(Localizer["First"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 121 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
         for (int i = 1; i <= Model.TotalPage; i++)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 5723, "\"", 5744, 2);
            WriteAttributeValue("", 5730, "/Paper?page=", 5730, 12, true);
#nullable restore
#line 124 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 5742, i, 5742, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5745, "\"", 5788, 1);
#nullable restore
#line 124 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 5753, i==Model.CurrentPage?"active":"", 5753, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 124 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 125 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 5823, "\"", 5860, 2);
            WriteAttributeValue("", 5830, "/Paper?page=", 5830, 12, true);
#nullable restore
#line 128 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 5842, Model.TotalPage, 5842, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 5861, "\"", 5922, 1);
#nullable restore
#line 128 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
WriteAttributeValue("", 5869, Model.CurrentPage >= Model.TotalPage?"disabled":"", 5869, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 128 "E:\AllNewsBackUp\AllNews\Allnews\AllNews\Views\Paper\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllNews.ViewModel.PageinationViewModel<Paper>> Html { get; private set; }
    }
}
#pragma warning restore 1591
