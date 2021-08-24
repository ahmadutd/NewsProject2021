using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNewsCms.Web.Inferistruct.Const;
using AllNewsCms.Web.Inferistruct.CustomeAttrebiute;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using domain = AllNews.Domain;

namespace AllNewsCms.Web.Pages.SocialManagment
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Social Managment Page Edit")]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public CreateModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public domain.SocialManagment socialManagment { get; set; }
        public void OnGet(int?id)
        {
            if (id != null)
            {
                var socialManagmentId = Convert.ToInt32(id);
                var socialManagmentfromDb = this.socialManagment = _unitofwork.socialManagmentRepo.Get(x => x.Id == id);
                if (socialManagmentfromDb != null)
                    this.socialManagment = socialManagmentfromDb;
            }
        }
        public IActionResult OnPost(int id)
        {
            if (socialManagment.Id == 0)
            {
               
                
                _unitofwork.socialManagmentRepo.Add(socialManagment);
            }
            else
            {
                var socialManagmentForDb = _unitofwork.socialManagmentRepo.Get(x => x.Id == id);
                socialManagmentForDb.FacebookIdName = socialManagment.FacebookIdName;
                socialManagmentForDb.InstagramIdName = socialManagment.InstagramIdName;
                socialManagmentForDb.YoutubeIdName = socialManagment.YoutubeIdName;
                socialManagmentForDb.TelegramIdName = socialManagment.TelegramIdName;
                socialManagmentForDb.TwitterIdName = socialManagment.TwitterIdName;
                socialManagmentForDb.AddressEmail = socialManagment.AddressEmail;
                _unitofwork.socialManagmentRepo.Update(socialManagmentForDb);
            }
            _unitofwork.Commit();
            _unitofwork.Dispose();
            return RedirectToPage("Index");
        }
    }
}