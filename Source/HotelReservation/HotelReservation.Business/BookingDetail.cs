using HotelReservation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Business
{
    public class BookingDetail
    {
        public RoomType RoomType { get; set; }
        public RoomBand RoomBand { get; set; }
        public int NoOfRooms { get; set; }
    }
}
