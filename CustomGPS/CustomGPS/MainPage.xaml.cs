using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGPS.Custom;
using Xamarin.Forms;

namespace CustomGPS
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Set Up Event Handler
            DependencyService.Get<ICurrentLocation>().LocationUpdated += delegate
            {
                lblLon.Text = "LON: " + App.CurrentLon.ToString();

                lblLat.Text = "LAT: " + App.CurrentLat.ToString();
            };
        }


        void UpdateLocation_Clicked(object sender, System.EventArgs e)
        {

            DependencyService.Get<ICurrentLocation>().UpdateCurrentLocation();



        }

        void Clear_Clicked(object sender, System.EventArgs e)
        {
            lblLon.Text = "LON: 000000";

            lblLat.Text = "LAT: 111111";
        }
    }
}
