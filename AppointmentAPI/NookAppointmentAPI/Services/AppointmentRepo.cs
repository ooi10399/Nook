using NookAppointmentAPI.Constant;
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
            item.PlacementDate = DateTime.Now;
            item.UpdateDate = DateTime.Now;
            item.Status = "Pending";
            _context.Appointments.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Appointment Delete(int key)
        {
            var appointment = GetT(key);
            if (appointment != null)
            {
                appointment.UpdateDate = DateTime.Now;
                appointment.Status = AppointmentStatus.Cancel.ToString();
                //_context.Remove(appointment);
                _context.SaveChanges();
                return appointment;
            }
            return null;
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _context.Appointments.ToList();
        }

        public Appointment GetT(int key)
        {
            var appointment = _context.Appointments.SingleOrDefault(a =>a.AppointmentId == key);
            return appointment;
        }

        public Appointment Update(Appointment item)
        {
            var appointment = GetT(item.AppointmentId);
            if (appointment != null)
            {
                appointment.RenteeUserName = item.RenteeUserName;
                appointment.RenterUserName = item.RenterUserName;
                appointment.StartDateTime = item.StartDateTime;
                appointment.EndDateTime = item.EndDateTime;
                appointment.Fees = item.Fees;
                appointment.Remark = item.Remark;
                appointment.UpdateDate = DateTime.Now;
                appointment.Status = item.Status;
                _context.SaveChanges();
            }
            return appointment;
        }
    }
}
