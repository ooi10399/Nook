using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserInfoAPI.Models;

namespace UserInfoAPI.Services
{
    public class RenteeRepo : IRepo<string, Rentee>
    {
        private readonly UserInfoDbContext _context;

        public RenteeRepo(UserInfoDbContext context)
        {
            _context = context;
        }

        public ICollection<Rentee> GetAll()
        {
            return _context.Rentees.ToList();
        }

        public Rentee Get(string id)
        {
            Rentee ren = _context.Rentees.FirstOrDefault(r => r.UserId == id);
            return ren;
        }

        public Rentee Add(Rentee item)
        {
            _context.Rentees.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Rentee Delete(string id)
        {
            Rentee ren = Get(id);
            if (ren != null)
            {
                _context.Rentees.Remove(ren);
                _context.SaveChanges();
                return ren;
            }
            return null;
        }

        public Rentee Update(Rentee item)
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
                ren.Image = item.Image;
                _context.Rentees.Update(ren);
                _context.SaveChanges();
                return ren;
            }
            return null;
        }
    }
}
