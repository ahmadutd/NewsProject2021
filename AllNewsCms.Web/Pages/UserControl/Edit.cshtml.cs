using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using AllNewsCms.Web.Areas.Identity.Pages.Account.Manage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AllNewsCms.Web.Pages.AdminsControl
{
    [Authorize(Roles = "Supervisor")]
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;
        private readonly UserManager<AppUser> _userManager;


        public EditModel(IUnitOfWork unitofwork,UserManager<AppUser> userManager)
        {
            _unitofwork = unitofwork;
            _userManager = userManager;
           
        }


        [BindProperty]
        public int UserId { get; set; }
        [BindProperty]
        public string ResetPassword { get; set; }

        public class ChangePasswordModelRequest
        {
            public int UserId { get; set; }
            public string ResetPassword { get; set; }
        }
    
        [BindProperty]
        public AppUser UserList { get; set; }



        public void OnGet(int? id)
        {
            if (id != null)
            {
                var userId = Convert.ToInt32(id);
                var fechnuserfromDb = this.UserList = _unitofwork.appUserRepo.Get(x => x.Id == userId);
                if (fechnuserfromDb != null)
                    this.UserList = fechnuserfromDb;
            }
        }
        
        public IActionResult OnPost()
        {
            
            if(UserList !=null)
            {
                var userForDb = _unitofwork.appUserRepo.Get(x=>x.Id == UserList.Id);
                userForDb.UserName = UserList.UserName;
                userForDb.Email = UserList.Email;
               

                _unitofwork.appUserRepo.Update(userForDb);
            }


               
            
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
         

        
    }
}