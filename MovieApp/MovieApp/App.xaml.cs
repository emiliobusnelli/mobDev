using System;
using Xamarin.Forms;
using MovieApp.Custom;
using MovieApp.Models;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;

namespace MovieApp
{
    public partial class App : Application
    {

        static Database _movieDB;

        public static Database SQLiteDB
        {
            get{
                if (_movieDB==null){
                    _movieDB = new Database();
                }
                return _movieDB;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new TabLayout();
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
