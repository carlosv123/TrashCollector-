using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class payment
    {
        public int Id { get; set; }
        public double amount { get; set; }
        public virtual paymentType paymentType { get; set; }

    }
}