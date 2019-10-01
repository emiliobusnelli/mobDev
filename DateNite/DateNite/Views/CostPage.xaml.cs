using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNite.Views
{
    public partial class CostPage : ContentPage
    {
        public CostPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lblCost.Text = App.dateCalc.GetTotalCost();
        }
    }
}
