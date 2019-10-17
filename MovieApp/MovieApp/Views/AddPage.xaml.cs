using System;
using System.Collections.Generic;
using MovieApp.Models;
using Xamarin.Forms;

namespace MovieApp.Views
{
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        void AddMovie_Clicked(object sender, System.EventArgs e)
        {
            var NewMovie = new Movie();

            NewMovie.Title = txtMovieTitle.Text;
            NewMovie.Rating = txtMovieRating.Text;

            App.MovieList.Add(NewMovie);

            txtMovieTitle.Text = string.Empty;
            txtMovieRating.Text = string.Empty;


        }
    }
}
