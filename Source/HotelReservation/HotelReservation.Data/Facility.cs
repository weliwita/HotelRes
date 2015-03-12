using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class Facility
    {
        public Facility()
        {
            _rooms = new List<Room>();
        }

        public int FacilityID { get; set; }
        public string FacilityDesc { get; set; }

        private ICollection<Room> _rooms;

        public ICollection<Room> Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }
        
    }
}
