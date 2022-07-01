using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfTelegram.Commands;
using WpfTelegram.Models;
using WpfTelegram.Services;

namespace WpfTelegram.MVVM.ViewModel
{
    public class MainVM : DependencyObject
    {
        public static ObservableCollection<Contact> Chats { get; set; } = new()
        {
            new Contact("Kenan", "0552765909")
            {
                Messages ={
                    new("Salam     ",DateTime.Now, true),
                    new("asdsad     ",DateTime.Now, true),
                    new("d asdasdasdqwewqe",DateTime.Now, true),
                    new("Salam     ",DateTime.Now, true),
                    new("Salam ",DateTime.Now, false),
                    new("qweqwewqe     ",DateTime.Now, true),
                    new("Salam     ",DateTime.Now, true),
                    new("qwe     ",DateTime.Now, false)
                }
            },
            new Contact("Filankes", "0552765909")
            {
                Messages ={
                    new("Salam ",DateTime.Now,true),
                    new("asdsad ",DateTime.Now,true),
                    new("d asdasdasdqwewqe",DateTime.Now, true),
                    new("Saasd",DateTime.Now, true),
                    new("Salam ",DateTime.Now, false),
                    new("qweqwewqe ",DateTime.Now, true),
                    new("Salam ",DateTime.Now, true),
                    new("Asdhjdjash ",DateTime.Now, false)
                }
            }
            ,
            new Contact("Filankes", "0552765909")
            {
                Messages ={
                    new("Salam ",DateTime.Now,true),
                    new("asdsad ",DateTime.Now,true),
                    new("d asdasdasdqwewqe",DateTime.Now, true),
                    new("Saasd",DateTime.Now, true),
                    new("Salam ",DateTime.Now, false),
                    new("qweqwewqe ",DateTime.Now, true),
                    new("Salam ",DateTime.Now, true),
                    new("Asdhjdjash ",DateTime.Now, false)
                }
            }
            ,
            new Contact("Filankes", "0552765909")
            {
                Messages ={
                    new("Salam ",DateTime.Now,true),
                    new("asdsad ",DateTime.Now,true),
                    new("d asdasdasdqwewqe",DateTime.Now, true),
                    new("Saasd",DateTime.Now, true),
                    new("Salam ",DateTime.Now, false),
                    new("qweqwewqe ",DateTime.Now, true),
                    new("Salam ",DateTime.Now, true),
                    new("Asdhjdjash ",DateTime.Now, false)
                }
            }
            ,
            new Contact("Filankes", "0552765909")
            {
                Messages ={
                    new("Salam ",DateTime.Now,true),
                    new("asdsad ",DateTime.Now,true),
                    new("d asdasdasdqwewqe",DateTime.Now, true),
                    new("Saasd",DateTime.Now, true),
                    new("Salam ",DateTime.Now, false),
                    new("qweqwewqe ",DateTime.Now, true),
                    new("Salam ",DateTime.Now, true),
                    new("Asdhjdjash ",DateTime.Now, false)
                }
            }
            ,
            new Contact("Filankes", "0552765909")
            {
                Messages ={
                    new("Salam ",DateTime.Now,true),
                    new("asdsad ",DateTime.Now,true),
                    new("d asdasdasdqwewqe",DateTime.Now, true),
                    new("Saasd",DateTime.Now, true),
                    new("Salam ",DateTime.Now, false),
                    new("qweqwewqe ",DateTime.Now, true),
                    new("Salam ",DateTime.Now, true),
                    new("Asdhjdjash ",DateTime.Now, false)
                }
            }
            ,
            new Contact("Filankes", "0552765909")
            {
                Messages ={
                    new("Salam ",DateTime.Now,true),
                    new("asdsad ",DateTime.Now,true),
                    new("d asdasdasdqwewqe",DateTime.Now, true),
                    new("Saasd",DateTime.Now, true),
                    new("Salam ",DateTime.Now, false),
                    new("qweqwewqe ",DateTime.Now, true),
                    new("Salam ",DateTime.Now, true),
                    new("Asdhjdjash ",DateTime.Now, false)
                }
            }
            ,
            new Contact("Filankes", "0552765909")
            {
                Messages ={
                    new("Salam ",DateTime.Now,true),
                    new("asdsad ",DateTime.Now,true),
                    new("d asdasdasdqwewqe",DateTime.Now, true),
                    new("Saasd",DateTime.Now, true),
                    new("Salam ",DateTime.Now, false),
                    new("qweqwewqe ",DateTime.Now, true),
                    new("Salam ",DateTime.Now, true),
                    new("Asdhjdjash ",DateTime.Now, false)
                }
            }
            ,
            new Contact("Filankes", "0552765909")
            {
                Messages ={
                    new("Salam ",DateTime.Now,true),
                    new("asdsad ",DateTime.Now,true),
                    new("d asdasdasdqwewqe",DateTime.Now, true),
                    new("Saasd",DateTime.Now, true),
                    new("Salam ",DateTime.Now, false),
                    new("qweqwewqe ",DateTime.Now, true),
                    new("Salam ",DateTime.Now, true),
                    new("Asdhjdjash ",DateTime.Now, false)
                }
            }
        };

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

        public static void Add(Contact contact)
        {
            if (!AllContacts.Contains(contact)) AllContacts.Add(contact);
        }

        public static void AddMessage(Contact contact, Message message)
        {
            int index = Chats.IndexOf(contact);
            Chats[index].Messages.Add(message);
            Chats[index].Calculate();

        }

        public static void Save()
        {
            ServicesOfJSON.Write("allContacts.json", AllContacts);
            ServicesOfJSON.Write("chats.json", Chats);
        }

        public static void Get()
        {
            try
            {
                AllContacts = ServicesOfJSON.Read<ObservableCollection<Contact>>("allContacts.json");
            }
            catch (Exception)
            {

                AllContacts = new();
            }
            try
            {
                Chats = ServicesOfJSON.Read<ObservableCollection<Contact>>("chats.json");
            }
            catch (Exception)
            {
                Chats = new();
            }
        }

        public int SizeWindow
        {
            get
            {
                return -200 + (int)GetValue(SizeWindowProperty);
            }
            set { SetValue(SizeWindowProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SizeWindow.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SizeWindowProperty =
            DependencyProperty.Register("SizeWindow", typeof(int), typeof(MainVM));

        public MainVM()
        {

        }
    }
}
