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
            Rooms = new List<Room>();
        }
        public int RoomTypeID { get; set; }
        public string RoomTypeDesc { get; set; }
       
        public virtual ICollection<Room> Rooms
        {
            get;
            set;
        }
    }
}
