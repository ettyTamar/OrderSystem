using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace OrderSystem.Models
{
    public class User
    {
        [Display(Name = "UserId")]
        public int UserId { get; set; }

        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "RoleId")]
        public int RoleId { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}