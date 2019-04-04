using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace EmmasCauseShop.Models
{
    public class Cause
    {
        public int CauseId { get; set; }
        //[ForeignKey("CauseCreator")]
        public string CauseCreatorId { get; set; }
        public User CauseCreator { get; set; }
        [Required]
        public string CauseTitle { get; set; }
        [Required]
        public string CauseDescription { get; set; }
        public string CausePictureUrl { get; set; }
        //[ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
  
        public virtual List<User> Signatures { get; set; }
    }
}