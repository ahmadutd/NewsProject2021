using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using AllNewsCms.Web.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace AllNewsCms.Web.Pages.RoleUserManagment
{
    [Authorize(Roles = "Supervisor")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<AppUser> _userManager;

        public IndexModel(IUnitOfWork unitOfWork, UserManager<AppUser> userManager)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
     
        public List<AppUser> UserList { get; set; }
        
        public List<AppRole> RoleList { get; set; }


        public void OnGet()
        {
            UserList = _unitOfWork.appUserRepo.GetAll().ToList();
            RoleList = _unitOfWork.appRoleRepo.GetAll().ToList();
           
        }
       
        public async Task<IActionResult> OnPostSetRoleUser(RequestSetRoleUser vm)
        {
            try
            {
                var user = _unitOfWork.appUserRepo.GetAll().FirstOrDefault(u => u.Id == vm.Id);
                if (user == null) throw new Exception("User Not Found");

                List<AddOrUpdateRoleViewModel> roles = null;
                if(vm.RoleId !=null)
                {
                    roles = _unitOfWork.appRoleRepo.GetAll().Where(r => vm.RoleId.Contains(r.Id))
                        .Select(r => new AddOrUpdateRoleViewModel
                        {
                            RoleId = r.Id,
                            RoleNames = r.Name
                        }).ToList();
                }
              
                await _userManager.RemoveFromRolesAsync(user, _userManager.GetRolesAsync(user).Result);
                await _userManager.AddToRolesAsync(user, roles.Select(x => x.RoleNames));

                return Content("Operation Success");
            }
            catch (Exception ex )
            {

                return new JsonResult(ex.Message);
            }

           
        }
    }
}