#pragma checksum "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10d53010f99070b67065b92ac71281e82f456ffb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Audios_AudioPart), @"mvc.1.0.view", @"/Views/Audios/AudioPart.cshtml")]
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
#line 1 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10d53010f99070b67065b92ac71281e82f456ffb", @"/Views/Audios/AudioPart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Audios_AudioPart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllNews.Domain.Audio>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"date-box d-flex align-items-baseline justify-content-start\">\r\n            <span class=\"fas fa-calendar-alt text-dark m-1\"></span>\r\n            <span class=\"datetime-now mr-1 ml-1\">");
#nullable restore
#line 10 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
                                            Write(Model.UpdatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
 
                   
            <div class=""dropdown"" id=""share"">
                <button class=""share-btn btn btn-light mr-1 ml-1 dropdown-toggle"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <span class=""fas fa-share-alt m-1""></span>
                </button>
                <div class=""dropdown-menu share-colaps dropdown-menu-center"" aria-labelledby=""dropdownMenuButton"">
                    <div class=""d-flex"">
                        <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 973, "\"", 1058, 6);
            WriteAttributeValue("", 980, "whatsapp://send?text=", 980, 21, true);
#nullable restore
#line 19 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1001, Model.Title, 1001, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1013, "-", 1013, 1, true);
#nullable restore
#line 19 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1014, ViewBag.ShareURL, 1014, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1031, "/Audios/AudioPart/", 1031, 18, true);
#nullable restore
#line 19 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1049, Model.Id, 1049, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-action=\"share/whatsapp/share\"><span class=\"fab fa-whatsapp text-success\"></span></a>\r\n                        <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1199, "\"", 1297, 6);
            WriteAttributeValue("", 1206, "https://telegram.me/share/url?url=", 1206, 34, true);
#nullable restore
#line 20 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1240, Model.Title, 1240, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1252, "-", 1252, 1, true);
#nullable restore
#line 20 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1253, ViewBag.ShareURL, 1253, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1270, "/Audios/AudioPart/", 1270, 18, true);
#nullable restore
#line 20 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1288, Model.Id, 1288, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"fab fa-telegram text-info\"></span></a>\r\n                        <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1400, "\"", 1487, 6);
            WriteAttributeValue("", 1407, "mailto:?=&subject=", 1407, 18, true);
#nullable restore
#line 21 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1425, Model.Title, 1425, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1437, "&body=", 1437, 6, true);
#nullable restore
#line 21 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1443, ViewBag.ShareURL, 1443, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1460, "/Audios/AudioPart/", 1460, 18, true);
#nullable restore
#line 21 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1478, Model.Id, 1478, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"fas fa-envelope text-secondary\"></span></a>\r\n                        <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1595, "\"", 1704, 6);
            WriteAttributeValue("", 1602, "https://www.facebook.com/sharer/sharer.php?u=", 1602, 45, true);
#nullable restore
#line 22 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1647, Model.Title, 1647, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1659, "-", 1659, 1, true);
#nullable restore
#line 22 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1660, ViewBag.ShareURL, 1660, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1677, "/Audios/AudioPart/", 1677, 18, true);
#nullable restore
#line 22 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1695, Model.Id, 1695, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"fab fa-facebook text-primary\"></span></a>\r\n                        <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1810, "\"", 1912, 6);
            WriteAttributeValue("", 1817, "https://twitter.com/intent/tweet?text=", 1817, 38, true);
#nullable restore
#line 23 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1855, Model.Title, 1855, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1867, "-", 1867, 1, true);
#nullable restore
#line 23 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1868, ViewBag.ShareURL, 1868, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1885, "/Audios/AudioPart/", 1885, 18, true);
#nullable restore
#line 23 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 1903, Model.Id, 1903, 9, false);

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
</div>
<hr class=""m-0"" />
<div class=""row"">
    <div class=""col"">
        <div class=""news-header"">

            <h5>");
#nullable restore
#line 39 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 45 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
 if (Model.Image != null || Model.ImageCoverPath != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
     if (Model.Image != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-6 col-md-2\">\r\n                <img class=\"w-100\"");
            BeginWriteAttribute("src", " src=\"", 2477, "\"", 2495, 1);
#nullable restore
#line 51 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 2483, Model.Image, 2483, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" style=\"max-height:350px;\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 54 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
     if (Model.ImageCoverPath != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-6 col-md-2\">\r\n                <img class=\"w-100\"");
            BeginWriteAttribute("src", " src=\"", 2741, "\"", 2807, 3);
#nullable restore
#line 59 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 2747, ViewBag.AdminURL, 2747, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2764, "/Upload/Audios/Images/", 2764, 22, true);
#nullable restore
#line 59 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 2786, Model.ImageCoverPath, 2786, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Alternate Text\" style=\"max-height:350px;\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 62 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<div class=\"row\">\r\n\r\n    <div class=\"col\">\r\n\r\n        <div class=\"news-desc\">\r\n\r\n            <pre>");
#nullable restore
#line 71 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
            Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n<hr />\r\n");
#nullable restore
#line 79 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
 if (Model.AudioCoverPath != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-12 col-md-6\">\r\n            <div class=\"news-audio\">\r\n                <audio class=\"w-100\" controls=\"controls\">\r\n                    <source");
            BeginWriteAttribute("src", " src=\"", 3313, "\"", 3379, 3);
#nullable restore
#line 85 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 3319, ViewBag.AdminURL, 3319, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3336, "/Upload/Audios/Voices/", 3336, 22, true);
#nullable restore
#line 85 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
WriteAttributeValue("", 3358, Model.AudioCoverPath, 3358, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"audio/mp3\" />\r\n                </audio>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 90 "E:\AllNews\Allnews\AllNews\Views\Audios\AudioPart.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllNews.Domain.Audio> Html { get; private set; }
    }
}
#pragma warning restore 1591
