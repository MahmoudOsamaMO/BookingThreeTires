using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.DAL
{
    public class RoomBooking
    {
        public int BookingID { get; set; }
        public string BookedDateFR { get; set; }
        public string BookedDateTO { get; set; }
        public string BookingStatus { get; set; }
        public string PaymentStatus { get; set; }
        public string AdvancePayed { get; set; }
        public string TotalAmountPayed { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }

    }
}
