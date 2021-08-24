using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class VideoTagRepository:Repository<VideoTag>,IVideoTagRepository
    {
        public VideoTagRepository(AllNewsDbContext context):base(context)
        {

        }
    }
}
