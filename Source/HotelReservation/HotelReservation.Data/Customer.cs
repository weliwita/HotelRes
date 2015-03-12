using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class Customer
    {
        private ICollection<Booking> _bookings;

        public Customer()
        {
            _bookings = new List<Booking>();
        }

        public int CustomerId { get; set; }
        public string CustomerTitle { get; set; }
        public string CustomerForenames { get; set; }
        public string CustomerSurnames { get; set; }
        public DateTime CustomerDOB { get; set; }
        public string CustomerAddressStreet { get; set; }
        public string CustomerAddressTown { get; set; }
        public string CustomerAddressCountry { get; set; }
        public string CustomerAddressPostalCode { get; set; }
        public string CustomerHomePhone { get; set; }
        public string CustomerWorkPhone { get; set; }
        public string CustomerMobilePhone { get; set; }
        public string CustomerEmail { get; set; }

        public virtual ICollection<Booking> Bookings
        {
            get { return _bookings; }
            set { _bookings = value; }
        }
        
       
    }
}
