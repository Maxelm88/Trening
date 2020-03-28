using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZamarinKurs.Models;

namespace ZamarinKurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicList : ContentPage
    {
        public BasicList()
        {
            InitializeComponent();

            #region listView grupowanie listy
            //listView.ItemsSource = new List<ContactGroup>
            //{
            //    new ContactGroup("M", "M")
            //    {
            //    new Contact { Name = "Mosh", ImageUrl  = "http://icons.iconarchive.com/icons/treetog/junior/96/camera-icon.png"},

            //    },

            //    new ContactGroup("J", "J")
            //    {
            //new Contact { Name = "John", ImageUrl = "http://icons.iconarchive.com/icons/tuziibanez/profesional-red/96/pictures-folder-icon.png", Status = "Hey, lests talk" }

            //    }
            //};
            #endregion

            listView.ItemsSource = GetContacts();
        }

        #region klikanie i trzymanie
        //bool isSelected = false;
        //private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    isSelected = true;
        //    var contact = e.SelectedItem as Contact;
        //    DisplayAlert("Selected", contact.Name, "OK");
        //}

        //private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        //{
        //    if (isSelected)
        //    {
        //        isSelected = false;
        //        return;
        //    }
        //    var contact = e.Item as Contact;
        //    DisplayAlert("Tapped", contact.Name, "ok");
        //}
        #endregion

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
           var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private ObservableCollection<Contact> _contacts;
        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            listView.EndRefresh();
        }

        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new ObservableCollection<Contact>
            {
                new Contact { Name = "Mosh", ImageUrl  = "http://icons.iconarchive.com/icons/treetog/junior/96/camera-icon.png"},
            new Contact { Name = "John", ImageUrl = "http://icons.iconarchive.com/icons/tuziibanez/profesional-red/96/pictures-folder-icon.png", Status = "Hey, lests talk" }

            };

            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c => c.Name.StartsWith(searchText));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
           listView.ItemsSource = GetContacts(e.NewTextValue);
        }
    }
}