using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservation.Data
{
    public class RoomBand
    {
        public RoomBand()
        {
            _rooms = new List<Room>();
        }
        public int RoomBandID { get; set; }
        public string BandDesc { get; set; }

        private List<Room> _rooms;

        public virtual List<Room> Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }

    }
}
