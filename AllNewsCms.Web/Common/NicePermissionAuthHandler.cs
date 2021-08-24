using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllNewsCms.Web.Common
{
    public class NicePermissionAuthHandler : AuthorizationHandler<NicePermissionRequirement>
    {
        private readonly ISecurityTrimmingService _securityTrimmingService;

        public NicePermissionAuthHandler(ISecurityTrimmingService securityTrimmingService)
        {
            _securityTrimmingService = securityTrimmingService;
            if (_securityTrimmingService == null)
                throw new ArgumentNullException(nameof(_securityTrimmingService));
        }
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context
            , NicePermissionRequirement requirement
            )
        {
            string page = context.Resource.ToString();
            if (_securityTrimmingService.CanCurrentUserAccess(page))
             
                context.Succeed(requirement);
            else 
                context.Fail();


            return Task.CompletedTask;
        }
    }
}
