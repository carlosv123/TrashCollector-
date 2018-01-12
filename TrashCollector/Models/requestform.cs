using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class requestform
    {
        public int Id { get; set; }
        [Display(Name ="First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Request No pick up start date")]
        public DateTime nopickupstart { get; set; }
        [Display(Name = "Request No pick up end date")]
        public DateTime nopickupend { get; set; }
    }
}