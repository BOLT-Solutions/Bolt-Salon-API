using System;
using System.Collections.Generic;
using System.Text;

namespace Stack.DTOs.Models
{
    public class OrderToAddDTO
    {
        public int BarberQueueId { get; set; }
        public int CustomerId { get; set; }
        public virtual List<OrderServiceToAddDTO> OrderServices { get; set; }
        public float  DiscountRate { get; set; }
    }
}
