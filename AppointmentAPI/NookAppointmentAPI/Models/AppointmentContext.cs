using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookAppointmentAPI.Models
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Appointment> Appointments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment { AppointmentId = 101, RenteeUserName = "101", RenterUserName = "102", StartDateTime = new DateTime(2021, 12, 31, 14, 50, 44), 
                    EndDateTime = new DateTime(2022, 12, 31, 15, 15, 23), Fees = 22.3, PlacementDate = new DateTime(2022, 10, 31, 15, 15, 0), 
                    UpdateDate = new DateTime(2022, 10, 31, 15, 15, 0), Status = "Pending"
                },
                new Appointment { AppointmentId = 102, RenteeUserName = "102", RenterUserName = "105", StartDateTime = new DateTime(2022, 01, 14, 12, 42, 23), 
                    EndDateTime = new DateTime(2022, 1, 14, 13, 10, 44), Fees = 43, PlacementDate = new DateTime(2022, 01, 13, 15, 15, 0),
                    UpdateDate = new DateTime(2022, 01, 14, 15, 15, 0), Status = "Completed"
                },
                new Appointment { AppointmentId = 103, RenteeUserName = "103", RenterUserName = "103", StartDateTime = new DateTime(2022, 01, 30, 17, 46, 53), 
                    EndDateTime = new DateTime(2022, 01, 30, 19, 30, 53), Fees = 23.5, PlacementDate = new DateTime(2022, 01, 10, 15, 15, 0),
                    UpdateDate = new DateTime(2022, 01, 31, 15, 15, 0), Status = "Completed"
                });
         }
    }
}
