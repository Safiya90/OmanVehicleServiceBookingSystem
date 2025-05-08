using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanVehicleServiceBookingSystem
{
    internal class Vehicle
    {
        public int id { get; set; }
            public string Platenumber{ get; set; }
            public string Model { get; set; }
            public string type { get; set; }
        public Vehicle(int id, string platenumber, string model, string type)
        {
            this.id = id;
            Platenumber = platenumber;
            Model = model;
            this.type = type;
        }
    }
}
