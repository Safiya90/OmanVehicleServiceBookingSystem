using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanVehicleServiceBookingSystem
{
    internal class Booking
    {
        public Booking(string service, string appointement)
        {
            this.service = service;
            this.appointement = appointement;
        }

        public string service { get; set; }
        public string appointement { get; set; }
    }
}
