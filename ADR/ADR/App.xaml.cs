using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ADR.Model;

namespace ADR
{
    public partial class App : Application
    {

        public static Estimate est;
        public static string DatabaseLocation = string.Empty;

        public App()
        {
            InitializeComponent();

            MainPage = new TabController();
            est = new Estimate();

        }


        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TabController());

            //MainPage = new TabController();
            est = new Estimate();

            DatabaseLocation = databaseLocation;

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
