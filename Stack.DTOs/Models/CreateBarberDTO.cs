﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stack.DTOs.Models
{
    public class CreateBarberDTO
    {
        public string NameAR { get; set; }
        public string NameEN { get; set; }
        public string BarberProfilePhotoPathAdmin { get; set; }
        public string BarberProfilePhotoPathUser { get; set; }
        public string BarberFingerprintId { get; set; }
    }

}
