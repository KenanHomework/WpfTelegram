using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfTelegram.Commands;
using WpfTelegram.Models;
using WpfTelegram.MVVM.View;

namespace WpfTelegram.MVVM.ViewModel
{
    public class AddUserVM : DependencyObject
    {
        public Contact Contact { get; set; } = null;

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Name.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NameProperty =
            DependencyProperty.Register("Name", typeof(string), typeof(AddUserVM));

        public string LastName
        {
            get { return (string)GetValue(LastNameProperty); }
            set { SetValue(LastNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LastName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LastNameProperty =
            DependencyProperty.Register("LastName", typeof(string), typeof(AddUserVM));

        public string PhoneNumber
        {
            get { return (string)GetValue(PhoneNumberProperty); }
            set { SetValue(PhoneNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Phone.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PhoneNumberProperty =
            DependencyProperty.Register("PhoneNumber", typeof(string), typeof(AddUserVM));

        RelayCommand AddCommand;
        RelayCommand CloseCommand;

        public AddUserVM(AddUserView window)
        {
            Name = string.Empty;
            LastName = string.Empty;
            PhoneNumber = string.Empty;
            AddCommand = new
            (
                e =>
                {
                    Contact = new(Name + LastName, PhoneNumber);
                    //Contact = new(Name + LastName,"055");
                    window.DialogResult = true;
                    window.Close();
                }
            , new(e => !string.IsNullOrWhiteSpace(Name)));

            CloseCommand = new(
                e =>
                {
                    window.DialogResult = false;
                }
                );
        }


    }
}
