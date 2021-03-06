#pragma checksum "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8380b8fe55e4a19e722e37208c0cd2bb391d4375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AllNewsCms.Web.Pages.UserActivities.Pages_UserActivities_Activities), @"mvc.1.0.razor-page", @"/Pages/UserActivities/Activities.cshtml")]
namespace AllNewsCms.Web.Pages.UserActivities
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
#line 1 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\_ViewImports.cshtml"
using AllNewsCms.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\_ViewImports.cshtml"
using AllNewsCms.Web.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8380b8fe55e4a19e722e37208c0cd2bb391d4375", @"/Pages/UserActivities/Activities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d43eb727577fe58a1def6261a0397978b3126af8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserActivities_Activities : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
  
    ViewData["Title"] = "Activities";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"alert alert-info d-flex align-items-center\">\r\n            <h4 class=\"fas fa-history mr-2\"></h4>\r\n            <h4>User Activities - ");
#nullable restore
#line 11 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                             Write(Model.Human?.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
        </div>
    </div>
</div>
<hr />

<table class=""table"">
    <thead class=""thead-dark"">
        <tr style=""text-align:center"">
            <th scope=""col"">News</th>
            <th scope=""col"">Papers</th>
            <th scope=""col"">Studies</th>
            <th scope=""col"">Statements</th>
            <th scope=""col"">Organisations</th>
            <th scope=""col"">Photos</th>
            <th scope=""col"">Videos</th>
            <th scope=""col"">Audios</th>
        </tr>
    </thead>
    <tbody>
        <tr style=""text-align:center"">
            <td scope=""col"">
");
#nullable restore
#line 33 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.NewsCounts.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <span class=\"badge badge-info\">");
#nullable restore
#line 36 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                               Write(Model.NewsCounts.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 37 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-danger\">0</span>\r\n");
#nullable restore
#line 41 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 44 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.PaperCounts.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-info\">");
#nullable restore
#line 46 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                              Write(Model.PaperCounts.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 47 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <span class=\"badge badge-danger\">0</span>\r\n");
#nullable restore
#line 51 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 54 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.StudieCounts.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-info\">");
#nullable restore
#line 56 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                              Write(Model.StudieCounts.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 57 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-danger\">0</span>\r\n");
#nullable restore
#line 61 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 64 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.StatementCounts.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-info\">");
#nullable restore
#line 66 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                              Write(Model.StatementCounts.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 67 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-danger\">0</span>\r\n");
#nullable restore
#line 71 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 74 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.CompanyCounts.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-info\">");
#nullable restore
#line 76 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                              Write(Model.CompanyCounts.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 77 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-danger\">0</span>\r\n");
#nullable restore
#line 81 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 84 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.PhotoCounts.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-info\">");
#nullable restore
#line 86 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                              Write(Model.PhotoCounts.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 87 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-danger\">0</span>\r\n");
#nullable restore
#line 91 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 94 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.VideoCounts.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-info\">");
#nullable restore
#line 96 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                              Write(Model.VideoCounts.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 97 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <span class=\"badge badge-danger\">0</span>\r\n");
#nullable restore
#line 101 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 104 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.AudioCounts.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-info\">");
#nullable restore
#line 106 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                              Write(Model.AudioCounts.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 107 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-danger\">0</span>\r\n");
#nullable restore
#line 111 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n        <tr style=\"text-align:center;font-size:10px\">\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 116 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.NewsCounts.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
               Write(Model.NewsCounts.FirstOrDefault()?.UpdatedDate);

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                                                   
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 123 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.PaperCounts.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
               Write(Model.PaperCounts.FirstOrDefault()?.UpdatedDate);

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                                                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("              \r\n            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 130 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.StudieCounts.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
               Write(Model.StudieCounts.FirstOrDefault()?.UpdatedDate);

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                                                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 137 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.StatementCounts.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
               Write(Model.StatementCounts.FirstOrDefault()?.UpdatedDate);

#line default
#line hidden
#nullable disable
#nullable restore
#line 139 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                                                        
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 144 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.CompanyCounts.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
               Write(Model.CompanyCounts.FirstOrDefault()?.UpdatedDate);

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                                                      
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 151 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.PhotoCounts.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
               Write(Model.PhotoCounts.FirstOrDefault()?.UpdatedDate);

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                                                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 158 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.VideoCounts.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
               Write(Model.VideoCounts.FirstOrDefault()?.UpdatedDate);

#line default
#line hidden
#nullable disable
#nullable restore
#line 160 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                                                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </td>\r\n            <td scope=\"col\">\r\n");
#nullable restore
#line 165 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                 if (Model.AudioCounts.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
               Write(Model.AudioCounts.FirstOrDefault()?.UpdatedDate);

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\UserActivities\Activities.cshtml"
                                                                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllNewsCms.Web.Pages.UserActivities.ActivitiesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllNewsCms.Web.Pages.UserActivities.ActivitiesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllNewsCms.Web.Pages.UserActivities.ActivitiesModel>)PageContext?.ViewData;
        public AllNewsCms.Web.Pages.UserActivities.ActivitiesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
