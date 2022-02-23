using NookAppointmentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookAppointmentAPI.Services
{
    public class AppointmentRepo : IRepo<int, Appointment>
    {
        private readonly AppointmentContext _context;

        public AppointmentRepo(AppointmentContext context)
        {
            _context = context;
        }
        public Appointment Add(Appointment item)
        {
            _context.Appointments.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Appointment Delete(int key)
        {
            var appointment = _context.Appointments.SingleOrDefault(a => a.Id == key);
            if (appointment != null)
            {
                _context.Remove(appointment);
                _context.SaveChanges();
            }
            return appointment;

        }

        public IEnumerable<Appointment> GetAll()
        {
            return _context.Appointments.ToList();
        }

        public Appointment GetT(int key)
        {
            var appointment = _context.Appointments.SingleOrDefault(a =>a.Id == key);
            return appointment;
        }

        public Appointment Update(Appointment item)
        {
            var appointment = _context.Appointments.SingleOrDefault(a => a.Id == item.Id);
            if (appointment != null)
            {
                appointment.startDateTime = item.startDateTime;
                appointment.endDateTime = item.endDateTime;
                appointment.Fees = item.Fees;
                _context.SaveChanges();
            }
            return appointment;
        }
    }
}
