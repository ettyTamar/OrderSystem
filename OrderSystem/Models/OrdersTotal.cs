using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace OrderSystem.Models
{
    public class OrdersTotal
    {
        [Required]
        [Display(Name = "UserId")]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "From")]
        public DateTime From { get; set; }

        [Required]
        [Display(Name = "To")]
        public DateTime To { get; set; }
    }
}