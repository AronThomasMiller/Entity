using System;
using System.Collections.Generic;
using System.Text;

namespace EntityTasks.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public int CreationYear { get; set; }
        public string HotelAddress { get; set; }
        public bool IsActive { get; set; }
    }
}
