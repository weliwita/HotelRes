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
            _rooms = new List<Room>();
        }
        public int RoomPriceID { get; set; }
        public double RoomValue { get; set; }

        private List<Room> _rooms;

        public virtual List<Room> Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }
    }
}
