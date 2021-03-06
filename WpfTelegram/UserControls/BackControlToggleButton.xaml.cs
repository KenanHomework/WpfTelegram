using MaterialDesignThemes.Wpf;
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

namespace WpfTelegram.UserControls
{
    /// <summary>
    /// Interaction logic for BackControlToggleButton.xaml
    /// </summary>
    public partial class BackControlToggleButton : UserControl
    {
        public BackControlToggleButton()
        {
            InitializeComponent();
        }
        public delegate void DelegateOfClick(object sender, RoutedEventArgs e);

        public DelegateOfClick delegateOfClick;

        private void Click(object sender, RoutedEventArgs e)
        {
            delegateOfClick(sender, e);
        }
    }
}
