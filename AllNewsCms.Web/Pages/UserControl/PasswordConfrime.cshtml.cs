using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AllNewsCms.Web.Pages.UserControl
{
    [Authorize(Roles = "Supervisor")]
    public class PasswordConfimeModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;
        private readonly UserManager<AppUser> _userManager;


        public PasswordConfimeModel(IUnitOfWork unitofwork, UserManager<AppUser> userManager)
        {
            _unitofwork = unitofwork;
            _userManager = userManager;

        }
        public AppUser Users { get; set; }
        [BindProperty]
        public int UserId { get; set; }

        [BindProperty]
        [Required]
        public string ResetPassword { get; set; }

        
        public async Task OnGetAsync(int id)
        {
            Users = _unitofwork.appUserRepo.Get(x => x.Id == id);
            UserId = id;
            return;
        }
        public IActionResult OnPostChangePassword()
        {
            if (ResetPassword == null)
                return Page();

            if (ModelState.IsValid)
            {
                var users = _unitofwork.appUserRepo.GetAll().FirstOrDefault(u => u.Id == UserId);

                

                if (users != null)
                {
                    users.PasswordHash = _userManager.PasswordHasher.HashPassword(users, ResetPassword);
                    _unitofwork.Commit();
                    return RedirectToPage("./Complete");
                }
                
            }

            return Page();



        }
    }
}