using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stack.Entities.Models
{
    public partial class BarberProfilePhoto
    {
        public int Id { get; set; }
        public string AdminPath { get; set; }
        public string UserPath { get; set; }
        public int BarberId { get; set; }
        public virtual Barber Barber { get; set; }
    }
}
