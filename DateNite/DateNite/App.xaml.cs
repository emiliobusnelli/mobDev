using Xamarin.Forms;
using DateNite.Views;
using DateNite.model;

namespace DateNite
{
    public partial class App : Application
    {
        public static DateCalculator dateCalc;

        public App()
        {
            InitializeComponent();

            MainPage = new TabController();
            dateCalc = new DateCalculator();
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
