using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNewsCms.Web.Inferistruct.Const;
using AllNewsCms.Web.Inferistruct.CustomeAttrebiute;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain = AllNews.Domain;

namespace AllNewsCms.Web.Pages.MoveText
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("MoveText Page Index")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Domain.MoveText> MoveTexts { get; set; }
        public void OnGet(int? id)
        {
            var currentLanguage = CultureInfo.CurrentCulture;

            MoveTexts = _unitOfWork.movetextRepo.GetMoveText(true, null, currentLanguage.Name).ToList();
        }
    }
}