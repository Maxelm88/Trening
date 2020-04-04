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
    public partial class ContactsPage : MasterDetailPage
    {
        public ContactsPage()
        {
            InitializeComponent();

            listView.ItemsSource = GetContacts();

        }

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

        void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage ( new ContactDetailPage(contact));
            IsPresented = false; //IsMasterPresented
        }
    }

}