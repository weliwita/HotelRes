using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelReservation.Data.Test
{
    [TestClass]
    public class TestBooking
    {
        [TestMethod]
        public void CreateAddCustomerTest()
        {

            HotelReservationDataContext db = new HotelReservationDataContext();
            using (db)
            {
                db.Customers.Add(new Customer() { CustomerTitle = "mr", CustomerForenames = "Rasika", CustomerSurnames = "Weliwita" });
                db.SaveChanges();
            }
            

        }

        [TestMethod]
        public void CreateAddRoomTest()
        {
            HotelReservationDataContext db = new HotelReservationDataContext();
            using (db)
            {
                var type1 = db.RoomTypes.Find(1);
                db.Rooms.Add(new Room() { RoomType = type1, AdditionalNotes = "new room4", Floor = "1", RoomBand = new RoomBand(), RoomPrice = new RoomPrice()});
                db.Rooms.Add(new Room() { RoomType = type1, AdditionalNotes = "new room1", Floor = "1", RoomBand = new RoomBand(), RoomPrice = new RoomPrice() });
                db.Rooms.Add(new Room() { RoomType = type1, AdditionalNotes = "new room2", Floor = "1", RoomBand = new RoomBand(), RoomPrice = new RoomPrice() });
               
                db.SaveChanges();
            }

        }

        [TestMethod]
        public void CreateBookingTest()
        {
            HotelReservationDataContext db = new HotelReservationDataContext();
            using (db)
            {
               
                var customer = db.Customers.Find(1);

                var booking1 = new Booking(){
                    Customer = customer,
                    BookingComments = "myBooking",
                    BookedStartDate = new DateTime(2015,11,01),
                    BookedEndDate = new DateTime(2015,11,02),
                    DateBookingMade = DateTime.Now
                };

                var booking = db.Bookings.Add(booking1);

                var room = db.Rooms.Find(1);
                var room2 = db.Rooms.Find(2);

                //booking.Rooms.Add(room);
                //booking.Rooms.Add(room2);

                var bookinroom1 = new BookingRoom(){Booking = booking, Room = room, Guest = new Guest(){GuestForeNames = "james"}};
                var bookinroom11 = new BookingRoom(){Booking = booking, Room = room, Guest = new Guest(){GuestForeNames = "monica"}};
                var bookinroom2 = new BookingRoom(){Booking = booking, Room = room2, Guest = new Guest(){GuestForeNames = "john"}};


                db.BookingRooms.Add(bookinroom1);
                db.BookingRooms.Add(bookinroom11);
                db.BookingRooms.Add(bookinroom2);

                db.SaveChanges();
            }

        }
    }
}
