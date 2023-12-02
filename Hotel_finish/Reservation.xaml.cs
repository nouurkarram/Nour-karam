using Microsoft.Win32;
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
    /// Interaction logic for Reservation.xaml
    /// </summary>
    public partial class Reservation : Page
    {
        hotelfinishEntities db=new hotelfinishEntities();
        public Reservation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                Reservation res= new Reservation();
                res.user_name=resnametxt.Text;
                res.checkindate=Convert.ToDateTime(checkindatetxt.Text);
                res.ckeckoutdate=Convert.ToDateTime(resoutdatetxt.Text);
                res.roomnumber = resroomnumtxt.Text;
                res.roomtype=resroomtypetxt_Copy.Text;
                db.Reservations.Add(res);
                db.SaveChanges();
                MessageBox.Show("added successfully");



            }
        
               
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
     
          




        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            dgres.ItemsSource=db.Reservations.ToList();
        }
    }
}
