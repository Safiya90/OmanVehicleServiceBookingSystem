using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanVehicleServiceBookingSystem
{
    internal class Service
    {
        public int Id { get; set; }
        public string Issue { get; set; }
        public string PartReplaced { get; set; }
        public double Cost { get; set; }

        public Service(int id, string issue, string partReplaced, double cost) 
        { 
            Id = id;
            Issue = issue;
            PartReplaced = partReplaced;
            Cost = cost;
        }
    }
}
