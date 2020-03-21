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
    public partial class QuotesPage : ContentPage
    {
        int numer;
        List<string> cytat = new List<string>() { "cytat 1", "cytat 2", "cytat 3" };
        public QuotesPage()
        {
            InitializeComponent();

            numer = 0;
            quotes.Text = cytat[numer];
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            numer = numer + 1;
            if (numer > 2)
            {
                numer = 0;
            }
            quotes.Text = cytat[numer];
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            quotes.FontSize = slider.Value;
        }

    }
}