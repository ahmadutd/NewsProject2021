using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllNews.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AllNews.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContactUsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var email = _unitOfWork.socialManagmentRepo.Get(x => x.Id == 10);

            return View(email);
        }
    }
}
