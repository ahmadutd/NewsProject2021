using AllNews.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Domain
{
    public class SocialManagment:BaseEntity<int>
    {
        public SocialManagment():base()
        {

        }

        public string InstagramIdName { get; set; }
        public string AddressEmail { get; set; }
        public string TelegramIdName { get; set; }
        public string YoutubeIdName { get; set; }
        public string TwitterIdName { get; set; }
        public string FacebookIdName { get; set; }
    }
}
