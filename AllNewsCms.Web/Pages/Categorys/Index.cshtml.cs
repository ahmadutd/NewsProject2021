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

namespace AllNewsCms.Web.Pages.Categorys
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Categorys Page Index")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [BindProperty]
        public Category Category { get; set; }
        public List<Category> Categorys { get; set; }
        public void OnGet(int?id)
        {
            try
            {
                var currentLanguage = CultureInfo.CurrentCulture;
                Categorys = _unitOfWork.catageryRepo.GetAll()
               .Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).ToList();

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
                var pageCulture = CultureInfo.CurrentCulture;
                
                
                if (!ModelState.IsValid)
                    return RedirectToPage("Index");
                Category.LangId = _unitOfWork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                _unitOfWork.catageryRepo.Add(Category);
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