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
            
        }
        public int PaymentID { get; set; }
        public int BookingID { get; set; }
        public int PaymentMethodID { get; set; }
        public double PaymentAmount { get; set; }
        public string PaymentComments { get; set; }

        public Booking Booking
        {
            get;
            set;
        }

        public PaymentMethod PaymentMethod
        {
            get;
            set;
        }

        
    }
}
