﻿using System;
using System.Collections.Generic;
using Stack.DTOs.Models;

namespace Stack.DTOs.Models
{
    public class OrderFeedbackQuestionDTO
    {
        public int Id { get; set; }
        public string QuestionAR { get; set; }
        public string QuestionEN { get; set; }
        public int? Rating { get; set; }
        public int OrderFeedbackId { get; set; }
        public virtual OrderFeedbackDTO OrderFeedback { get; set; }

    }
}
