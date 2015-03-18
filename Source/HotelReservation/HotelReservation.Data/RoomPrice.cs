using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservation.Data
{
    public class RoomPrice
    {
        public RoomPrice()
        {
            Rooms = new List<Room>();
        }
        public int RoomPriceID { get; set; }
        public double RoomPriceValue { get; set; }

        public virtual ICollection<Room> Rooms
        {
            get;
            set;
        }
    }
}
