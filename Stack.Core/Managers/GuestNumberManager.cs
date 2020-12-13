using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stack.DAL;
using Stack.Entities.Models;
using Stack.Repository;

namespace Stack.Core.Managers
{
    public class GuestNumberManager : Repository<GuestNumber, ApplicationDbContext>
    {
        public GuestNumberManager(ApplicationDbContext _context) : base(_context)
        {

        }
    }
}
