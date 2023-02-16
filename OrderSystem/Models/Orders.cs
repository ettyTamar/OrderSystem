using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace OrderSystem.Models
{
    public class Orders
    {
        [Required]
        [Display(Name = "OrderId")]
        public int OrderId { get; set; }

        [Display(Name = "OrderDate")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "OrderSum")]
        public int OrderSum { get; set; }
    }
}