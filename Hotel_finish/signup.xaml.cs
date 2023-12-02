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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hotel_finish
{
    /// <summary>
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        hotelfinishEntities db=new hotelfinishEntities();
        public signup()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ridtxt.Text != null && rUnametxt.Text != null && rUpassdtxt.Text != null)
            {
                Reservation reservation = new Reservation();
                this.NavigationService.Navigate(reservation);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            loginuser user = new loginuser();
            user.user_name= ridtxt.Text;
            user.user_password = rUpassdtxt.Text;
            user.user_id=int.Parse(ridtxt.Text);
            db.loginusers.Add(user);
            db.SaveChanges();
            MessageBox.Show("save successfuly");
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dgsignup.ItemsSource=db.loginusers.ToList();
        }
    }
}
