using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class info
    {
        public int id { get; set; }
        [Display(Name = "First Name")]
        public string firstname { get; set; }
        [Display(Name = "Last Name")]
        public string lastname { get; set; }

        [ForeignKey("Amountid")]
        public Amount Amountt { get; set; }
        [Display(Name = "Payment")]
        public int Amountid { get; set; }
        public IEnumerable<Amount> AmountS { get; set;}



     

    }
}