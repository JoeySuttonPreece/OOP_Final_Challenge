using System;
using System.Collections.Generic;

namespace OOP_Final_Challenge
{
    public partial class Class
    {
        public string ClassCode { get; set; }
        public string Name { get; set; }
        public string Building { get; set; }
        public int? RoomNo { get; set; }

        public Room Room { get; set; }
    }
}
