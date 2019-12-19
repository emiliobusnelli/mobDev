using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Xamarin.Forms.Maps;

namespace GeoLocate
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        // Get location via Longitude and Latitude
        private async void GetLocationBtn_OnClicked(object sender, EventArgs e)
        {


            try
            {
                // get location
                var location = CrossGeolocator.Current;
                location.DesiredAccuracy = 1;

                // set position
                var position = await location.GetPositionAsync(TimeSpan.FromSeconds(1));

                // assign longitude and latitude
                double latitude = Convert.ToDouble(position.Latitude);
                double longitude = Convert.ToDouble(position.Longitude);

                var center = new Xamarin.Forms.Maps.Position(latitude, longitude);

                await DisplayAlert("Geolocation", $"Latitude: {latitude} Longitude: {longitude}", "Ok");

                // Move Map
                MapSpan mapSpan = MapSpan.FromCenterAndRadius(center, Distance.FromKilometers(0.444));
                map.MoveToRegion(mapSpan);

            }
            catch (Exception ex)
            {
                await DisplayAlert("Geolocation", $"Something went wrong: {ex}", "Ok");
            }

        }



        


    }
}