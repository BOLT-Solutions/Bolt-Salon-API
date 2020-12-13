using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack.DAL;
using Stack.DTOs.Models;
using Stack.Entities.Models;
using Stack.Repository;

namespace Stack.Core.Managers
{
    public class PromoCodeManager : Repository<PromoCode, ApplicationDbContext>
    {
        public PromoCodeManager(ApplicationDbContext _context) : base(_context)
        {

        }

    }
}
