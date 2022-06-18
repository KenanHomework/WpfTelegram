using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTelegram.Models
{
    public class Message
    {
        public Message(string text, bool writedByContact)
        {
            Text = text;
            WritedByContact = writedByContact;
        }

        public string Text { get; set; }

        public bool WritedByContact { get; set; }

        public override string ToString() => Text;
    }
}
