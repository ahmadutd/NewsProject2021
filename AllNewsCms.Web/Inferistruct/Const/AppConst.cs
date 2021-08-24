using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllNewsCms.Web.Inferistruct.Const
{
    public class AppConst
    {
        private static IWebHostEnvironment _env;
        public static string ImageCoverBasePath = $"{AppConst._env.WebRootPath}/Upload/";
    }
}
