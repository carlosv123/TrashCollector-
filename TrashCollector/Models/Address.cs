using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Display(Name = "first Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Street Name")]
        public string streetName { get; set; }

        public string city { get; set; }
        public string zipcode { get; set; }
        
        [Display(Name = "Start week pick up")]
        public DateTime StartSchedule { get; set; }
    }
}