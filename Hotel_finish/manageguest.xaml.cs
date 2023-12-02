using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for manageguest.xaml
    /// </summary>
    public partial class manageguest : Page
    {
        hotelfinishEntities db=new hotelfinishEntities();
        public manageguest()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(manidtxt.Text);
            loginuser user = db.loginusers.FirstOrDefault(x => x.user_id == id);
            
            user.user_name =mannametxt.Text;
            user.user_password=manpassdtxt.Text;
            db.loginusers.AddOrUpdate(user);
            db.SaveChanges();
            MessageBox.Show("update");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dgmanuser.ItemsSource=db.loginusers.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int id=int.Parse(manidtxt.Text);
            db.loginusers.Remove(db.loginusers.First(x=> x.user_id==id));
            db.SaveChanges();
            MessageBox.Show("Removed");
        }
    }
}
