using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Nutrition.Models.Enums
{
    public enum EnumBloodType
    {
        [Description("O-")] NegativeO,
        [Description("O-")] PositiveO,
        [Description("A-")] NegativeA,
        [Description("A-")] PositiveA,
        [Description("B-")] NegativeB,
        [Description("B+")] PositiveB,
        [Description("AB-")] NegativeAB,
        [Description("AB+")] PositiveAB
    }
}