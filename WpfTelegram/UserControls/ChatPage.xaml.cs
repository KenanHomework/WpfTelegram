using MaterialDesignThemes.Wpf;
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
using WpfTelegram.Models;
using WpfTelegram.MVVM.ViewModel;

namespace WpfTelegram.UserControls
{
    /// <summary>
    /// Interaction logic for ChatPage.xaml
    /// </summary>
    public partial class ChatPage : System.Windows.Controls.UserControl
    {
        public ChatPage()
        {
            InitializeComponent();
            ToggleButton.delegateOfClick += ToggleButton_Click;
        }

        private void MenuItemDeleteChat_Click(object sender, RoutedEventArgs e)
        {
            ;
            if (MessageBoxResult.Cancel == MessageBox.Show("Item will be removed. Do you want to continue?", "Delete Chat", MessageBoxButton.OKCancel, MessageBoxImage.Warning, MessageBoxResult.Cancel))
                return;
            MainVM.Chats.Remove((Contact)DataContext);
        }

        public MainWindow Window { get; set; }

        private void MessageWriteBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (MessageWriteBox.Text.Length == 0)
                ToggleButton.Icon.Kind = PackIconKind.Microphone;
            else
                ToggleButton.Icon.Kind = PackIconKind.Send;
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (ToggleButton.Icon.Kind == PackIconKind.Send)
            {
                MainVM.AddMessage((Contact)DataContext, new Message(MessageWriteBox.Text, DateTime.Now, true));
                int temp = Window.List.SelectedIndex;
                Window.List.ItemsSource = null;
                Window.List.ItemsSource = MainVM.Chats;
                Window.List.SelectedIndex = temp;
                List.ScrollIntoView(List.Items[List.Items.Count - 1]);
                MessageWriteBox.Text = String.Empty;
            }
        }
    }
}
