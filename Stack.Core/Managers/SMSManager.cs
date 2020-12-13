using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stack.DAL;
using Stack.Entities.Models;
using Stack.Repository;

namespace Stack.Core.Managers
{
    public class SMSManager : Repository<SMS, ApplicationDbContext>
    {
        public SMSManager(ApplicationDbContext _context) : base(_context)
        {

        }
         public SMS GEtSmsById(int id)
        {
            var sms = context.SMS.Where(b => b.Id == id ).FirstOrDefault();

            return sms;
        }


    }
}
