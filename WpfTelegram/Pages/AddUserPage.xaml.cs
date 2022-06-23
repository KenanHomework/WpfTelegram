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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfTelegram.Data;
using WpfTelegram.Models;
using WpfTelegram.Pages;

namespace WpfTelegram
{
    /// <summary>
    /// Interaction logic for AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        public AddUserPage()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Collapsed;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DataGeneral.AllContacts.Add(new(FirstName.Text + LastName.Text, Phone.Text));
            Visibility = Visibility.Collapsed;
        }
    }
}
