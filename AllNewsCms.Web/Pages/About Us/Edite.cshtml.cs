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

namespace AllNewsCms.Web.Pages.About_Us
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("About US Page Create")]
    public class EditeModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public EditeModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        [BindProperty]
        public About Data { get; set; }
        public void OnGet(int ? id)
        {
            if (id != null)
            {
                var aboutId = Convert.ToInt32(id);
                var fechmovetextfromDb = this.Data = _unitOfWork.aboutRepo.Get(x => x.Id == aboutId);
                if (fechmovetextfromDb != null)
                    this.Data = fechmovetextfromDb;
            }
        }

        public IActionResult OnPost()
        {
            if (Data.Id == 0)
            {
                var pageCulture = CultureInfo.CurrentCulture;
                Data.LangId = _unitOfWork.langRepo.Get(x => x.LangTitle == pageCulture.Name).Id;
                _unitOfWork.aboutRepo.Add(Data);
            }
            else
            {
                var aboutForDb = _unitOfWork.aboutRepo.Get(x => x.Id == Data.Id);
                aboutForDb.Text = Data.Text;
                aboutForDb.Title = Data.Title;

                _unitOfWork.aboutRepo.Update(aboutForDb);
            }
            _unitOfWork.Commit();
            _unitOfWork.Dispose();
            return RedirectToPage("Index");
        }
    }
}
