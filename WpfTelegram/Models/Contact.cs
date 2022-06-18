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
        public Contact(string username, string sourceOfPP, string lastseen)
        {
            Username = username;
            SourceOfPP = sourceOfPP;
            Lastseen = lastseen;
        }

        public string Username { get; set; }

        public string SourceOfPP { get; set; }

        public string Lastseen { get; set; }

        public ObservableCollection<Message> Messages { get; set; } = new();

        public Message LastMessage => Messages.Last();
    }
}
