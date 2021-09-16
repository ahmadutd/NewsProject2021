using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AllNews.Domain.Base
{
    public class BaseEntity<TKey>
    {
        public BaseEntity()
        {
            var datetime = DateTime.Now;
            this.CreatedDate = this.UpdatedDate = datetime.ToEuropianDateTime();
        }


        [Key]
        public TKey Id { get; set; }


        public DateTime CreatedDate { get; set; }


        public DateTime UpdatedDate { get; set; }
        


        public int? CreatedBy { get; set; }


        public int? UpdatedBy { get; set; }
        //public int? DeletedBy { get; set; }


        public virtual AppUser CreatedUser { get; set; }


        public virtual AppUser UpdatedUser { get; set; }
    }
    public static class Helper
    {
        public static DateTime ToEuropianDateTime(this DateTime dateTime)
        {
            TimeZoneInfo europianZone = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
            DateTime convertedDateTime = TimeZoneInfo.ConvertTime(dateTime, europianZone);
            return convertedDateTime;
        }
    }
}
