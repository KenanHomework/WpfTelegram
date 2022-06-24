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
using System.Windows.Shapes;
using WpfTelegram.MVVM.ViewModel;

namespace WpfTelegram.MVVM.View
{
    /// <summary>
    /// Interaction logic for AddUserView.xaml
    /// </summary>
    public partial class AddUserView : Window
    {
        public AddUserView()
        {
            InitializeComponent();
            DataContext = new AddUserVM(this);
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
