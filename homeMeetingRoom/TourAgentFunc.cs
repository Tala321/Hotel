using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    class TourAgentFunc
    {
        public static void ShowUnreservedRooms()
        {
            for (var i = 0; i < Hotel.HotelRooms.Length; i++)
            {
                Console.Write(Hotel.HotelRooms[i] + " ");
            }
        }

        public static void BookRoom()
        {
            for (int i = 0; i < Hotel.HotelRooms.Length; i++)
            {
               
                    if (Hotel.HotelRooms[i] == null)
                    {
                        Console.Write(Hotel.HotelRooms[i]);
                   }
                
            }
        }

        //public void AddCustomerInfo(string _string)
        //{

        //}
    }
}
