using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanVehicleServiceBookingSystem
{
    internal class Service
    {
        public string PlateNumber { get; set; }
        public DateTime Date { get; set; }
        public string Issue { get; set; }
        public string PartReplaced { get; set; }
        public double Cost { get; set; }

        public Service()
        {

        }

        public Service(string plateNumber, string issue, string partReplaced, double cost, DateTime date) 
        {
            PlateNumber = plateNumber;
            Issue = issue;
            PartReplaced = partReplaced;
            Cost = cost;
            Date = date;
        }
    }
}
