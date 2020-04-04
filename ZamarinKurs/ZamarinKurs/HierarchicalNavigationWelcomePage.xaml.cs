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
    public partial class HierarchicalNavigationWelcomePage : ContentPage
    {
        public HierarchicalNavigationWelcomePage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
          //await Navigation.PushAsync(new HierarchicalNavigationIntroductionPage()); //Hierachicall Navigation
          await Navigation.PushModalAsync(new HierarchicalNavigationIntroductionPage()); //Modal Navigation
        }
    }
}