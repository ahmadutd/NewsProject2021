using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using AllNews.Domain;
using Domain = AllNews.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace AllNewsCms.Web.Pages.UserActivities
{
    [Authorize(Roles = "Supervisor")]
    public class ActivitiesModel : PageModel
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUnitOfWork _unitOfWork;

        public ActivitiesModel(IUnitOfWork unitOfWork, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
        }

        public List<Domain.News> NewsCounts { get; set; }
        public List<Paper> PaperCounts { get; set; }
        public List<Domain.Studies> StudieCounts { get; set; }
        public List<Domain.Statement> StatementCounts { get; set; }
        public List<Company> CompanyCounts { get; set; }
        public List<Photo> PhotoCounts { get; set; }
        public List<Video> VideoCounts { get; set; }
        public List<Audio> AudioCounts { get; set; }
        public void OnGet(int ? id)
        {
            
            NewsCounts = _unitOfWork.newsRepo.GetAll().Where(n => n.CreatedBy == id).ToList();
            PaperCounts = _unitOfWork.paperRepo.GetAll().Where(n => n.CreatedBy == id).ToList();
            StudieCounts = _unitOfWork.studiesRepo.GetAll().Where(n => n.CreatedBy == id).ToList();
            StatementCounts = _unitOfWork.statementRepo.GetAll().Where(n => n.CreatedBy == id).ToList();
            CompanyCounts = _unitOfWork.companyRepo.GetAll().Where(n => n.CreatedBy == id).ToList();
            PhotoCounts = _unitOfWork.photoRepo.GetAll().Where(n => n.CreatedBy == id).ToList();
            VideoCounts = _unitOfWork.videoRepo.GetAll().Where(n => n.CreatedBy == id).ToList();
            AudioCounts = _unitOfWork.audioRepo.GetAll().Where(n => n.CreatedBy == id).ToList();

        }
    }
}