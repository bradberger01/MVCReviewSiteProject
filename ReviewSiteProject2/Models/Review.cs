using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSiteProject2.Models
{

    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [System.ComponentModel.DisplayName("Title")]
        public string ReviewTitle { get; set; }
        [DisplayName("Body")]
        public string ReviewContent { get; set; }
        [DisplayName("Publishing Date")]
        public DateTime PublishingDate { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}