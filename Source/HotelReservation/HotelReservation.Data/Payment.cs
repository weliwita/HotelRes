using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class Payment
    {
        public Payment()
        {
            _booking = new Booking();
        }
        public int PaymentID { get; set; }
        public int BookingID { get; set; }
        public int PaymentMethodID { get; set; }
        public double PaymentAmount { get; set; }
        public string PaymentComments { get; set; }

        private Booking _booking;

        public Booking Booking
        {
            get { return _booking; }
            set { _booking = value; }
        }

        private PaymentMethod _paymentMethod;

        public PaymentMethod PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }

        
    }
}
