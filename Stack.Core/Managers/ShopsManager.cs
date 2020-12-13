using System;
using System.Collections.Generic;
using System.Text;
using Stack.DAL;
using Stack.Entities.Models;
using Stack.Repository;

namespace Stack.Core.Managers
{
    public class ShopsManager : Repository<Shop, ApplicationDbContext>
    {
        public ShopsManager(ApplicationDbContext _context) : base(_context)
        {

        }



    }
}
