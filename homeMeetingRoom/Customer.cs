using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{


    class Customer
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string roomNumber { get; set; }
        public static List<Customer> customers = new List<Customer>();
        public TurAgent tourguide;

        public Customer(string _name, string _surname, string _room,int _id)
        {
            this.name = _name;
            this.surname = _surname;
            this.roomNumber = _room;

            foreach (var item in TurAgent.TurAgentStatus)
            {
                if (item.Id == _id)
                {
                    this.tourguide = item;
                }
            }
            customers.Add(this);
        }
    }
}
