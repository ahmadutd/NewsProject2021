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

namespace AllNewsCms.Web.Pages.Tags
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Tags Page Index")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITagsPagination _tagsPagination;

        public IndexModel(IUnitOfWork unitOfWork, ITagsPagination tagsPagination)
        {
            _unitOfWork = unitOfWork;
            _tagsPagination = tagsPagination;
        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 20;
        public int TotalPages { get => (int)Math.Ceiling(decimal.Divide(Count, PageSize)); }

        [BindProperty]
        public Tag Tag { get; set; }
        public List<Tag> TagList { get; set; }
        public void OnGet()
        {
            try
            {
                var currentLanguage = CultureInfo.CurrentCulture;

                TagList = _tagsPagination.GetPaginationResult(CurrentPage, PageSize).ToList();
                Count = _tagsPagination.GetCount();



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
                if (!ModelState.IsValid)
                    return RedirectToPage("Index");
                var pageCulture = CultureInfo.CurrentCulture;
                Tag.LangId = _unitOfWork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                _unitOfWork.tagRepo.Add(Tag);
                _unitOfWork.Commit();
                _unitOfWork.Dispose();
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