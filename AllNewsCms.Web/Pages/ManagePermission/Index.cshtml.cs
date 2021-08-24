using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AllNews.Domain;
using AllNewsCms.Web.Inferistruct.Const;
using AllNewsCms.Web.Inferistruct.CustomeAttrebiute;
using AllNewsCms.Web.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace AllNewsCms.Web.Pages.ManagePermission
{
    [Authorize(Roles ="Supervisor")]
    
    public class IndexModel : PageModel
    {
        private readonly UserManager<AppUser> _userManaganer;
        private readonly IActionDescriptorCollectionProvider _descriptort;
        private readonly PageLoader _pageLoader;

        public IndexModel(UserManager<AppUser> userManaganer ,
            IActionDescriptorCollectionProvider descriptort,
            PageLoader pageLoader
            )
        {
            _userManaganer = userManaganer;
            _descriptort = descriptort;
            _pageLoader = pageLoader;

        }

        public List<SecurePageViewModel> SecurePagesList { get; set; } = new List<SecurePageViewModel>();
        public int? UserId { get; set;}
        public string UserName { get; set; }
        public List<string> UserClaims { get; set; }

        [BindProperty]
        public PermissionItemsRequist PermissionItemsModel { get; set; }
        public class PermissionItemsRequist
        {
            public string[] PermissionName { get; set; }
            public int UserId { get; set; }
        }


        public async Task OnGet(int? id)
        {
            UserId = id;
            var user = await _userManaganer.FindByIdAsync(id.ToString());
            UserName = user.UserName;


            var pageDescriptors = _descriptort.ActionDescriptors.Items.OfType<PageActionDescriptor>().Where(x => x.AreaName != "Identity").Where(x => x.AttributeRouteInfo.SuppressLinkGeneration == false).ToArray();

            var securePage = from p in pageDescriptors
                             let c = _pageLoader.LoadAsync(p).Result.EndpointMetadata.OfType<AuthorizeAttribute>()
                             let c2 = _pageLoader.LoadAsync(p).Result.EndpointMetadata.OfType<SecurePage>()
                             where c.Any(x => x.Policy == Permissions.NicePermission)
                             select new { SecurePages = p.ViewEnginePath, Description =c2 !=null?c2.FirstOrDefault().permissionDescription:p.DisplayName };


            
            foreach (var item in securePage)
            {
                SecurePagesList.Add(new SecurePageViewModel
                {
                    Permission = item.SecurePages.ToString(),
                    Description = item.Description.ToString()

                });
            }



            var userClaim = await _userManaganer.GetClaimsAsync(user);
            UserClaims = userClaim.Select(x => x.Value).ToList();
           


        }

        public async Task<IActionResult> OnPost()
        {
            var appUser = await _userManaganer.FindByIdAsync(PermissionItemsModel.UserId.ToString());
            if (PermissionItemsModel != null)
            {
                List<Claim> claims = PermissionItemsModel.PermissionName?.Select(
                    x => new Claim(Permissions.NicePermissionType, x)).ToList();
                

                if (appUser != null)
                {
                    var userClaims = await _userManaganer.GetClaimsAsync(appUser);
                    await _userManaganer.RemoveClaimsAsync(appUser, userClaims);

                    if(claims != null)
                        await _userManaganer.AddClaimsAsync(appUser, claims);
                    
                }
            }
            return RedirectToPage("../RoleUser/Index");
        }

        
    }

   
}