using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZamarinKurs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApplicationPropertiesPage : ContentPage
    {
        //przeniesiono do App.xaml.cs
        //private const string TitleKey = "Name";
        //private const string NotificationsEnabledKey = "NotificationsEnabled";

        public ApplicationPropertiesPage()
        {
            InitializeComponent();

            // przed przenisieniem zmiennych do App
            //if (Application.Current.Properties.ContainsKey(TitleKey))
            //    title.Text = Application.Current.Properties[TitleKey].ToString();

            //if (Application.Current.Properties.ContainsKey(NotificationsEnabledKey))
            //    notificationsEnabled.On = (bool)Application.Current.Properties[NotificationsEnabledKey];

            //po przeniesieniu zmiennych do App

            BindingContext = Application.Current;

            //po dodaniu  BindingContext
            //var app = Application.Current as App;
            //title.Text = app.Title;
            //notificationsEnabled.On = app.NotificationsEnabled;
        }


        // przed przenisieniem zmiennych do App
        //private void OnChange(object sender, EventArgs e)
        //{
        //    Application.Current.Properties[TitleKey] = title.Text;
        //    Application.Current.Properties[NotificationsEnabledKey] = notificationsEnabled.On;

        //    //Application.Current.SavePropertiesAsync(); //zapisuje ustawienia w locie
        //}


        //po przeniesieniu zmiennych do App
        //po dodaniu  BindingContext nie potrzebna metoda
        //private void OnChange(object sender, EventArgs e)
        //{
        //    var app = Application.Current as App;
        //    app.Title = title.Text;
        //    app.NotificationsEnabled = notificationsEnabled.On;
        //}
    }
}