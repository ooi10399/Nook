using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserInfoAPI.Models
{
    public class UserInfoDbContext : DbContext
    {
        public UserInfoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Interest> Interests { get; set; }
        public DbSet<Rentee> Rentees { get; set; }
        public DbSet<Renter> Renters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // RENTEE
            modelBuilder.Entity<Rentee>().HasData(
                new Rentee()
                {
                    UserId = "elicam@email.com",
                    FullName = "Elizabeth Cambridge",
                    NickName = "Eli",
                    DOB = new DateTime(1974, 7, 10),
                    Gender = "Female",
                    About = "Call me queen.",
                    Fee = 20.0,
                    Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTL6pp1VJnOv1D9ATTMZz2ZGzP93IKty-zVQw&usqp=CAU",
                    IsActive = true
                },
                new Rentee()
                {
                    UserId = "philc@email.com",
                    FullName = "Phillip Cambridge",
                    NickName = "Phil",
                    DOB = new DateTime(1974, 7, 10),
                    Gender = "Male",
                    About = "Call me king.",
                    Fee = 20.0,
                    Image = "http://www.zebuinvestments.com/wp-content/uploads/2020/05/Guy-Final.jpg",
                });

            // RENTER
            modelBuilder.Entity<Renter>().HasData(
                new Renter()
                {
                    UserId = "johndoe@email.com",
                    FullName = "John Doe",
                    NickName = "John",
                    DOB = new DateTime(1974, 7, 10),
                    Gender = "Male",
                    About = "Will call you queen.",
                    Image = "",
                    IsActive = true
                },

                new Renter()
                {
                    UserId = "janedoe@email.com",
                    FullName = "Jane Doe",
                    NickName = "Jane",
                    DOB = new DateTime(1974, 7, 10),
                    Gender = "Female",
                    About = "Will call you king.",
                    Image = ""
                });

            // INTEREST
            modelBuilder.Entity<Interest>().HasData(
                new Interest()
                {
                    IntId = 1,
                    IntName = "Cafe-hopping"
                },

                new Interest()
                {
                    IntId = 2,
                    IntName = "Pottery-making"
                });
        }
    }
}
