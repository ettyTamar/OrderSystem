using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace OrderSystem.Models
{
    public class UserRoleAnswer
    {
        [Display(Name = "Users")]
        public List<User> Users { get; set; }
    }
}