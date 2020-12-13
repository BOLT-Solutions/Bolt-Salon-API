
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Stack.DTOs.Models;
using Stack.Core;
using Stack.DTOs;
using Stack.DTOs.Enums;
 using Stack.Entities.Models;

namespace Stack.ServiceLayer
{
    public class QuestionFeedbackService
    {
        private readonly UnitOfWork unitOfWork;
        private readonly IConfiguration config;

        public QuestionFeedbackService(UnitOfWork unitOfWork, IConfiguration config)
        {
            this.unitOfWork = unitOfWork;
            this.config = config;
        }

    }
}

