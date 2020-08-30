using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int RoomType { get; set; }
        public int  HotelID { get; set; }
        public int? RoomBookingID { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual RoomBooking RoomBooking { get; set; }

    }
}
