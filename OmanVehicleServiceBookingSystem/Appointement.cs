using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanVehicleServiceBookingSystem
{
    internal class Appointement
    {
        public int id { get; set; }
        public string  date { get; set; }
        public string time { get; set; }
        public double cost { get; set; }
        public Appointement(int id, string date, string time, double cost)
        {
            this.id = id;
            this.date = date;
            this.time = time;
            this.cost = cost;
        }



    }
}
