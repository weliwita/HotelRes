using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class BookingRoom
    {
        public BookingRoom()
        {

        }

        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public int GuestId { get; set; }

        public virtual Booking Booking { get; set; }
        public virtual Room Room { get; set; }
        public virtual Guest Guest { get; set; }

    }
}
