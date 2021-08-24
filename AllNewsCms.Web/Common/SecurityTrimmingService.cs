using AllNewsCms.Web.Inferistruct.Const;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AllNewsCms.Web.Common
{
    public class SecurityTrimmingService : ISecurityTrimmingService
    {

        private readonly HttpContext _httpContext;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public SecurityTrimmingService(
            IHttpContextAccessor httpContextAccessor
           )
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
            _httpContext = _httpContextAccessor.HttpContext;
        }

        public bool CanCurrentUserAccess(string page)
        {
            return _httpContext != null && CanUserAccess(_httpContext.User,page);
        }

    
        public bool CanUserAccess(ClaimsPrincipal user, string page)
        {
            var currentClaimValue = $"{page}";
            //if (!securedPage.SelectMany(x => x.MvcActions).Any(x => x.ActionId == currentClaimValue))
            //{
            //    throw new KeyNotFoundException($"The `secured` area={area}/controller={page} with `Permissions.NicePermission` policy not found. Please check you have entered the area/controller/action names correctly and also it's decorated with the correct security policy.");
            //}

            if (!user.Identity.IsAuthenticated)
            {
                return false;
            }

            if (user.IsInRole(PermissionRole.Supervisor))
            {
               
                return true;
            }

            // Check for dynamic permissions
            // A user gets its permissions claims from the `ApplicationClaimsPrincipalFactory` class automatically and it includes the role claims too.
            return user.HasClaim(claim => claim.Type == Permissions.NicePermissionType && claim.Value == currentClaimValue) && user.IsInRole(PermissionRole.Admin);
        }
    }
}
