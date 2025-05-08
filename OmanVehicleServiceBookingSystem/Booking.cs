using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanVehicleServiceBookingSystem
{
    internal class Booking
    {
        public string Service { get; set; }
        public string Appointment { get; set; }

        public Booking(string service, string appointment)
        {
            Service = service;
            Appointment = appointment;
        }
    }
}
