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
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomPrice> RoomPrices { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<BookingRoom> BookingRooms { get; set; }
        public DbSet<Login> LogIns { get; set; }
        public DbSet<RoomBand> RoomBands { get; set; }
        public DbSet<RoomFacility> RoomFacilities { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Changing Database table name to Metadata
            modelBuilder.Entity<Customer>()
                .ToTable("tblCustomers");

            modelBuilder.Entity<Booking>()
               .ToTable("tblBookings");

            modelBuilder.Entity<Facility>()
               .ToTable("tblFacilitiesList");

            modelBuilder.Entity<Room>()
               .ToTable("tblRooms");

            modelBuilder.Entity<RoomType>()
                .ToTable("tblRoomTypes");

            modelBuilder.Entity<RoomBand>()
               .ToTable("tblRoomBands");

            modelBuilder.Entity<RoomPrice>()
                .ToTable("tblRoomPrices");

            modelBuilder.Entity<Guest>()
              .ToTable("tblGuests");

            modelBuilder.Entity<Payment>()
                .ToTable("tblPayments");

            modelBuilder.Entity<PaymentMethod>()
              .ToTable("tblPaymentMethods");

            modelBuilder.Entity<RoomFacility>()
             .ToTable("tblLINK_RoomsFacilities");

            modelBuilder.Entity<BookingRoom>()
             .ToTable("tblLINK_BookingsRooms");

            modelBuilder.Entity<Login>()
             .ToTable("tblLogIns");

            //configure compositekey
            modelBuilder.Entity<BookingRoom>().HasKey(t => new { t.BookingId, t.RoomId, t.GuestId });
            modelBuilder.Entity<RoomFacility>().HasKey(t => new { t.RoomId, t.FacilityId });
        
        }
    }
}
