using System;
using System.Collections.Generic;

namespace Stack.Entities.Models
{
    public partial class Administrator
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ShopId { get; set; }

        public string Role { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
