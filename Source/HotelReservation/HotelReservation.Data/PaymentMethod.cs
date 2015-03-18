using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelReservation.Data
{
    public class PaymentMethod
    {
        public PaymentMethod()
        {
            Payments = new List<Payment>();
        }
        public int PaymentMethodId { get; set; }
        public string PaymentMethodDetail { get; set; }



        public ICollection<Payment> Payments
        {
            get;
            set;
        }

    }
}
