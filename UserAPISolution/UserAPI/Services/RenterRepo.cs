using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Models;

namespace UserAPI.Services
{
    public class RenterRepo : IRepo<int, Renter>
    {
        private readonly UserDbContext _context;

        public RenterRepo(UserDbContext context)
        {
            _context = context;
        }

        public Renter Add(Renter item)
        {
            Renter ren = _context.Renters.FirstOrDefault(r => r.Email == item.Email);
            if (ren == null)
            {
                _context.Renters.Add(item);
                _context.SaveChanges();
                return ren;
            }
            return null;
        }

        public Renter Get(int id)
        {
            Renter ren = _context.Renters.FirstOrDefault(c => c.UserId == id);
            return ren;
        }

        public ICollection<Renter> GetAll()
        {
            return _context.Renters.ToList();
        }

        public Renter Delete(int id)
        {
            Renter ren = Get(id);
            if (ren != null)
            {
                _context.Renters.Remove(ren);
                _context.SaveChanges();
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
                _context.Renters.Update(ren);
                _context.SaveChanges();
            }
            return null;
        }
    }
}
