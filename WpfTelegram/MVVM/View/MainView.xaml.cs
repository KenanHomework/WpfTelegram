using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfTelegram.Data;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using WpfTelegram.Models;
using WpfTelegram.Services;
using System.Windows.Shapes;
using WpfTelegram.MVVM.ViewModel;
using WpfTelegram.Pages;

namespace WpfTelegram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            DataContext = mainVM;
            ChatPage.Window = this;
            MainVM.Get();
        }

        public MainVM mainVM = new();

        private void ResizeButton_Click(object sender, RoutedEventArgs e)
        {


            if (sender is Button btn)
            {
                switch (btn.Content.ToString())
                {
                    case "_":
                        Application.Current.MainWindow.WindowState = WindowState.Minimized;
                        break;
                    case "❒":
                        if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                            Application.Current.MainWindow.WindowState = WindowState.Normal;
                        else
                            Application.Current.MainWindow.WindowState = WindowState.Maximized;
                        break;
                    case "X":
                        MainVM.Save();
                        Application.Current.Shutdown();
                        break;
                    default:
                        break;
                }
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void FooterMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var uri = "https://github.com/KenanHomework/WpfTelegram.git";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void MenuItemContacts_Click(object sender, RoutedEventArgs e)
        {
            var page_ = new ContactsPage(this);
            //page_.DataContext = ;
            Frame.Navigate(page_);
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChatPage.DataContext = (Contact)List.SelectedItem;
            ChatPage.List.ScrollIntoView(ChatPage.List.Items[ChatPage.List.Items.Count - 1]);

        }
    }
}
