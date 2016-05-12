using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nutrition.Models.Interfaces;

namespace Nutrition.Models
{
    public class PatientImage : IImage
    {
        public int Id
        {
            get;
            set;
        }

        public byte[] Image
        {
            get;
            set;
        }
    }
}