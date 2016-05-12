using Nutrition.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nutrition.Models
{
    public class ClinicHistory
    {
        public int ClinicHistoryID { get; set; }
        public string ReasonOfVisit { get; set; }
        public string OtherPathologies { get; set; }
        public List<Pathology> CommonPathologies { get; set; }
        public string SurgeriesPerformed { get; set; }
        public string Allergies { get; set; }
        public string FamilyBackground { get; set; }
        public EnumBloodType BloodType { get; set; }
    }
}