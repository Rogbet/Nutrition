using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Nutrition.Models.Enums
{
    public enum EnumFoodGroup
    {
        [Description("Frutas")]
        Fruit,
        [Description("Vegatales")]
        Vegetable,
        [Description("Cereales")]
        Cereal,
        [Description("Otro")]
        Other
    }
}