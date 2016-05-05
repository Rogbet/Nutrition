using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nutrition.ViewModels;

namespace Nutrition.Models
{
    public class Patient
    {
        public int PatientID { get; set; }

        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public int Age { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}