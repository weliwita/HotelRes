using HotelReservation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HotelReservationUI
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : Window
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var cust = new HotelReservation.Data.Customer()
            {
                CustomerTitle = cust_title_txt.Text,
                CustomerAddressCountry = cust_country_txt.Text,
                CustomerAddressPostalCode = cust_postalcode_txt.Text,
                CustomerAddressStreet = cust_street_txt.Text,
                CustomerAddressTown = cust_address_town_txt.Text,
                CustomerEmail = cust_email_txt.Text,
                CustomerForenames = cust_forenames_txt.Text,
                CustomerHomePhone = cust_home_phone_txt.Text,
                CustomerMobilePhone = cust_mobile_phone_txt.Text,
                CustomerSurnames = cust_surname_txt.Text,
                CustomerWorkPhone = cust_workphone_txt.Text
            };
            HotelReservationDataContext db = new HotelReservationDataContext();
            using (db)
            {
                db.Customers.Add(cust);
                db.SaveChanges();
            }

            MessageBox.Show("Customer Added");
        }
  
    }
}
