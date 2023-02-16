using OrderSystem.Controllers;
using OrderSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace OrderSystem.Models
{
    public class OrderAnswer
    {
            [Display(Name = "Orders")]
            public List<Orders> Orders { get; set; }
    }
}
