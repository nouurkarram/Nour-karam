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
    /// Interaction logic for signinemp.xaml
    /// </summary>
    public partial class signinemp : Page
    {
        public signinemp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sempeidtxt != null && sempnametxt != null && semppositiontxt_Copy.Text != null) ;
            ManageRoom room = new ManageRoom();
            this.NavigationService.Navigate(room);
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (sempeidtxt != null && sempnametxt != null && semppositiontxt_Copy.Text != null) ;
            manageguest guest=new manageguest();
            this.NavigationService.Navigate(guest);
        }
    }
}
