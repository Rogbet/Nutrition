using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nutrition.ViewModels;
using Nutrition.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nutrition.Models
{
    public class Patient
    {
        public Patient()
        {
            Measurements = new List<PatientMeasurement>();
        }

        public int PatientID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public Boolean Active { get; set; }
        public EnumGender Gender { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string CellPhone { get; set; }
        public string Notes { get; set; }

        public int ImageID { get; set; }
        [ForeignKey("ImageID")]
        public virtual Image Image { get; set; }
        public virtual ICollection<PatientMeasurement> Measurements { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}