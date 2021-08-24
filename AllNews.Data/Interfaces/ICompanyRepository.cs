using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface ICompanyRepository:IRepository<Company>
    {

        //IEnumerable<Company> Last4Company();
        IEnumerable<Company> GetAllCompany();
        IEnumerable<Company> Last4Company(bool sortDesc = true, int? countItem = null, string culture = null);
    }
}
