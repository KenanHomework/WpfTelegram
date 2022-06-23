using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfTelegram.Commands;

namespace WpfTelegram.MVVM.ViewModel
{
    public class MainVM : DependencyObject
    {
        public int SizeWindow
        {
            get { return (int)GetValue(SizeWindowProperty); }
            set { SetValue(SizeWindowProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SizeWindow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SizeWindowProperty =
            DependencyProperty.Register("SizeWindow", typeof(int), typeof(MainVM), new PropertyMetadata(0));

        public MainVM()
        {
            
        }
    }
}
