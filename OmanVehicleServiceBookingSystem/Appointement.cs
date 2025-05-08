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
        public DateTime  Date { get; set; }
        public DateTime Time { get; set; }
        public double TotalCost { get; set; }

        public Appointement(DateTime date, DateTime time)
        {
            Date = date;
            Time = time;
        }

        public Appointement(int id, string date, string time, double totalCost)
        {
            this.id = id;
            this.date = date;
            this.time = time;
            TotalCost = totalCost;
        }



    }
}
