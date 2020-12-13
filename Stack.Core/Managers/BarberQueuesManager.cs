using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Stack.DAL;
using Stack.Entities;
using Stack.Repository;
using Stack.DTOs.Enums;
using Stack.Entities.Models;

namespace Stack.Core.Managers
{
    public class BarbersQueuesManager : Repository<BarberQueue, ApplicationDbContext>
    {
        public BarbersQueuesManager(ApplicationDbContext _context) : base(_context)
        {

        }
        public async Task <int> GetAvilableBarber( )
        {

            return await Task.Run(() =>
            {
                int Result = context.BarberQueues.Where(a => a.QueueStatus == "available").Count();

                return Result;  
                        
            });
        }

        public async Task<BarberQueue> GetBarberQueueByBarberId(int barberId)
        {
            return await Task.Run(() =>
            {
                var res = context.BarberQueues.Where(a => a.BarberId == barberId).FirstOrDefault();
                return res;
            });
        }

    }
}
