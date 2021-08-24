using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class CompanyRepository:Repository<Company>,ICompanyRepository
    {
        public CompanyRepository(AllNewsDbContext context):base(context)
        {

        }

        public IEnumerable<Company> GetAllCompany()
        {
            return GetAll().OrderByDescending(x => x.UpdatedDate).ToList();
        }

        public IEnumerable<Company> Last4Company(bool sortDesc = true, int? countItem = null, string culture = null)
        {

       
            var random = new Random();


            if (countItem != null)
            {
                if (sortDesc)                 
                return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).OrderBy(x=>random.Next()).Take((int)countItem).ToList();
            }

            return Find(x => culture == null || x.SiteLanguage.LangTitle == culture).OrderByDescending(x => x.UpdatedDate).ToList();
        }




    }
}
