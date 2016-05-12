using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nutrition.Models
{
    public class PatientMeasurement
    {
        public int PatientMeasurementID { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal ActivityFactor { get; set; }
        public decimal BodyFat { get; set; }
        public decimal WaterPercentage { get; set; }
        public decimal MuscleMass { get; set; }
        public decimal BoneMass { get; set; }
        public decimal VisceralFat { get; set; }
        public int MetabolicAge { get; set; }
        public int Biceps { get; set; }
        public int Triceps { get; set; }
        public int Suprailiac { get; set; }
        public int Ileocrestal { get; set; }
        public int Abdominal { get; set; }
        public int Wrist { get; set; }
        public int Waist { get; set; }
        public int Hip { get; set; }
    }
}