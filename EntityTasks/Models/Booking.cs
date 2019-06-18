using System;
using System.Collections.Generic;
using System.Text;

namespace EntityTasks.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int HotelRoomId { get; set; }
        public DateTime BookingStartDay { get; set; }
        public DateTime BookingEndDay { get; set; }
    }
}
