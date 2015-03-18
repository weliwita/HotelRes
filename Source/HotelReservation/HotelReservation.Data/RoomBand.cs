using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class RoomBand
    {
        public RoomBand()
        {
            Rooms = new List<Room>();
        }
        public int RoomBandID { get; set; }
        public string RoomBandDesc { get; set; }
       
        public virtual ICollection<Room> Rooms
        {
            get;
            set;
        }
    }
}
