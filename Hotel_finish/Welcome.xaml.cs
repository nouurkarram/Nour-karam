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
    /// Interaction logic for Welcome.xaml
    /// </summary>
    public partial class Welcome : Page
    {
        hotelfinishEntities db=new hotelfinishEntities();
        public Welcome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string choose=combo.SelectedItem.ToString().Split(' ').Last();
            if (choose == "Employee")
            {
                signinemp empage= new signinemp();
                this.NavigationService.Navigate(empage);

            }
            else if(choose =="Guest")
            {
                signinuser signuserpage= new signinuser();
                this.NavigationService.Navigate(signuserpage);
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            signup regpage=new signup();
            this.NavigationService.Navigate(regpage);
        }
    }
}
