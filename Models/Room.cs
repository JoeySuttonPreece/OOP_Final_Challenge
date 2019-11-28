using System;
using System.Collections.Generic;

namespace OOP_Final_Challenge
{
    public partial class Room
    {
        public Room()
        {
            Class = new HashSet<Class>();
            Computer = new HashSet<Computer>();
        }

        public string Building { get; set; }
        public int RoomNo { get; set; }
        public int Capacity { get; set; }

        public ICollection<Class> Class { get; set; }
        public ICollection<Computer> Computer { get; set; }
    }
}
