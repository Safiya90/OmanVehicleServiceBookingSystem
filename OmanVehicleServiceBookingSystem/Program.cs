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
                                vehicles[indexVehicle] = vehicle;
                                Console.WriteLine(" Vehicle added sucessfully");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Customer not found");
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("---Book Service Appointment---");
                        Console.Write("Enter Plate Number: ");
                        string plateNumber = Console.ReadLine();
                        for (int i = 0; i < indexVehicle; i++)
                        {
                            if ((vehicles[i]).Platenumber == plateNumber)
                            {
                                Console.Write("Enter Preffered Date: ");
                                DateTime date = Convert.ToDateTime(Console.ReadLine());
                                Console.Write("Enter Preffered Time: ");
                                DateTime time = Convert.ToDateTime(Console.ReadLine()); 
                                Appointement appointement=new Appointement(vehicles[i], date, time);
                                appointements[indexAppointement] = appointement;
                                Console.WriteLine(" Service appointment booked successfully!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Plate Number not found");
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("---Record Complete Service---");
                        Console.Write("Enter Plate Numper: ");
                        string plateNumber1 = Console.ReadLine();
                        Console.Write("Enter Preffered Date: ");
                        DateTime date1 = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Enter Issues Found: ");
                        string issues = Console.ReadLine();
                        Console.Write("Enter Parts Replaced: ");
                        string partReplaced = Console.ReadLine();
                        Console.Write("Enter Service Coast: ");
                        double cost = Convert.ToDouble(Console.ReadLine());
                        ///create object
                        Console.WriteLine("Service record saved.");
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
