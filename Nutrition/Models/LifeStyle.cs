using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nutrition.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int CigarActivityID { get; set; }
        public int AlcoholActivityID { get; set; }
        public int DrugActivityID { get; set; }

        [ForeignKey("CigarActivityID")]
        public virtual ToxicActivity CigarActivity { get; set; }
        [ForeignKey("AlcoholActivityID")]
        public virtual ToxicActivity AlcoholActivity { get; set; }
        [ForeignKey("DrugActivityID")]
        public virtual ToxicActivity DrugActivity { get; set; }
    }
}