using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ZamarinKurs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabMainPage();


            //MainPage = new NavigationPage (new ContactsPage());

            #region Hierarchical Navigation
            //MainPage = new NavigationPage(new HierarchicalNavigationWelcomePage())
            //{
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};
            #endregion
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
