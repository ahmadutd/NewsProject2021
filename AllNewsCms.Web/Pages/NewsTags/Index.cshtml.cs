using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using AllNewsCms.Web.Inferistruct.Const;
using AllNewsCms.Web.Inferistruct.CustomeAttrebiute;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Domain = AllNews.Domain;

namespace AllNewsCms.Web.Pages.NewsTags
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("NewsTags Page")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly INewsPagination _newsPagination;

        public IndexModel(IUnitOfWork unitOfWork,INewsPagination newsPagination)
        {
            _unitOfWork = unitOfWork;
            _newsPagination = newsPagination;
        }


        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 100;
        public int TotalPages { get => (int)Math.Ceiling(decimal.Divide(Count, PageSize)); }

        [BindProperty]
        public int[] TagIds { get; set; }

        [BindProperty]
        public int NewsId { get; set; }

        [BindProperty]
        public int? TagSelectedForDeleteId { get; set; }

        [BindProperty]
        public List<Category> Category { get; set; }


        public List<Domain.News> Data { get; set; }

        public List<SelectListItem> TagSelectList { get; set; }


        public void OnGet(int? id = null)
        {


            try
            {
                var currentLanguage = CultureInfo.CurrentCulture;

                
               
                Category = _unitOfWork.catageryRepo.GetAllCateNews().Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();

                if (id != null)
                {
                    Data = _unitOfWork.newsRepo.GetLastNews().Where(x => (id == null || x.CategoryId == id) && x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();
                }
                else
                {
                    Data = _newsPagination.GetPaginationResult(CurrentPage, PageSize).ToList();
                }

                Count = _newsPagination.GetCount();
               

                TagSelectList = _unitOfWork.tagRepo.GetAll().Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).Select(x => new SelectListItem
                {
                    Text=x.Name,
                    Value=x.Id.ToString(),
                    

                }).ToList();

            }
            catch (Exception)
            {

                throw;
            }


        }



        public IActionResult OnPost()
        {
            try
            {

                List<NewsTag> newsTag = new List<NewsTag>();
                foreach (var tagid in TagIds)
                {

                    newsTag.Add(new NewsTag
                    {
                        TagId = tagid,
                        NewsId = this.NewsId,
                    });
                }
                if (!newsTag.Any())
                    return RedirectToPage("Index");
                _unitOfWork.newstagRepo.AddRange(newsTag);
                _unitOfWork.Commit();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _unitOfWork?.Dispose();
            }
            return RedirectToPage("Index");
        }



        public IActionResult OnPostDelete()
        {

            try
            {
                if (TagSelectedForDeleteId == null)
                    return RedirectToPage("Index");

                var newsTags = _unitOfWork.newstagRepo.Get(x => x.TagId == TagSelectedForDeleteId);
                if (newsTags != null)
                    _unitOfWork.newstagRepo.Delete(newsTags);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                _unitOfWork?.Dispose();
            }
            return RedirectToPage("Index");
        }
    }
}