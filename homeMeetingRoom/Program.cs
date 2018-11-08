using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //var agent = new TurAgent("Aslan", "Alsanov");
            //var agent1 = new TurAgent("Rehim", "Rehimov");
            //var agent2 = new TurAgent("Elgun", "Elgunov");


            //var person = new Customer("Amir","Adilov","Room5", "Aslan");
            //var person1 = new Customer("Kife", "Jalilov", "Room8", "Elgun");
            //var person2 = new Customer("Malik", "Qasali", "Room2", "Rehim");
            //var person3 = new Customer("Selim", "Oruclu", "Room9", "Elgun");



            //Manager.Show();

            //    int count = 0;
            //    foreach (var item in Customer.customers)
            //    {

            //        if (item.tourguide.name== "Elgun")
            //        {
            //            count++;
            //            Console.WriteLine($"Customer name : {item.name}, Customer Surname:{item.surname},Customer room : {item.roomNumber}, Customer's guide :{item.tourguide.name} ");

            //        }

            //    }
            //    Console.WriteLine("Elgun "+count + "-dene musteri getirib");


            Controller.CheckCategory();// TourAgentFunc.BookRoom();
        }
    }
}
