using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class Guest
    {
        public Guest()
        {
            BookingRooms = new List<BookingRoom>();
        }

        public int GuestId { get; set; }
        public string GuestTitle { get; set; }
        public string GuestForeNames { get; set; }
        public string GuestSurNames { get; set; }
        public DateTime? GuestDOB { get; set; }
        public string GuestStreetAddress { get; set; }
        public string GuestAddressTown { get; set; }
        public string GuestAddressCountry { get; set; }
        public string GuestAddressPostalCode { get; set; }
        public string GuestContactPhone { get; set; }

        public ICollection<BookingRoom> BookingRooms { get; set; }

 
    }
}
