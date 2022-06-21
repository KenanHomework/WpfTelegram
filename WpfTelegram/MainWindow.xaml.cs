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
using WpfTelegram.Models;
using System.Windows.Shapes;

namespace WpfTelegram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public int SizeWindow
        {
            get { return (int)GetValue(SizeWindowProperty); }
            set { SetValue(SizeWindowProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SizeWindow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SizeWindowProperty =
            DependencyProperty.Register("SizeWindow", typeof(int), typeof(MainWindow), new PropertyMetadata(0));


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            SizeWindow = 500;
        }

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
                        Application.Current.Shutdown();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
