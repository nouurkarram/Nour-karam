using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Interaction logic for signinuser.xaml
    /// </summary>
    public partial class signinuser : Page
    {
        hotelfinishEntities db=new hotelfinishEntities();
        public signinuser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(Uidtxt.Text);
            if (Uidtxt.Text!=null && Unametxt.Text != null && Upassdtxt.Text != null)
            {
                

                loginuser user = new loginuser();
               
                user = db.loginusers.First(x => x.user_id == id && x.user_name == Unametxt.Text && x.user_password == Upassdtxt.Text);
                Reservation reservationpage = new Reservation();
                this.NavigationService.Navigate(reservationpage);

            }
           
            else if ((id .Equals (null) || Unametxt.Text == null || Upassdtxt.Text == null))
           {
                MessageBox.Show("enter all data");
            }
        
            


        }
       

    }
}
