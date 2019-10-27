using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MovieApp.Views
{
    public partial class FindPage : ContentPage
    {
        public FindPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var MovieTemplate = new DataTemplate(typeof(TextCell));
            MovieTemplate.SetBinding(TextCell.TextProperty, "Title");
            MovieTemplate.SetBinding(TextCell.DetailProperty, "Rating");

            lstMovies.ItemTemplate = MovieTemplate;

            lstMovies.ItemsSource = App.SQLiteDB.MovieList();
        }
    }
}
