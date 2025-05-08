using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanVehicleServiceBookingSystem
{
    public class Technician
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public Technician(int id, string username, int phonenumber)
        {
            Id = id;
            Username = username;
        }

    }
}
