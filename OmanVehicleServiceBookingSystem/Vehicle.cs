using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanVehicleServiceBookingSystem
{
    internal class Vehicle
    {

        public string customerID;
        public string Platenumber{ get; set; }
        public string Model { get; set; }
        public string Type { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string CustomerId,int id, string platenumber, string model, string type)

        {
            customerID = CustomerId;
            Platenumber = platenumber;
            Model = model;
            Type = type;
        }
    }
}
