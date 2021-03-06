using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfTelegram.Models
{
    public class Contact
    {
        public Contact(string username, string phone)
        {
            Username = username;
            Phone = phone;
        }

        public Contact()
        {

        }

        public Contact(string username, string phone, string sourceOfPP)
        {
            Username = username;
            Phone = phone;
            SourceOfPP = sourceOfPP;
        }

        public string Username { get; set; }

        public string SourceOfPP { get; set; } = "https://mysalonsoftware.co.za/wp-content/uploads/2019/08/avatar-user-hacker-3830b32ad9e0802c-512x512.png";

        public string SourceOfBackground { get; set; } = "https://mysalonsoftware.co.za/wp-content/uploads/2019/08/avatar-user-hacker-3830b32ad9e0802c-512x512.png";

        public bool NoChat => Messages.Count == 0;

        public string Phone { get; set; }

        public string Lastseen { get; set; } = DateTime.Now.ToShortTimeString();

        public ObservableCollection<Message> Messages { get; set; } = new();

        public string LastMessageTime
        {
            get
            {
                if (NoChat)
                    return string.Empty;
                return Messages.Last().Time.ToShortTimeString();

            }
        }

        public string LastMessage
        {
            get
            {
                if (NoChat)
                    return null;
                return Messages.Last().ToString();

            }
        }

        public override string ToString() => $"{Username} ~ {Phone} ";

        public void Calculate()
        {
            Lastseen = DateTime.Now.ToShortTimeString();
        }
    }
}
