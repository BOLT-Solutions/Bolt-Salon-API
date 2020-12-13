﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack.DAL;
using Stack.Entities.Models;
using Stack.Repository;

namespace Stack.Core.Managers
{
    public class ServiceFeedBackQuestionsManager : Repository<ServiceFeedBackQuestion, ApplicationDbContext>
    {
        public ServiceFeedBackQuestionsManager(ApplicationDbContext _context) : base(_context)
        {

        }

        public async Task<List<ServiceFeedBackQuestion>> GetServiceFeedBackQuestionsByServiceId(string serviceId)
        {
            return await Task.Run(() =>
            {
                List<ServiceFeedBackQuestion> serviceFeedBackQuestions = context.ServiceFeedBackQuestions.Where(a => a.ServiceId == int.Parse(serviceId)).ToList();
                return serviceFeedBackQuestions;
            });
        }

    }
}
