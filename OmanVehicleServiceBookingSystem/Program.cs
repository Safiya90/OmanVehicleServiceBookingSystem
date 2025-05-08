using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace OmanVehicleServiceBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greeting();
            Menu();
            string option = Console.ReadLine();

            switch(option)
            {

                case "1":
                    Console.WriteLine("---Register New Customer===");
                    Console.Write("Enter Customer Name: ");
                    String name = Console.ReadLine();
                    Console.Write("Enter Phone Number: ");
                    int phone = int.Parse(Console.ReadLine());
                    Customer customer = new Customer(name, phone);
                    // Call the method to register a new customer
                    Console.WriteLine($"Customer registered successfully with ID: {customer.Id}");
                    break;

            }


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
