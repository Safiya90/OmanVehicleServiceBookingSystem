using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanVehicleServiceBookingSystem
{
    internal class Appointement
    {
        public string PlateNumber { get; set; }
        public DateTime  Date { get; set; }
        public TimeSpan Time { get; set; }

        public Appointement()
        {
            
        }
        public Appointement(string plateNumber, DateTime date, TimeSpan time)
        {
            PlateNumber = plateNumber;
            Date = date;
            Time = time;
        }

    }
}
