using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Models.DAL
{
    public class BookingInitializer : CreateDatabaseIfNotExists<BookingContext>
    {
        protected override void Seed(BookingContext context)
        {
            base.Seed(context);
        }
    }
}
