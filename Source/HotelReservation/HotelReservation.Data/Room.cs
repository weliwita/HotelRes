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
            Bookings = new List<Booking>();
        }

        public int RoomID { get; set; }
        public int RoomTypeID { get; set; }
        public int RoomBandId { get; set; }
        public int RoomPriceID { get; set; }

        public string Floor { get; set; }
        public string AdditionalNotes { get; set; }

        public virtual RoomPrice RoomPrice
        {
            get;
            set;
        }

        public virtual RoomType RoomType
        {
            get;
            set;
        }

        public virtual RoomBand RoomBand
        {
            get;
            set;
        }

        public ICollection<Booking> Bookings
        {
            get;
            set;
        }

        public ICollection<Facility> Facilities
        {
            get;
            set;
        }
        
        
    }
}
