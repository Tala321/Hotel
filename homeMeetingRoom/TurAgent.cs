using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementApp
{
    class TurAgent
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int Id { get; set; }

        public static List<TurAgent> TurAgentStatus = new List<TurAgent>();
      


        public TurAgent(string _name, string _surname,int _id)
        {
            this.name = _name;
            this.surname = _surname;
            this.Id = _id;

            TurAgentStatus.Add(this);
          
        }
    }
}
