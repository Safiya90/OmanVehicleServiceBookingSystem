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
        private int IdCounter = 000;


        public Customer( string username, int phonenumber)
            {
                Id = "C" + IdCounter++;
                Username = username;
                Phonenumber = phonenumber;
            }

        }
        
    }
