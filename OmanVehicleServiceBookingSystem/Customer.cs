using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanVehicleServiceBookingSystem
{
    public class Customer
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public int Phonenumber { get; set; }

        public Customer()
        {
            
        }
        public Customer(string id, string username, int phonenumber)
        {
            Id = id;
            Username = username;
            Phonenumber = phonenumber;
        }

    }
}
