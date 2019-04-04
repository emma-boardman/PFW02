using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmmasCauseShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual List<Cause> CategoryCauses { get; set; }
    }
}