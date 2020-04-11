using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZamarinKurs
{
    public class ContactMethod
    {
        public int id { get; set; }
        public string Name { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormsPage : ContentPage
    {
        #region Forms
        //private IList<ContactMethod> _contactMethods;
        //public FormsPage()
        //{
        //    InitializeComponent();

        //    _contactMethods = GetContactMethods();
        //    foreach (var method in _contactMethods)
        //        picker.Items.Add(method.Name);
        //}

        //private IList<ContactMethod> GetContactMethods()
        //{
        //    return new List<ContactMethod>
        //    {
        //        new ContactMethod {id = 1, Name = "SMS"},
        //        new ContactMethod {id = 2, Name = "Email"}
        //    };
        //}

        //private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{

        //}

        //private void Entry_Completed(object sender, EventArgs e)
        //{
        //    label2.Text = "Is completed";
        //}

        //private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //   var name = picker.Items[picker.SelectedIndex];
        //   var contactMethod = _contactMethods.Single(cm => cm.Name == name);


        //    DisplayAlert("selection", name, "ok");
        //}
        #endregion

        public FormsPage()
        {
            InitializeComponent();

        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}