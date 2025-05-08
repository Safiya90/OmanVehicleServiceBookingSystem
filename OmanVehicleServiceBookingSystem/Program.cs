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
           int index = 0;
           Customer[] customers = new Customer[10];
            Vehicle[] vehicles = new Vehicle[10];
            //int
            string option = Console.ReadLine();
            bool run = true;
            while (run)
            {
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
                        Console.WriteLine("---Add Vehicle===");
                        Console.Write("Enter Customer ID: ");
                        string Id = Console.ReadLine();
                        for (int i = 0; i < index; i++)
                        {
                            if ((customers[i]).Id == Id)
                            {
                                Console.Write("Enter plate Number: ");
                                string plat_number = Console.ReadLine();
                                Console.Write("Enter Vehicle type: ");
                                string type = (Console.ReadLine());
                                Console.Write("Enter Model: ");
                                string model = (Console.ReadLine());
                                Vehicle vehicle = new Vehicle(customers[i], plat_number, model, type);
                                vehicles[index] = vehicle;
                                Console.WriteLine(" Vehicle added sucessfully");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Customer not found");
                            }
                        }
                        break;

                }
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
