using AllNewsCms.Web.Inferistruct.Const;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllNewsCms.Web.Common
{
    public static class PermissionService
    {

        public static void AddNicePermissionService(this IServiceCollection service)
        {
            service.AddScoped<IAuthorizationHandler, NicePermissionAuthHandler>();
            service.AddAuthorization(options =>
            {
                options.AddPolicy(Permissions.NicePermission, policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.Requirements.Add(new NicePermissionRequirement());

                });
            }
            );
        }
    }
}
