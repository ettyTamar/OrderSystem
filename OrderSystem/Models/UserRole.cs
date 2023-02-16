using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace OrderSystem.Models
{
    public class UserRole
    {
        [Required]
        [Display(Name = "ID")]
        public int ID { get; set; }
    }
}