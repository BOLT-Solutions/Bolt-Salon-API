using Stack.DAL;
using Stack.Entities;
using Stack.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stack.DTOs.Enums;
using System;
using System.Linq.Expressions;
using Stack.Entities.Models;

namespace Stack.Core.Managers
{
    public class OrderFeedBacksManager : Repository<OrderFeedback, ApplicationDbContext>
    {
        public OrderFeedBacksManager(ApplicationDbContext _context) : base(_context)
        {

        }

        public async Task<List<OrderFeedback>> GetFeedbackBySubmittedStatus()
        {
            return await Task.Run(() =>
            {
                List<OrderFeedback> orderFeedback = context.OrderFeedbacks.Where(a => a.IsSubmitted == true).ToList();
                return orderFeedback;
            });
        }


    }
}
