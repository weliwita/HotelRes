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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }


        private void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            if (!usernameTB.Text.Equals("") && !PasswordBoxPB.Password.Equals(""))
            {
                if (usernameTB.Text.Equals("1") && PasswordBoxPB.Password.Equals("1"))
                { 
                    MainWindow objmain = new MainWindow();  
                    objmain.Show(); //after login Redirect to second window  
                    this.Hide();
                }
                else
                    MessageBox.Show("Wrong Password");
            }
            else
                MessageBox.Show("Wrong Info");
        }
    }
}
