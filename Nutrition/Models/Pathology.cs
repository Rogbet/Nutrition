
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nutrition.Models
{
    public class Pathology
    {
        public string PathologyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Boolean Active { get; set; }
    }
}