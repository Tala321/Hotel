using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    class Manager
    {
        public static void Show()
        {
            foreach (var item in Customer.customers)
            {
                Console.WriteLine($"Customer name : {item.name}, Customer Surname:{item.surname},Customer room : {item.roomNumber}, Customer's guide :{item.tourguide.name}");
            }
        }
    }
}
