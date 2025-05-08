using System.ComponentModel.Design;

namespace OmanVehicleServiceBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greeting();
            Menu();

        }

        public static void Menu()
        {
            Console.WriteLine("1. Register New Customer");
            Console.WriteLine("2. Add Vehicle");
            Console.WriteLine("3. Book Service Appointment");
            Console.WriteLine("4. Record Completed Service");
            Console.WriteLine("5. View Vehicle Service History");
            Console.WriteLine("6. View All Bookings");
            Console.WriteLine("7. Exit");
            Console.WriteLine("\nSelect an option (1-7): ");
        }

        public static void Greeting()
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("Al-Nahda Auto Garage - Servisce System");
            Console.WriteLine("=======================================================");
        }
    }
}
