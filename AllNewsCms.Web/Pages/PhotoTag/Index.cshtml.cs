using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AllNews.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;
using AllNewsCms.Web.Inferistruct.CustomeAttrebiute;
using Microsoft.AspNetCore.Authorization;
using AllNewsCms.Web.Inferistruct.Const;

namespace AllNewsCms.Web.Pages.PhotoTag
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("PhotoTags Page")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPhotoPagination _photoPagination;

        public IndexModel(IUnitOfWork unitOfWork, IPhotoPagination photoPagination)
        {
            _unitOfWork = unitOfWork;
            _photoPagination = photoPagination;
        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 100;
        public int TotalPages { get => (int)Math.Ceiling(decimal.Divide(Count, PageSize)); }

        [BindProperty]
        public int[] TagIds { get; set; }

        [BindProperty]
        public int PhotoId { get; set; }

        [BindProperty]
        public int? TagSelectedForDeleteId { get; set; }

        public List<Photo> Data { get; set; }
        public List<SelectListItem> TagSelectList { get; set; }
        public void OnGet()
        {


            try
            {
                var currentLanguage = CultureInfo.CurrentCulture;

                Data = _photoPagination.GetPaginationResult(CurrentPage, PageSize).ToList();
                Count = _photoPagination.GetCount();

                TagSelectList = _unitOfWork.tagRepo.GetAll().Where(x => x.SiteLanguage.LangTitle == currentLanguage.Name).Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id.ToString(),


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

                List<PhotosTag> photoTag = new List<PhotosTag>();
                foreach (var tagid in TagIds)
                {

                    photoTag.Add(new PhotosTag
                    {
                        TagId = tagid,
                        PhotoId=this.PhotoId,
                    });
                }
                if (!photoTag.Any())
                    return RedirectToPage("Index");
                _unitOfWork.phototagRepo.AddRange(photoTag);
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

                var photoTags = _unitOfWork.phototagRepo.Get(x => x.TagId == TagSelectedForDeleteId);
                if (photoTags != null)
                    _unitOfWork.phototagRepo.Delete(photoTags);
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