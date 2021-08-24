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

namespace AllNewsCms.Web.Pages.VideosTags
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("VideoTags Page ")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IVideoPagination _videopagination;
        public IndexModel(IUnitOfWork unitOfWork, IVideoPagination videopagination)
        {
            _unitOfWork = unitOfWork;
            _videopagination = videopagination;
        }
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 20;
        public int TotalPages { get => (int)Math.Ceiling(decimal.Divide(Count, PageSize)); }

        [BindProperty]
        public int[] TagIds { get; set; }

        [BindProperty]
        public int VideoId { get; set; }

        [BindProperty]
        public int? TagSelectedForDeleteId { get; set; }

        public List<Domain.Video> Data { get; set; }
        public List<SelectListItem> TagSelectList { get; set; }
        public void OnGet()
        {


            try
            {
                var currentLanguage = CultureInfo.CurrentCulture;

                Data = _videopagination.GetPaginationResult(CurrentPage, PageSize).ToList();
                Count = _videopagination.GetCount();


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

                List<VideoTag> videoTag = new List<VideoTag>();
                foreach (var tagid in TagIds)
                {

                    videoTag.Add(new VideoTag
                    {
                        TagId = tagid,
                       VideoId = this.VideoId,
                    });
                }
                if (!videoTag.Any())
                    return RedirectToPage("Index");
                _unitOfWork.videotagRepo.AddRange(videoTag);
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

                var videoTags = _unitOfWork.videotagRepo.Get(x => x.TagId == TagSelectedForDeleteId);
                if (videoTags != null)
                    _unitOfWork.videotagRepo.Delete(videoTags);
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