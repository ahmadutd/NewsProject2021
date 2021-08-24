using AllNews.Data.Interfaces;
using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Repositores
{
    public class PhotoTagRipository:Repository<PhotosTag>,IPhotoTagRepository
    {
        public PhotoTagRipository(AllNewsDbContext context):base(context)
        {
                
        }
    }
}
