using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTelegram.Models;

namespace WpfTelegram.Data
{
    public class DataGeneral
    {
        public static ObservableCollection<Contact> AllContacts { get; set; } = new()
        {
            new Contact("Kenan","0552765909"){
            Messages={
                    new("Salam     ",DateTime.Now, true),
                    new("asdsad     ",DateTime.Now, true),
                    new("d asdasdasdqwewqe",DateTime.Now, true),
                    new("Salam     ",DateTime.Now, true),
                    new("Salam ",DateTime.Now, false),
                    new("qweqwewqe     ",DateTime.Now, true),
                    new("Salam     ",DateTime.Now, true),
                    new("qwe     ",DateTime.Now, false)
                } },
            new Contact("Filankes","0552765909"){
            Messages={
                    new("Salam ",DateTime.Now,true),
                    new("asdsad ",DateTime.Now,true),
                    new("d asdasdasdqwewqe",DateTime.Now, true),
                    new("Saasd",DateTime.Now, true),
                    new("Salam ",DateTime.Now, false),
                    new("qweqwewqe ",DateTime.Now, true),
                    new("Salam ",DateTime.Now, true),
                    new("qwe ",DateTime.Now, false)
                } }
        };

        
    }
}
