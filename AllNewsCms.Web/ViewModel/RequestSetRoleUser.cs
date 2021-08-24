using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllNewsCms.Web.ViewModel
{
    public class RequestSetRoleUser
    {
        public int Id { get; set; }
        public List<int> RoleId { get; set; }
    }
}
