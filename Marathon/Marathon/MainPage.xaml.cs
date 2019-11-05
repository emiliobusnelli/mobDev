using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;

namespace Marathon
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
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

            wsJson = wsJson;
        }
    }
}
