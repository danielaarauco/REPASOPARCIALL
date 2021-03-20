using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace repasoconleoo.Models
{
    public class Country
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Capital { get; set; }
        public int Population { get; set; }
        public double Lating { get; set; }
        public string Timezones { get; set; }
        public Currency Currencies { get; set; }
        public string Flag { get; set; }

    }
}