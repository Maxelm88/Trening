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
    public partial class MessagingCenterPage : ContentPage
    {
        public MessagingCenterPage()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, EventArgs e)
        {
            var page = new TargetPage();

            //jeżeli uzyjemy messaging center niepotrzebne
            //page.SliderValueChanged += OnSliderValueChanged;
            MessagingCenter.Subscribe<TargetPage, double>(this, "SliderValueChanged", OnSliderValueChanged);

            Navigation.PushAsync(page);

            MessagingCenter.Unsubscribe<MessagingCenterPage>(this, "SliderValueChanged");
        }

        private void OnSliderValueChanged(TargetPage source, double newValue)
        {
            label.Text = newValue.ToString();
        }
    }
}