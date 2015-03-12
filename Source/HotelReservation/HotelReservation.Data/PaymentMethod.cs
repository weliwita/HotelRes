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
            _payments = new List<Payment>();
        }
        public int PaymentMethodId { get; set; }
        public string PaymentMethodDetail { get; set; }

        private ICollection<Payment> _payments;

        public ICollection<Payment> Payments
        {
            get { return _payments; }
            set { _payments = value; }
        }

    }
}
