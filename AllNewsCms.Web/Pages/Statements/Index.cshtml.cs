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

namespace AllNewsCms.Web.Pages.Statements
{
    [Authorize(Permissions.NicePermission)]
    [SecurePage("Statements Page Index")]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStatementPagination _statementPagination;

        public IndexModel(IUnitOfWork unitOfWork,IStatementPagination statementPagination)
        {
            _unitOfWork = unitOfWork;
            _statementPagination = statementPagination;
        }

        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int PageSize { get; set; } = 100;
        public int TotalPages { get => (int)Math.Ceiling(decimal.Divide(Count, PageSize)); }

        public List<Statement> Statements { get; set; }
        public void OnGet()
        {
            var currentLanguage = CultureInfo.CurrentCulture;

            Statements = _statementPagination.GetPaginationResult(CurrentPage, PageSize).ToList();
            Count = _statementPagination.GetCount();
        }
    }
}