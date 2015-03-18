using HotelReservation.Business;
using HotelReservation.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {

        HotelReservationDataContext context = new HotelReservationDataContext();

        public ObservableCollection<BookingDetail> BookingDetails = new ObservableCollection<BookingDetail>();

        public Booking()
        {
            InitializeComponent();
            BindComboBox();
            
        }

        private void BindComboBox()
        {
            combo_roomtype.ItemsSource = context.RoomTypes.ToList();
            combo_roomtype.DisplayMemberPath = "RoomTypeDesc";

            combo_band.ItemsSource = context.RoomBands.ToList();
            combo_band.DisplayMemberPath = "RoomBandDesc";

            combo_Rooms.ItemsSource = new List<int> { 1, 2, 3, 4, 5 };
            //combo_roomtype.SelectedValuePath = ; 

            datagrid_bookingDetails.ItemsSource = BookingDetails;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReservationService service = new ReservationService();
            var rooms = service.GetAvailableRooms(datePicker_checkin.SelectedDate, datePicker_checkout.SelectedDate);
            datagrid_availableRooms.ItemsSource = rooms;
            //this.Hide();
            //new Customer().Show();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {

            BookingDetail bd = new BookingDetail();
            bd.RoomType = combo_roomtype.SelectedItem as RoomType;
            bd.RoomBand = combo_band.SelectedItem as RoomBand;
            bd.NoOfRooms = (int)combo_Rooms.SelectedItem;

            BookingDetails.Add(bd);

            

        }

        private void btn_Reserve_Click(object sender, RoutedEventArgs e)
        {
            ReservationService service = new ReservationService();
            Booking booking = new Booking();

            foreach (var detail in BookingDetails)
            {
                for(int i=0;i<detail.NoOfRooms;i++){
                    service.ReserveNextAvailable();
                }
                
            }
        }

       
    }
}
