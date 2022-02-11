using NookApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookApplication.Services
{
    public class RenterRepo : IRepo<int, Renter>
    {
        private readonly NookContext _context;

        public RenterRepo(NookContext context)
        {
            _context = context;
        }

        public bool Add(Renter item)
        {
            _context.Renters.Add(item);
            _context.SaveChanges();
            return true;
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

        public bool Remove(int id)
        {
            Renter ren = Get(id);
            _context.Renters.Remove(ren);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Renter item)
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
                return true;
            }
            return false;
        }
    }
}
