﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.Models.Interfaces
{
    interface IImage
    {
        int ID { get; set; }
        byte[] Image { get; set; }
    }
}
