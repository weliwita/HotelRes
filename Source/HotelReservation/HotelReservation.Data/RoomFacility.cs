using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class RoomFacility
    {
        public int RoomId { get; set; }
        public int FacilityId { get; set; }
        public string FacilityDetails { get; set; }

        public virtual Room Room { get; set; }
        public virtual Facility Facility { get; set; }

    }
}
