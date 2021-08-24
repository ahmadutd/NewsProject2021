using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AllNewsCms.Web.Pages.Role
{

    public class RoleModel
    {
        [Display(Name = "Role Name")]
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
    }
    public class IndexModel : PageModel
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;

        public IndexModel(RoleManager<AppRole> roleManager,IUnitOfWork unitOfWork)
        {
            _roleManager = roleManager;
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public RoleModel Role { get; set; }

        public List<AppRole> RoleModelList { get; set; }
        public void OnGet()
        {
            RoleModelList = _unitOfWork.appRoleRepo.GetAll().ToList();
        }

        public async Task<IActionResult> OnPostAddRoleAsync()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var role = new AppRole(Role.Name);
                    var exist = _unitOfWork.appRoleRepo.GetAll().FirstOrDefault(r => r.Name == role.Name);
                    if (exist != null) throw new Exception("The Role Is Exist !");
                    var result = await _roleManager.CreateAsync(role);
                    if (result.Succeeded)
                        return Page();
                }
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
               
            }

            return Page();
        }
    }
}