using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Domain
{
    public class AppRole:IdentityRole<int>
    {
        public AppRole()
        {

        }

        public AppRole(string roleName) : base(roleName)
        {

        }
    }
}
