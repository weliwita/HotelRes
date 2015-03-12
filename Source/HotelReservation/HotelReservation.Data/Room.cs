using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservation.Data
{
    public class Room
    {
        public Room()
        {
            _roomType = new RoomType();
            _roomBand = new RoomBand();
            _roomPrice = new RoomPrice();
            _facilitiesList = new List<Facility>();

            _bookings = new List<BookingRoom>();
        }

        public int RoomID { get; set; }
        public int RoomTypeID { get; set; }
        public int RoomBandID { get; set; }
        public int RoomPriceID { get; set; }
        public string Floor { get; set; }
        public string AdditionalNotes { get; set; }

        private RoomType _roomType;

        public virtual RoomType RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }

        private RoomBand _roomBand;

        public virtual RoomBand RoomBand
        {
            get { return _roomBand; }
            set { _roomBand = value; }
        }


        private RoomPrice _roomPrice;

        public virtual RoomPrice RoomPrice
        {
            get { return _roomPrice; }
            set { _roomPrice = value; }
        }
        

        private ICollection<Facility> _facilitiesList;

        public virtual ICollection<Facility> FacilitiesList
        {
            get { return _facilitiesList; }
            set { _facilitiesList = value; }
        }

        private ICollection<BookingRoom> _bookings;

        public ICollection<BookingRoom> Bookings
        {
            get { return _bookings; }
            set { _bookings = value; }
        }
        
        
    }
}
