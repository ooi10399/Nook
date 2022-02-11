using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookApplication.Models
{
    public class NookContext : DbContext
    {
        public NookContext(DbContextOptions options) : base(options)
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
                    UserId = 101,
                    Email = "elicam@email.com",
                    FullName = "Elizabeth Cambridge",
                    NickName = "Eli",
                    DOB = new DateTime(1974, 7, 10),
                    Gender = false,
                    Password = "elipass",
                    About = "Call me queen.",
                    Fee = 20.0
                },
                new Rentee()
                {
                    UserId = 102,
                    Email = "philc@email.com",
                    FullName = "Phillip Cambridge",
                    NickName = "Phil",
                    DOB = new DateTime(1974, 7, 10),
                    Gender = true,
                    Password = "philpass",
                    About = "Call me king.",
                    Fee = 20.0
                });

            // RENTER
            modelBuilder.Entity<Renter>().HasData(
                new Renter()
                {
                    UserId = 101,
                    Email = "johndoe@email.com",
                    FullName = "John Doe",
                    NickName = "John",
                    DOB = new DateTime(1974, 7, 10),
                    Gender = true,
                    Password = "johnpass",
                    About = "Will call you queen."
                },

                new Renter()
                {
                    UserId = 102,
                    Email = "janedoe@email.com",
                    FullName = "Jane Doe",
                    NickName = "Jane",
                    DOB = new DateTime(1974, 7, 10),
                    Gender = false,
                    Password = "janepass",
                    About = "Will call you king."
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
