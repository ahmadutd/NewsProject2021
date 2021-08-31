using System;
using AllNewsCms.Web.AntiRobot.GoogleRecaptcha;
using AllNewsCms.Web.AntiRobot.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AllNewsCms.Web.AntiRobot.Service
{
    public class GoogleRecaptcha : IGoogleRecaptcha
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _accessor;
        public GoogleRecaptcha(IHttpContextAccessor accessor, IConfiguration configuration)
        {
            _accessor = accessor;
            _configuration = configuration;

        }
        public async Task<bool> IsSatidfy()
        {
            var secretKey = _configuration.GetSection("GoogleReCAPTCHA")["SecretKey"];
            var response = _accessor.HttpContext.Request.Form["g-recaptcha-response"];
            var http = new HttpClient();
            var result =
                await http.PostAsync($"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={response}", null);
            if (result.IsSuccessStatusCode)
            {
                var googleResponse =
                    JsonConvert.DeserializeObject<RecaptchaResponse>(await result.Content.ReadAsStringAsync());
                if (googleResponse == null)
                    return false;
                return googleResponse.Success;
            }
            return false;
        }

        public class RecaptchaResponse
        {
            [JsonProperty("success")]
            public bool Success { get; set; }

            [JsonProperty("challenge_ts")]
            public DateTimeOffset Challenges { get; set; }

            [JsonProperty("hostname")]
            public string Hostname { get; set; }
        }
    }
}
