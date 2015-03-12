using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class Booking
    {
        private Customer _customer;

        public Booking()
        {
            _customer = new Customer();
            _rooms = new List<Room>();
        }
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateBookingMade { get; set; }
        public DateTime TimeBookingMade { get; set; }
        public DateTime BookedStartDate { get; set; }
        public DateTime BookedEndDate { get; set; }
        public DateTime TotalPaymentDueDate { get; set; }
        public double TotalPaymentDueAmmount { get; set; }
        public DateTime TotalPaymentMadeOn { get; set; }
        public string BookingComments { get; set; }

        public virtual Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        private ICollection<Room> _rooms;

        public virtual ICollection<Room> Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }
    }
}
