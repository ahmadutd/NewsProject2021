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
            this.CreatedDate = this.UpdatedDate = DateTime.Now;
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
}
