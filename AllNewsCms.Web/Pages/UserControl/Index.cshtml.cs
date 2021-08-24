using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using AllNewsCms.Web.Inferistruct.Const;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AllNewsCms.Web.Pages.UserControl
{
    [Authorize(Roles = "Supervisor")]
    public class IndexModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;

        public IndexModel(IUnitOfWork unitOfWork,UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        public List<AppRoleUser> RoleUsers { get; set; }
        public List<AppUser> UserList { get; set; }

        [BindProperty]
        public int? DeleteUser { get; set; }
        public void OnGet(int?id)
        {
            //UserList = _unitOfWork.appUserRepo.GetAll().Where(x => _userManager.IsInRoleAsync(x, PermissionRole.Supervisor).Result == false).ToList();
            UserList = _unitOfWork.appUserRepo.GetAll().ToList();


        }
       
        public IActionResult OnPostDelete()
        {
            try
            {
                if (DeleteUser == null)
                    return RedirectToPage("Index");

                var userAdmin = _unitOfWork.appUserRepo.Get(x => x.Id == DeleteUser);
                if (userAdmin != null)
                    _unitOfWork.appUserRepo.Delete(userAdmin);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {

                return RedirectToPage("Error");
            }
            finally
            {
                _unitOfWork?.Dispose();
            }
            return RedirectToPage("Index");
        }

    }
}