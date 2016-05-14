using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nutrition.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nutrition.Models
{
    public class Image
    {
        public int ImageID { get; set; }
        public byte[] ImageData { get; set; }
    }
}