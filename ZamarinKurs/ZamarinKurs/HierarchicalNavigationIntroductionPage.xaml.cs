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
    public partial class HierarchicalNavigationIntroductionPage : ContentPage
    {
        public HierarchicalNavigationIntroductionPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
           //await Navigation.PopAsync(); //Hierachicall Navigation
           await Navigation.PopModalAsync(); //Modal Navigation
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}