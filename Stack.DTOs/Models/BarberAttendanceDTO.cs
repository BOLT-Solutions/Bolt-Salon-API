using System;
using System.Collections.Generic;
using System.Text;

namespace Stack.DTOs.Models
{
    public class BarberAttendanceDTO
    {
        public string BarberFingerprintId { get; set; }
        public int Method { get; set; }
        public DateTime CheckDate { get; set; }
    }
}
