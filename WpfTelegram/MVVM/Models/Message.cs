using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public string MessageTime => Time.ToShortTimeString();

        public string Text { get; set; }

        public bool WritedByContact { get; set; }

        public HorizontalAlignment Alignment => WritedByContact ? HorizontalAlignment.Right : HorizontalAlignment.Left;

        public override string ToString() => Text;
    }
}
