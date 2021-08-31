using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AllNewsCms.Web.AntiRobot.GoogleRecaptcha
{
    public interface IGoogleRecaptcha
    {
        Task<bool> IsSatidfy();
    }
  
}
