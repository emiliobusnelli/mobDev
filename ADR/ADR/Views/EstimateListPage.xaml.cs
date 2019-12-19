using System;
using System.Collections.Generic;
using System.Linq;
using ADR.Model;
using SQLite;
using Xamarin.Forms;

namespace ADR.Views
{
    public partial class EstimateListPage : ContentPage
    {
        public EstimateListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            

            // Once Line leaves Inner Block - Dispose Method is fired, closing conn
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Estimate>();
                var estimates = conn.Table<Estimate>().ToList();
                lstEstimates.ItemsSource = estimates;
            }



            
        }

        void estimate_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var selectedEstimated = lstEstimates.SelectedItem as Estimate;

            if(selectedEstimated != null)
            {
                Navigation.PushAsync(new EstimateDetailPage(selectedEstimated));
            }
        }


        // Must close db conn every time
        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
        //    conn.CreateTable<Estimate>();
        //    var estimates = conn.Table<Estimate>().ToList();
        //    //conn.Close();

        //}
    }
}
