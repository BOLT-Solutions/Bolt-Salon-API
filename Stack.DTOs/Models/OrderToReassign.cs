using System;
using System.Collections.Generic;
using System.Text;

namespace Stack.DTOs.Models
{
    public class OrderToReassign
    {
        public int? OrderId { get; set; }
        public int? NewQueueId { get; set; }
    }
}
