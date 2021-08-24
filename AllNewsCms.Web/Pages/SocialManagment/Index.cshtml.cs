using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using domain = AllNews.Domain;

namespace AllNewsCms.Web.Pages.SocialManagment
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public IndexModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public List<domain.SocialManagment> socialData { get; set; }
        public domain.SocialManagment Data { get; set; }
        public void OnGet(int?id)
        {
            socialData = _unitofwork.socialManagmentRepo.GetAll().ToList();
            Data = _unitofwork.socialManagmentRepo.Get(x=>x.Id==id);
        }
    }
}