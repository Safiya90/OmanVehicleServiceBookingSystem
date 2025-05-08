using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection;

namespace OmanVehicleServiceBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greeting();
            Customer[] customers = new Customer[10];
           int index = 0;
           Vehicle[] vehicles = new Vehicle[10];
           int indexVehicle = 0;
            Appointement[] appointements= new Appointement[10];
            int indexAppointement = 0;
            bool run = true;
            while (run)
            {
                Menu();
                string option = Console.ReadLine();

                switch (option)
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
                case "2":
                    
                case "3":
                    Console.WriteLine("---Book Service Appointment---");
                    Console.Write("Enter Plate Numper: ");
                    string plateNumber = Console.ReadLine();
                    Console.Write("Enter Preffered Date: ");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Enter Preffered Time: ");
                    DateTime time = Convert.ToDateTime(Console.ReadLine());
                    Vehicle v = new Vehicle($"{plateNumber}");
                    Appointement appoint = new Appointement(date, time);
                    Console.WriteLine("Service appointment booked successfully.");
                    break;
                case "4":
                    Console.WriteLine("---Record Complete Service---");
                    break;
                case "5":
                    Console.WriteLine("---View Vehicle Service History---");
                    break;
                case "6":
                    Console.WriteLine("---All Upcoming Service Booking---");
                    //if (service == 0)
                    //{
                    //    Console.WriteLine("No students to display.");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Students and Grades");
                    //    for (int i = 0; i < studentCount; i++)
                    //    {
                    //        Console.WriteLine($"{students[i]}: {grades[i]}");
                    //    }
                    //}
                    break;
                case "7":
                    Console.WriteLine("Exiting program");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again");
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
