using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Amount
    {
        public int id { get; set; }

        [Display( Name = "Monthly payment")]
        public int paymentAmount { get; set; }
    }
}