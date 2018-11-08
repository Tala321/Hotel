using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    class Controller
    {
        public static void CheckCategory()
        {
            Console.WriteLine("Welcome ,Please tell us who you are ");
            Console.WriteLine("[Customer] [Touragent] [Manager] ");
            switch (FutherAction())
            {
                case ("Customer"):
                    break;
                case ("Touragent"):
                    Console.Write("Your name: ");
                    string name = Console.ReadLine();
                    Console.Write("Your surname: ");
                    string surname = Console.ReadLine();
                    Console.Write("Your Id: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var agent = new TurAgent(name, surname,id);
                    Console.WriteLine("Choose action :");
                    Console.WriteLine("[Unreserved rooms]  [Reserve a room]");
                    string action = Console.ReadLine();

                    switch (action)
                    {
                        case ("Unreserved rooms"):
                            TourAgentFunc.ShowUnreservedRooms();
                            Console.WriteLine();
                            Console.WriteLine("press any key to come back to the main menu");
                            dynamic DontUseble = Console.ReadLine();
                            CheckCategory();

                            break;
                        case ("Reserve a room"):
                            Console.WriteLine("Select a room");
                            TourAgentFunc.BookRoom();
                            action = Console.ReadLine();
                            Console.Write("Customer Name: ");
                            name = Console.ReadLine();
                            Console.Write("Customer Name: ");
                            surname = Console.ReadLine();
                            var Customer = new Customer(name, surname, action,id);
                            Manager.Show();
                            break;                       
                    }
                    break;
                case ("Manager"):
                    break;

                default:
                    Console.WriteLine("Please, select an option from the provided");
                    CheckCategory();
                    break;
            }
        }

        public static string FutherAction()
        {
            string category = Console.ReadLine();
            return category;
        }
    }
}
