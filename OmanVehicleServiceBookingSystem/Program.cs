using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection;

namespace OmanVehicleServiceBookingSystem
{
    internal class Program
    {

        static List<Customer> customerList = new List<Customer>();
        static List<Vehicle> vehicleList = new List<Vehicle>();
        static List<Appointement> appointementList = new List<Appointement>();
        static List<Service> serviceList = new List<Service>();
        static void Main(string[] args)
        {
            Greeting();

            bool run = true;
            while (run)
            {
                Menu();
                string option = Console.ReadLine();

                switch (option)
                {

                case "1":
                    Console.WriteLine("---Register New Customer---");
                    Console.Write("Enter Customer Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Phone Number: ");
                    int phone = int.Parse(Console.ReadLine());
                    string id = $"C{customerList.Count + 1:000}";
                    customerList.Add(new Customer{ Id=id , Username = name, Phonenumber = phone});
                    Console.WriteLine($"Customer registered successfully with ID: {id}");
                    break;

                case "2":
                    Console.WriteLine("---Add Vehicle---");
                    Console.Write("Enter Customer ID: ");
                    string Id = Console.ReadLine();
                    Customer customer = null;
                    foreach (Customer c in customerList)
                    {
                        if (c.Id == Id)
                        {
                            customer = c;
                            break;
                        }
                    }
                    if (customer == null)
                    {
                        Console.WriteLine("Customer not found");
                        break;
                    }
                    Console.Write("Enter plate Number: ");
                    string plat_number = Console.ReadLine();
                    if (PlateNumberExists(plat_number))
                    {
                        Console.WriteLine("Plate number already exists. Cannot add duplicate.");
                        break;
                    }
                    Console.Write("Enter Vehicle type: ");
                    string type = (Console.ReadLine());
                    Console.Write("Enter Model: ");
                    string model = (Console.ReadLine());
                    vehicleList.Add(new Vehicle { customerID = Id, Platenumber = plat_number, Model = model, Type = type });
                    Console.WriteLine(" Vehicle added sucessfully");
                    break;

                case "3":
                    Console.WriteLine("---Book Service Appointment---");
                    Console.Write("Enter Plate Number: ");
                    string plateNumber = Console.ReadLine();
                    if (!PlateNumberExists(plateNumber))
                    {
                        Console.WriteLine("Plate number not found.");
                        break;
                    }
                    Console.Write("Enter Preffered Date: ");
                    DateTime date = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Enter Preffered Time: ");
                    TimeSpan time = TimeSpan.Parse(Console.ReadLine());
                    foreach(Appointement appointement in appointementList)
                    {
                        if(appointement.Date == date && appointement.Time == time)
                        {
                            Console.WriteLine("Full.. Choose another time");
                            break;
                        }
                    }
                    appointementList.Add(new Appointement { PlateNumber = plateNumber, Date = date, Time = time });
                    Console.WriteLine("Service pponintment bookes successfully.");
                    break;
                case "4":
                    Console.WriteLine("---Record Complete Service---");
                    Console.Write("Enter Plate Numper: ");
                    string plateNumber1 = Console.ReadLine();
                    if (!PlateNumberExists(plateNumber1))
                    {
                        Console.WriteLine("Plate number not found.");
                        break;
                    }
                    Console.Write("Enter Preffered Date: ");
                    DateTime date1 = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Enter Issues Found: ");
                    string issues = Console.ReadLine();
                    Console.Write("Enter Parts Replaced: ");
                    string partReplaced = Console.ReadLine();
                    Console.Write("Enter Service Coast: ");
                    double cost = Convert.ToDouble(Console.ReadLine());
                        serviceList.Add(new Service { PlateNumber = plateNumber1 ,Issue = issues, 
                            PartReplaced = partReplaced, Date = date1, Cost = cost });
                    Console.WriteLine("Service record saved.");
                    break;
                case "5":
                    Console.WriteLine("---View Vehicle Service History---");
                    Console.Write("Enter Plate Numper: ");
                    string plateNumber2 = Console.ReadLine();

                    if (!PlateNumberExists(plateNumber2))
                    {
                        Console.WriteLine("Plate number not found.");
                        break;
                    }
                    foreach (Service service in serviceList)
                    {
                        if (service.PlateNumber == plateNumber2)
                        {
                            Console.WriteLine($"Servise history for vehicle {service.PlateNumber}" +
                                $"\nDate: {service.Date:dd/MM/yyyy}" +
                                $"\nIssues: {service.Issue}" +
                                $"\nParts replaced: {service.PartReplaced}" +
                                $"\nCost: {service.Cost}");
                        }
                    }
                    break;
                case "6":
                    Console.WriteLine("---All Upcoming Service Booking---");
                    foreach(Appointement appoint in appointementList)
                    {
                        Vehicle foundVehicle = null;
                        foreach (Vehicle v in vehicleList)
                        {
                            if (v.Platenumber.Equals(appoint.PlateNumber, StringComparison.OrdinalIgnoreCase))
                            {
                                foundVehicle = v;
                                break;
                            }
                        }
                        string customerName = "Unknown";
                        if (foundVehicle != null)
                        {
                            foreach (Customer c in customerList)
                            {
                                if (c.Id == foundVehicle.customerID)
                                {
                                    customerName = c.Username;
                                    break;
                                }
                            }
                        }
                         Console.WriteLine($"{appoint.PlateNumber} | {customerName} | {appoint.Date:dd/MM/yyyy} | {appoint.Time} ");
                    }
 
                    break;
                case "7":
                    Console.WriteLine("Exiting program");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again");
                    run = false;
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

        public static bool PlateNumberExists(string plateNumber)
        {
            foreach (Vehicle vehicle in vehicleList)
            {
                if (vehicle.Platenumber.Equals(plateNumber, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
