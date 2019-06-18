using System;
using System.Collections.Generic;
using System.Text;

namespace EntityTasks.Models
{
    public class HotelRoom
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int RoomNumber { get; set; }
        public int Price { get; set; }
        public int ComfortLvl { get; set; }
        public int Capability { get; set; }
    }
}
