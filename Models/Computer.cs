using System;
using System.Collections.Generic;

namespace OOP_Final_Challenge
{
    public partial class Computer
    {
        public int Number { get; set; }
        public int? AssembledYear { get; set; }
        public string Building { get; set; }
        public int RoomNo { get; set; }

        public Room Room { get; set; }
    }
}
