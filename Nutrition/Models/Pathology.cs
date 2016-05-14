
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nutrition.Models
{
    public class Pathology
    {
        public Pathology()
        {
            this.ClinicHistories = new List<ClinicHistory>();
        }

        public string PathologyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Boolean Active { get; set; }

        public virtual ICollection<ClinicHistory> ClinicHistories { get; set; }
    }
}