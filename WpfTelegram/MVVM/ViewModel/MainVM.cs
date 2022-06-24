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

namespace WpfTelegram.MVVM.ViewModel
{
    public class MainVM : DependencyObject
    {
        public ObservableCollection<Contact> Chats { get; set; } = new()
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

        public  ObservableCollection<Contact> AllContacts { get; set; } = new()
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

        public void Add(Contact contact) => AllContacts.Add(contact);

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
