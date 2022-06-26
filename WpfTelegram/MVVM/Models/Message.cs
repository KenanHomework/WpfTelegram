using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTelegram.Models
{
    public class Message
    {
        public Message(string text, DateTime time, bool writedByContact = false)
        {
            Time = time;
            Text = text;
            WritedByContact = writedByContact;
        }

        public DateTime Time { get; set; } = DateTime.Now;

        public string Text { get; set; }

        public bool WritedByContact { get; set; }

        public override string ToString() => Text;
    }
}
