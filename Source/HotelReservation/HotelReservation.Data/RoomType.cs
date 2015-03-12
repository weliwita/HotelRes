using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservation.Data
{
    public class RoomType
    {
        public RoomType()
        {
            _rooms = new List<Room>();
        }
        public int RoomTypeID { get; set; }
        public string RoomTypeDesc { get; set; }

        private List<Room> _rooms;

        public virtual List<Room> Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }
    }
}
