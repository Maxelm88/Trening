using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ZamarinKurs
{
    public partial class App : Application
    {


        #region Application Properties
        //private const string TitleKey = "Name";
        //private const string NotificationsEnabledKey = "NotificationsEnabled";
        #endregion

        public App()
        {
            InitializeComponent();

            //MainPage = new TableViewPage();

            MainPage = new DataBaseJson();

            //MainPage = new NavigationPage ( new ToolbarMainPage());

            //MainPage = new NavigationPage(new TableViewPage());


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

        #region Application Properties
        //public string Title
        //{
        //    get
        //    {
        //        if (Properties.ContainsKey(TitleKey))
        //           return Properties[TitleKey].ToString();
        //        return "";
        //    }
        //    set
        //    {
        //        Properties[TitleKey] = value;
        //    }
        //}

        //public bool NotificationsEnabled
        //{
        //    get
        //    {
        //        if (Properties.ContainsKey(NotificationsEnabledKey))
        //           return (bool)Properties[NotificationsEnabledKey];
        //        return false;
        //    }
        //    set
        //    {
        //        Properties[NotificationsEnabledKey] = value;
        //    }
        //}
        #endregion
    }
}
