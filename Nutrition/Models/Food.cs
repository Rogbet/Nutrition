using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nutrition.Models.Enums;

namespace Nutrition.Models
{
    public class Food
    {
        public int FoodID { get; set; }
        public Boolean Active { get; set; }
        public  EnumFoodGroup FoodGroup{ get; set; }
        public int Calories { get; set; }
        public int Carbs { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
    }
}