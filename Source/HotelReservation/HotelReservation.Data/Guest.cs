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
            _room = new BookingRoom();
        }

        public int GuestID { get; set; }
        public string GuestTitle { get; set; }
        public string GuestForeNames { get; set; }
        public string GuestSurNames { get; set; }
        public DateTime GuestDOB { get; set; }
        public string GuestStreetAddress { get; set; }
        public string GuestAddressTown { get; set; }
        public string GuestAddressCountry { get; set; }
        public string GuestAddressPostalCode { get; set; }
        public string GuestContactPhone { get; set; }

        public int BookingID { get; set; }
        public int RoomID { get; set; }

        private BookingRoom _room;

        public BookingRoom Room
        {
            get { return _room; }
            set { _room = value; }
        }
        
    }
}
