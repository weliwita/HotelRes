using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class BookingRoom
    {
        public int BookingRoomId { get; set; }
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public int GuestId { get; set; }

    }
}
