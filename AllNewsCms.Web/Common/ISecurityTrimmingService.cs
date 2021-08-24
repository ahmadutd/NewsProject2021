using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllNewsCms.Web.Common
{
    public interface ISecurityTrimmingService
    {
        bool CanCurrentUserAccess(string page);
    }
}
