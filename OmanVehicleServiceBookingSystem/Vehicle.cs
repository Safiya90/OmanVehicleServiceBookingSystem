using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanVehicleServiceBookingSystem
{
    internal class Vehicle
    {

           public Customer customer;
            public string Platenumber{ get; set; }
            public string Model { get; set; }
            public string type { get; set; }

        public Vehicle(Customer customer, string platenumber, string model, string type) { }


        public Vehicle(string platenumber) 
        {
            Platenumber = platenumber;
        }

        public Vehicle(Customer customer,int id, string platenumber, string model, string type)

        {
            this.customer = customer;
            Platenumber = platenumber;
            Model = model;
            this.type = type;
        }
    }
}
