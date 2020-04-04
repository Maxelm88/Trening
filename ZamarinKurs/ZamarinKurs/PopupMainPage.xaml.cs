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
    public partial class PopupMainPage : ContentPage
    {
        public PopupMainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {

            #region DisplayAlert
            //var response = await DisplayAlert("warning", "Are you sure?", "yes", "No");
            //  if (response)
            //     await DisplayAlert("Done", "Your reponse will be saved!", "Ok");

            //  //...
            #endregion

           var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "email");
           await DisplayAlert("Response", response, "OK");
        }
    }
}