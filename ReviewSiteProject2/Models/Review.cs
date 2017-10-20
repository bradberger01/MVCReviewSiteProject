using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSiteProject2.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string ReviewTitle { get; set; }
    
        public string ReviewContent { get; set; }
        public DateTime PublishingDate { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}