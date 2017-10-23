using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSiteProject2.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [DisplayName("Country")]
        public string CategoryName { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}