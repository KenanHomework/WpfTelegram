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
using WpfTelegram.MVVM.View;

namespace WpfTelegram.Pages
{
    /// <summary>
    /// Interaction logic for ContactsPage.xaml
    /// </summary>
    public partial class ContactsPage : Page
    {
        public ContactsPage(MainWindow _source)
        {
            InitializeComponent();
            DataContext = _source;
            source = _source;
            List.ItemsSource = source.mainVM.AllContacts;
            source.LeftBar.Visibility = Visibility.Collapsed;
            source.EditButton.Visibility = Visibility.Collapsed;
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            //var addUser = new AddUserPage(this);
            //Frame.Navigate(addUser);
            AddUserView addUserView = new ();
            addUserView.Show();
        }

        public MainWindow source = new();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            source.LeftBar.Visibility = Visibility.Visible;
            source.EditButton.Visibility = Visibility.Visible;
            Visibility = Visibility.Collapsed;
        }
    }
}
