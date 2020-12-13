using System;
using System.Collections.Generic;
using System.Text;
using Stack.DTOs.Models;

namespace Stack.DTOs.Models
{
    public class OrderServiceToAddDTO
    {
        //ServiceID
        public int ServiceId { get; set; }
        public string NameAR { get; set; }
        public string NameEN { get; set; }
        public float? Price { get; set; }
        public int? Time { get; set; }
        public bool? IsConfirmed { get; set; }
    }
}
