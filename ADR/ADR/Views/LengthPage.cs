using System;

using Xamarin.Forms;

namespace ADR.Views
{
    public class LengthPage : ContentPage
    {
        public LengthPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

