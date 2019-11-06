using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Runathon.Models;
using Newtonsoft.Json;

namespace Runathon
{
    public partial class RunathonPage : ContentPage
    {
        RaceCollection RaceObject;

        public RunathonPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FillPicker();
        }

        private void FillPicker()
        {
            var client = new HttpClient();
            client.BaseAddress = new System.Uri("http://itweb.fvtc.edu/wetzel/marathon/");

            var response = client.GetAsync("races/").Result;

            // web service
            var wsJson = response.Content.ReadAsStringAsync().Result;

            RaceObject = JsonConvert.DeserializeObject<RaceCollection>(wsJson);

            if(RaceObject != null)
            {
                RacePicker.Items.Clear();

                foreach (race CurrentRace in RaceObject.races)
                {
                    RacePicker.Items.Add(CurrentRace.race_name);
                }
            }
        }

        void Race_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var SelectedRace = ((Picker)sender).SelectedIndex;
            var RaceID = RaceObject.races[SelectedRace].id;


            var client = new HttpClient();
            client.BaseAddress = new System.Uri("http://itweb.fvtc.edu/wetzel/marathon/");

            var response = client.GetAsync("results/" + RaceID).Result;

            // web service
            var wsJson = response.Content.ReadAsStringAsync().Result;

            var ResultsObject = JsonConvert.DeserializeObject<ResultsCollection>(wsJson);

            // data template in listview
            var CellTemplate = new DataTemplate(typeof(TextCell));
            CellTemplate.SetBinding(TextCell.TextProperty, "name");
            CellTemplate.SetBinding(TextCell.DetailProperty, "detail");
            ResultListView.ItemTemplate = CellTemplate;
            ResultListView.ItemsSource = ResultsObject.results;





        }
    }
}
