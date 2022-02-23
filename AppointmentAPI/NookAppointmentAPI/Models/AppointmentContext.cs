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
                new Appointment { Id = 101, startDateTime = new DateTime(2021, 12, 31, 14, 50, 44), endDateTime = new DateTime(2022, 12, 31, 15, 15, 23), Fees = 22.3 },
                new Appointment { Id = 101, startDateTime = new DateTime(2022, 01, 14, 12, 42, 23), endDateTime = new DateTime(2022, 22, 31, 13, 10, 44), Fees = 43 },
                new Appointment { Id = 101, startDateTime = new DateTime(2022, 01, 30, 17, 46, 53), endDateTime = new DateTime(2022, 22, 31, 19, 30, 53), Fees = 23.5 });
         }
    }
}
