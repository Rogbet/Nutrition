using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Nutrition.Models.Enums
{
    public enum EnumToxicActivityFrecuency
    {
        [Description("Poco (1 vez por semana)")]
        Low,
        [Description("Moderado (2-3 veces por semana)")]
        Mid,
        [Description("Alto (Mas de 4 veces por semana")]
        High
    }
}