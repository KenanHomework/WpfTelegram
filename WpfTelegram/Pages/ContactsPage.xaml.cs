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
            AddUserView addUserView = new();
            if (addUserView.ShowDialog() == true)
            {
                source.mainVM.AllContacts.Add(addUserView.Source.Contact);
            }
        }

        public MainWindow source = new();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            source.LeftBar.Visibility = Visibility.Visible;
            source.EditButton.Visibility = Visibility.Visible;
            Visibility = Visibility.Collapsed;
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            source.mainVM.Chats.Add((Contact)List.SelectedItem);
            source.List.SelectedItem = List.SelectedItem;
            Button_Click(new(), new());
        }
    }
}
