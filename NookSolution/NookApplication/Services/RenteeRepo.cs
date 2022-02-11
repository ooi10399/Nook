using NookApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookApplication.Services
{
    public class RenteeRepo : IRepo<int, Rentee>
    {
        private readonly NookContext _context;

        public RenteeRepo(NookContext context)
        {
            _context = context;
        }

        public bool Add(Rentee item)
        {
            _context.Rentees.Add(item);
            _context.SaveChanges();
            return true;
        }

        public Rentee Get(int id)
        {
            Rentee ren = _context.Rentees.FirstOrDefault(c => c.UserId == id);
            return ren;
        }

        public ICollection<Rentee> GetAll()
        {
            return _context.Rentees.ToList();
        }

        public bool Remove(int id)
        {
            Rentee ren = Get(id);
            _context.Rentees.Remove(ren);
            _context.SaveChanges();
            return true;
        }

        public bool Update(Rentee item)
        {
            Rentee ren = _context.Rentees.FirstOrDefault(r => r.UserId == item.UserId);
            if (ren != null)
            {
                ren.FullName = item.FullName;
                ren.NickName = item.NickName;
                ren.DOB = item.DOB;
                ren.About = item.About;
                ren.Interests = item.Interests;
                ren.Fee = item.Fee;
                _context.Rentees.Update(ren);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
