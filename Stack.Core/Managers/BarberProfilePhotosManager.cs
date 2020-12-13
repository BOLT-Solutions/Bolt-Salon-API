using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack.DAL;
using Stack.Entities.Models;
using Stack.Repository;

namespace Stack.Core.Managers
{
    public class BarberProfilePhotosManager : Repository<BarberProfilePhoto, ApplicationDbContext>
    {
        public BarberProfilePhotosManager(ApplicationDbContext _context) : base(_context)
        {

        }
        public async Task<BarberProfilePhoto> GetProfilePhotoByBarberId(int barberId)
        {
            return await Task.Run(() =>
            {
                var res = context.BarberProfilePhotos.Where(a => a.BarberId == barberId).FirstOrDefault();
                return res;
            });
        }


    }
}
