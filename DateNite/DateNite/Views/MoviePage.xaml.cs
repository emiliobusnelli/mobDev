using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNite.Views
{
    public partial class MoviePage : ContentPage
    {
        public MoviePage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            App.dateCalc.MovieCost = txtMovie.Text;
        }
    }
}
