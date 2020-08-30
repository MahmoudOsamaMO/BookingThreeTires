using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Booking.Models.DAL
{
    public class BookingContext : DbContext
    {
        public BookingContext() : base("BookingConnectionString")
        {
            Database.SetInitializer<BookingContext>(new CreateDatabaseIfNotExists<BookingContext>());

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomBooking> RoomBookings { get; set; }
    }
}
