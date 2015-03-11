using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class HotelReservationDataContext : DbContext
    {
        public HotelReservationDataContext()
            : base("HotelReservationDataContext")
        { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Changing Database table name to Metadata
            modelBuilder.Entity<Customer>()
                .ToTable("tblCustomers");

            modelBuilder.Entity<Booking>()
               .ToTable("tblBookings");
        }
    }
}
