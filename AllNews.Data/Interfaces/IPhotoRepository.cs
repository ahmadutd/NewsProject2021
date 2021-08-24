using AllNews.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllNews.Data.Interfaces
{
    public interface IPhotoRepository:IRepository<Photo>
    {
       
        IEnumerable<Photo> GetPhotos(bool sortDesc = true, int? countItem = null, string culture = null);
    }
}
