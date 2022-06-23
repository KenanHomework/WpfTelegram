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
using WpfTelegram.Data;
using WpfTelegram.Models;

namespace WpfTelegram.Pages
{
    /// <summary>
    /// Interaction logic for ContactsPage.xaml
    /// </summary>
    public partial class ContactsPage : Page
    {
        public ContactsPage()
        {
            InitializeComponent();
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            var addUser = new AddUserPage();
            Frame.Navigate(addUser);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
        }
    }
}
