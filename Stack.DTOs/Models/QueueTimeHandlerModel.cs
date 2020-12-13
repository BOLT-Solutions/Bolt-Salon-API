using System;
using System.Collections.Generic;
using System.Text;

namespace Stack.DTOs.Models
{
   public class QueueTimeHandlerModel
    {
        public int QueueId { get; set; }
        public DateTime? QueueEstimatedFinishTime { get; set; }
        public double? QueueEstimatedWaitingTime { get; set; }
        public List <OrderDTO> Orders { get; set; }
    }
}
