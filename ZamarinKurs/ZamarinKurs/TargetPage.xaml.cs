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
    public partial class TargetPage : ContentPage
    {
        //jeżeli uzyjemy messaging center niepotrzebne
        //public event EventHandler<double> SliderValueChanged;
        public TargetPage()
        {
            InitializeComponent();
        }

        private void OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            //jeżeli uzyjemy messaging center niepotrzebne
            // SliderValueChanged?.Invoke(this, e.NewValue);
            MessagingCenter.Send(this, "SliderValueChanged", e.NewValue);
        }
    }
}