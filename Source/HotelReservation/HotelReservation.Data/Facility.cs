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
             Rooms = new List<Room>();
        }

        public int FacilityID { get; set; }
        public string FacilityDesc { get; set; }


        public ICollection<Room> Rooms
        {
            get;
            set;
        }
        
    }
}
