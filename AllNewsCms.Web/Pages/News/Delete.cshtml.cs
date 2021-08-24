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
using Domain = AllNews.Domain;

namespace AllNewsCms.Web.Pages.News
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("News Page Delete")]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitofwork;

        public DeleteModel(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        [BindProperty]
        public Domain.News News { get; set; }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                var newsId = Convert.ToInt32(id);
                var fechnewsfromDb = this.News = _unitofwork.newsRepo.Get(x => x.Id == newsId);
                if (fechnewsfromDb != null)
                    this.News = fechnewsfromDb;
            }
        }
        public IActionResult OnPost()
        {
            try
            {
                if (News != null)
                {
                    var newsfectFromDb = _unitofwork.newsRepo.Get(x => x.Id == News.Id);
                    if (newsfectFromDb != null)
                        _unitofwork.newsRepo.Delete(newsfectFromDb);
                    _unitofwork.Commit();
                }

            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToPage("Index");
        }

    }
}