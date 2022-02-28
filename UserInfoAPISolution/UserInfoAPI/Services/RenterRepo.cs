using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserInfoAPI.Models;

namespace UserInfoAPI.Services
{
    public class RenterRepo : IRepo<string, Renter>
    {
        private readonly UserInfoDbContext _context;

        public RenterRepo(UserInfoDbContext context)
        {
            _context = context;
        }

        public Renter Add(Renter item)
        {
            _context.Renters.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Renter Get(string id)
        {
            Renter ren = _context.Renters.FirstOrDefault(c => c.UserId == id);
            return ren;
        }

        public ICollection<Renter> GetAll()
        {
            return _context.Renters.ToList();
        }

        public Renter Delete(string id)
        {
            Renter ren = Get(id);
            if (ren != null)
            {
                _context.Renters.Remove(ren);
                _context.SaveChanges();
                return ren;
            }
            return null;
        }

        public Renter Update(Renter item)
        {
            Renter ren = _context.Renters.FirstOrDefault(r => r.UserId == item.UserId);
            if (ren != null)
            {
                ren.FullName = item.FullName;
                ren.NickName = item.NickName;
                ren.DOB = item.DOB;
                ren.About = item.About;
                ren.Image = item.Image;
                _context.Renters.Update(ren);
                _context.SaveChanges();
                return ren;
            }
            return null;
        }
    }
}
