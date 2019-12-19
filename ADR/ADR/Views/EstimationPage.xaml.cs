using System;
using System.Collections.Generic;
using ADR.Model;
using ADR.Views;
using SQLite;
using Xamarin.Forms;

namespace ADR.Views
{
    public partial class EstimationPage : ContentPage
    {
        public EstimationPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.est.EstimateTotalCost = App.est.GetTotalCost();

            lblEstTtl.Text = App.est.EstimateTotalCost;

            //lblEstTtl.Text = App.est.GetTotalCost();
        }


        private void SubmitEstimate_Clicked(object sender, EventArgs e)
        {

            if (txtFullName.Text == String.Empty)
            {
                DisplayAlert("No Name", "Please Enter a Full Name Before Submitting", "Ok");
            }
            else
            {
                App.est.FullName = txtFullName.Text;

                DateTime DateEstimated = DateTime.Today;

                Estimate estimate = new Estimate();
                {

                    // Name
                    estimate.FullName = App.est.FullName;

                    // Date Estimated
                    estimate.DateEstimated = DateTime.Now.ToString("MM/dd/yyyy"); 

                    //DateEstimated

                    // Estimate TOTAL Cost
                    estimate.EstimateTotalCost = App.est.EstimateTotalCost;


                    // Deck Area
                    estimate.DeckSqFt = App.est.DeckSqFt;
                    estimate.DeckCost = App.est.DeckCost;
                    estimate.DeckTotalCost = App.est.DeckTotalCost;

                    //Spindal
                    estimate.SpindalLiFt = App.est.SpindalLiFt;
                    estimate.SpindalCost = App.est.SpindalCost;
                    estimate.SpindalTotalCost = App.est.SpindalTotalCost;

                    //Rail
                    estimate.RailLiFt = App.est.RailLiFt;
                    estimate.RailCost = App.est.RailCost;
                    estimate.RailTotalCost = App.est.RailTotalCost;

                    //Fasca
                    estimate.FascaLiFt = App.est.RailLiFt;
                    estimate.FascaCost = App.est.FascaCost;
                    estimate.FascaTotalCost = App.est.FascaTotalCost;

                    //Skirting
                    estimate.SkirtingLiFt = App.est.SkirtingLiFt;
                    estimate.SkirtingCost = App.est.SkirtingCost;
                    estimate.SkirtingTotalCost = App.est.SkirtingTotalCost;

                    //Steps
                    estimate.StepNum = App.est.StepNum;
                    estimate.StepCost = App.est.StepCost;
                    estimate.StepTotalCost = App.est.StepTotalCost;

                    //Posts
                    estimate.PostNum = App.est.PostNum;
                    estimate.PostCost = App.est.PostCost;
                    estimate.PostTotalCost = App.est.PostTotalCost;

                    //Beams
                    estimate.BeamType = App.est.BeamType;
                    estimate.BeamCost = App.est.BeamCost;
                    estimate.BeamTotalCost = App.est.BeamTotalCost;

                }

                // grab database connection
                using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
                {
                    // create table for Estimate
                    conn.CreateTable<Estimate>();
                    int rows = conn.Insert(estimate);

                    // check if it was inserted
                    if (rows > 0)
                    {
                        DisplayAlert("Success", "Estimate Successfully Inserted", "Ok");
                    }
                    else
                    {
                        DisplayAlert("Failure", "Estimate Failed to be Inserted", "Ok");
                    }
                }


                //// Clear Model
                //// Name
                //App.est.FullName = null;

                //// Deck Area
                //App.est.DeckSqFt = null;
                //App.est.DeckCost = null;
                //App.est.DeckTotalCost = null;

                ////Spindal
                //App.est.SpindalLiFt = null;
                //App.est.SpindalCost = null;
                //App.est.SpindalTotalCost = null;

                ////Rail
                //App.est.RailLiFt = null;
                //App.est.RailCost = null;
                //App.est.RailTotalCost = null;

                ////Fasca
                //App.est.RailLiFt = null;
                //App.est.FascaCost = null;
                //App.est.FascaTotalCost = null;

                ////Skirting
                //App.est.SkirtingLiFt = null;
                //App.est.SkirtingCost = null;
                //App.est.SkirtingTotalCost = null;

                ////Steps
                //App.est.StepNum = null;
                //App.est.StepCost = null;
                //App.est.StepTotalCost = null;

                ////Posts
                //App.est.PostNum = null;
                //App.est.PostCost = null;
                //App.est.PostTotalCost = null;

                ////Beams
                //App.est.BeamType = null;
                //App.est.BeamCost = null;
                //App.est.BeamTotalCost = null;




                // Clear Name
                txtFullName.Text = string.Empty;
                

            }
            
        }
            
    }
}
