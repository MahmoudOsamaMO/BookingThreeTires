using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL
{
    public class Hotel
    {
        public Hotel()
        {
            Rooms = new HashSet<Room>();

        }
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelLocation { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }

    }
}
