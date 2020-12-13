using System;
using System.Collections.Generic;

namespace Stack.Entities.Models
{
    public partial class ServiceFeedBackQuestion
    {
        public int Id { get; set; }
        public string QuestionAR { get; set; }
        public string QuestionEN { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Service { get; set; }
    }
}
