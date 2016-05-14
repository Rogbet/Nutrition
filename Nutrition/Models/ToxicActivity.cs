using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nutrition.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nutrition.Models
{
    public class ToxicActivity
    {
        public int ToxicActivityID { get; set; }
        public EnumToxicActivityFrecuency Frecuency { get; set; }
        public string Amount { get; set; }
    }
}