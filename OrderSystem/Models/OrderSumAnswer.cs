using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace OrderSystem.Models
{
    public class OrderSumAnswer
    {
            [Display(Name = "OrderSum")]
            public float OrderSum { get; set; }
    }
}