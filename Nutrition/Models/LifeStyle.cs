using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nutrition.Models.Enums;

namespace Nutrition.Models
{
    public class LifeStyle
    {
        public int LifeStyleID { get; set; }
        public string Employment { get; set; }
        public string EmploymentDescription { get; set; }
        public string StressLevel { get; set; }
        public Boolean IsVegan { get; set; }
        public string SportActivity { get; set; }

        public ToxicActivity CigarActivity { get; set; }
        public ToxicActivity AlcoholActivity { get; set; }
        public ToxicActivity DrugActivity { get; set; }
    }
}