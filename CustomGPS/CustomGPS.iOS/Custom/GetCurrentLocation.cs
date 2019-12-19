using System;
using CustomGPS.Custom;
using Xamarin.Forms;
using Plugin.Geolocator;
using System.Threading.Tasks;

[assembly: Dependency(typeof(CustomGPS.iOS.Custom.GetCurrentLocation))]

namespace CustomGPS.iOS.Custom
{
    public class GetCurrentLocation:ICurrentLocation
    {
        public event EventHandler LocationUpdated;

        public GetCurrentLocation()
        {

        }

        public void UpdateCurrentLocation()
        {
            // Get GPS Location
            var locator = CrossGeolocator.Current;

            //accuracy level
            locator.DesiredAccuracy = 100;

            // Get Current Posotion     timeout                 if not timed out    
            locator.GetPositionAsync(TimeSpan.FromSeconds(10)).ContinueWith(t=>
            {
                // Save Location
                App.CurrentLat = t.Result.Latitude;
                App.CurrentLon = t.Result.Longitude;

                // Flag Process As Done
                LocationUpdated(null, null);

            }, TaskScheduler.FromCurrentSynchronizationContext());

            
        }
    }
}
