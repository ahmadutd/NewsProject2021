#pragma checksum "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c695ab9259bb712a610b372a8e2600c81c3f4e9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AllNewsCms.Web.Pages.RoleUser.Pages_RoleUser_Index), @"mvc.1.0.razor-page", @"/Pages/RoleUser/Index.cshtml")]
namespace AllNewsCms.Web.Pages.RoleUser
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
#nullable restore
#line 2 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
using AllNews.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c695ab9259bb712a610b372a8e2600c81c3f4e9a", @"/Pages/RoleUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d43eb727577fe58a1def6261a0397978b3126af8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RoleUser_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""alert alert-info d-flex align-items-center"">
    <h4 class=""fas fa-user-check mr-2""></h4>
    <h4>Role & Permission Managment</h4>
</div>

<br />
<div class=""row"">
    <div class=""col"">
        <table class=""table table-bordered"">
            <tr>
                <th>Id</th>
                <th>UserName</th>
                <th class=""d-none d-md-block"">Email</th>
                <th>Role</th>
                <th>Action</th>
            </tr>
");
#nullable restore
#line 26 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
             foreach (var item in Model.UserList)
            {
                var roles = string.Join('/',await userManager.GetRolesAsync(item));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 30 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
                   Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"d-none d-md-block\">");
#nullable restore
#line 32 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
                                             Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        \r\n                        <span class=\"role-box\">");
#nullable restore
#line 35 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
                                          Write(roles);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        \r\n\r\n                    </td>\r\n                    <td class=\"d-flex\">\r\n\r\n                        <button type=\"button\" class=\"btn btn-sm btn-info mr-md-2\" data-toggle=\"modal\" data-target=\"#AddRole_");
#nullable restore
#line 41 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
                                                                                                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1358, "\"", 1404, 6);
            WriteAttributeValue("", 1368, "ChangeModalState(", 1368, 17, true);
#nullable restore
#line 41 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
WriteAttributeValue("", 1385, item.Id, 1385, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1393, ",", 1393, 1, true);
            WriteAttributeValue(" ", 1394, "\'", 1395, 2, true);
#nullable restore
#line 41 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
WriteAttributeValue("", 1396, roles, 1396, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1402, "\')", 1402, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Manage Role</button>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1454, "\"", 1490, 2);
            WriteAttributeValue("", 1461, "/ManagePermission?id=", 1461, 21, true);
#nullable restore
#line 42 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
WriteAttributeValue("", 1482, item.Id, 1482, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-secondary\">Manage Permission</a>\r\n                    </td>\r\n                    \r\n                </tr>\r\n                <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1659, "\"", 1680, 2);
            WriteAttributeValue("", 1664, "AddRole_", 1664, 8, true);
#nullable restore
#line 46 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
WriteAttributeValue("", 1672, item.Id, 1672, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"" id=""exampleModalLabel"">Add Role For (");
#nullable restore
#line 50 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
                                                                                        Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</h5>
                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                    <span aria-hidden=""true"">&times;</span>
                                </button>
                            </div>
                            <div class=""modal-body"">
                                <div");
            BeginWriteAttribute("id", " id=\"", 2433, "\"", 2464, 2);
            WriteAttributeValue("", 2438, "CheckBoxContainer_", 2438, 18, true);
#nullable restore
#line 56 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
WriteAttributeValue("", 2456, item.Id, 2456, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-flex flex-wrap align-items-center justify-content-center\">\r\n");
#nullable restore
#line 57 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
                                     foreach (var role in Model.RoleList)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
                                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"form-check m-2\">\r\n                                            <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 2876, "\"", 2892, 1);
#nullable restore
#line 61 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
WriteAttributeValue("", 2884, role.Id, 2884, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"checkbox[]\"");
            BeginWriteAttribute("id", " id=\"", 2911, "\"", 2930, 2);
            WriteAttributeValue("", 2916, "chbox_", 2916, 6, true);
#nullable restore
#line 61 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
WriteAttributeValue("", 2922, role.Id, 2922, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-chbox=\"");
#nullable restore
#line 61 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
                                                                                                                                                          Write(role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                            <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 3033, "\"", 3053, 2);
            WriteAttributeValue("", 3039, "chbox_", 3039, 6, true);
#nullable restore
#line 62 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
WriteAttributeValue("", 3045, role.Id, 3045, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                               ");
#nullable restore
#line 63 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
                                          Write(role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </label>\r\n                                        </div>\r\n");
#nullable restore
#line 66 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""modal-footer"">
                                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                <button type=""button"" class=""btn btn-success""");
            BeginWriteAttribute("onclick", " onclick=\"", 3585, "\"", 3642, 5);
            WriteAttributeValue("", 3595, "AddRole(", 3595, 8, true);
#nullable restore
#line 72 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
WriteAttributeValue("", 3603, item.Id, 3603, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3611, ",\'#CheckBoxContainer_", 3611, 21, true);
#nullable restore
#line 72 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
WriteAttributeValue("", 3632, item.Id, 3632, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3640, "\')", 3640, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Save changes</button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 77 "E:\AllNewsBackUp\AllNews\Allnews\AllNewsCms.Web\Pages\RoleUser\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 

    <script>

        let userRoleList = [];

        function ChangeModalState(userId, data) {

            userRoleList = [];

            if (data) {      
                data.split(',').forEach(function (val) {

                    userRoleList.push(val);
                    }
                );
            }
           
            SetSelectedCheckBox(userId, '#CheckBoxContainer_' + userId);


        }


        function SetSelectedCheckBox(id, obj) {
            $(obj + ' input:checkbox').each(function (index, obj) {
                var role = $(this).data('chbox');
                if (userRoleList.some(x => x == role)) {

                    $(this).prop('checked', true);
                }


            });

        }



        function AddRole(id, obj) {
         
            let roleId = [];
            $(obj + ' input:checkbox:checked').each(function () {

                roleId.push(parseInt(this.value))
            })

            SetRole(id, ro");
                WriteLiteral(@"leId);
        }


        var SetRole = function (id,roleId) {

            var data = {};
            data.Id = id;
            data.RoleId = roleId;

            $.ajax(
                {
                    url: ""/RoleUser?handler=SetRoleUser"",
                    beforeSend: function (xhr) {
                        xhr.setRequestHeader(""XSRF-TOKEN"", $('input:hidden[name=""__RequestVerificationToken""]').val())
                    },

                    type: ""POST"",
                    data: data,
                    success: function (response) {
                        $('#AddRole_' + data.Id).modal('hide')
                       
                        location.reload()
                    },
                    failure: function (response) {
                        alert: (response);
                    }
                }
            );
                



        }



    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllNewsCms.Web.Pages.RoleUserManagment.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllNewsCms.Web.Pages.RoleUserManagment.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AllNewsCms.Web.Pages.RoleUserManagment.IndexModel>)PageContext?.ViewData;
        public AllNewsCms.Web.Pages.RoleUserManagment.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
