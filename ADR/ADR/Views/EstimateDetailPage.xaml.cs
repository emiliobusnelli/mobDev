using System;
using System.Collections.Generic;
using ADR.Model;
using SQLite;
using Xamarin.Forms;

namespace ADR.Views
{
    public partial class EstimateDetailPage : ContentPage
    {
        Estimate selectedEstimate;


        public EstimateDetailPage(Estimate selectedEstimate)
        {
            InitializeComponent();

            // get the selected Estimate
            this.selectedEstimate = selectedEstimate;


            // Get the values of the selected estimate

            // Deck 
            txtDeckSqFt.Text = selectedEstimate.DeckSqFt;
            lblDeckTtl.Text = selectedEstimate.DeckTotalCost;
            //pkrDeckCost.SelectedIndex = Int32.Parse(selectedEstimate.DeckCost);


            // Spindals
            txtSpindalLiFt.Text = selectedEstimate.SpindalLiFt;
            lblSpindalTtl.Text = selectedEstimate.SpindalTotalCost;

            // Rails
            txtRailLiFt.Text = selectedEstimate.RailLiFt;
            lblRailTtl.Text = selectedEstimate.RailTotalCost;

            // Fasca
            txtFascaLiFt.Text = selectedEstimate.FascaLiFt;
            lblFascaTtl.Text = selectedEstimate.FascaTotalCost;

            // Skirting
            txtSkirtLiFt.Text = selectedEstimate.SkirtingLiFt;
            lblSkirtTtl.Text = selectedEstimate.SkirtingTotalCost;


            // Steps
            txtNumSteps.Text = selectedEstimate.StepNum;
            lblStepTtl.Text = selectedEstimate.StepTotalCost;

            // Posts
            txtNumPosts.Text = selectedEstimate.PostNum;
            lblPostTtl.Text = selectedEstimate.PostTotalCost;

            // Beams
            txtBeamType.Text = selectedEstimate.BeamType;
            lblBeamTtl.Text = selectedEstimate.BeamTotalCost;

        }

        // Get Deck Square Footage Price
        void DeckCost_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            if (pkrDeckCost.SelectedItem == null)
            {
                App.est.DeckTotalCost = "Total: ";
            }

            else
            {
                App.est.DeckSqFt = txtDeckSqFt.Text;

                var SelectedDeckCost = ((Picker)sender).SelectedItem;

                App.est.DeckCost = (string)SelectedDeckCost;

                App.est.DeckTotalCost = (System.Convert.ToDecimal(App.est.DeckSqFt) * System.Convert.ToDecimal(App.est.DeckCost)).ToString();

                lblDeckTtl.Text = "Total: $" + App.est.DeckTotalCost + ".00";
            }


        }


        // Get Spindal Linear Foot Price
        void SpindalCost_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (pkrSpindalCost.SelectedItem == null)
            {
                App.est.SpindalTotalCost = "Total: ";
            }
            else
            {
                App.est.SpindalLiFt = txtSpindalLiFt.Text;

                var SelectedSpindalCost = ((Picker)sender).SelectedItem;

                App.est.SpindalCost = (string)SelectedSpindalCost;

                App.est.SpindalTotalCost = (System.Convert.ToDecimal(App.est.SpindalLiFt) * System.Convert.ToDecimal(App.est.SpindalCost)).ToString();

                lblSpindalTtl.Text = "Total: $" + App.est.SpindalTotalCost + ".00";
            }


        }



        // Get Rail Linear Foot Price
        void RailCost_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (pkrRailCost.SelectedItem == null)
            {
                App.est.RailTotalCost = "Total: ";
            }
            else
            {
                App.est.RailLiFt = txtRailLiFt.Text;

                var SelectedRailCost = ((Picker)sender).SelectedItem;

                App.est.RailCost = (string)SelectedRailCost;

                App.est.RailTotalCost = (System.Convert.ToDecimal(App.est.RailLiFt) * System.Convert.ToDecimal(App.est.RailCost)).ToString();

                lblRailTtl.Text = "Total: $" + App.est.RailTotalCost + ".00";
            }
        }


        // Get Fasca Linear Foot Price
        void FascaCost_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            App.est.FascaLiFt = txtFascaLiFt.Text;

            var SelectedFascaCost = ((Picker)sender).SelectedItem;

            App.est.FascaCost = (string)SelectedFascaCost;

            App.est.FascaTotalCost = (System.Convert.ToDecimal(App.est.FascaLiFt) * System.Convert.ToDecimal(App.est.FascaCost)).ToString();

            lblFascaTtl.Text = "Total: $" + App.est.FascaTotalCost + ".00";


            //var TotalFascaCost = Int32.Parse(App.deckCalc.FascaLiFt) * Int32.Parse(App.deckCalc.FascaCost);

            //lblFascaTtl.Text = TotalFascaCost.ToString("C");
        }



        // Get Skirting Linear Foot Price
        void SkirtingCost_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            App.est.SkirtingLiFt = txtSkirtLiFt.Text;

            var SelectedSkirtingCost = ((Picker)sender).SelectedItem;

            App.est.SkirtingCost = (string)SelectedSkirtingCost;

            App.est.SkirtingTotalCost = (System.Convert.ToDecimal(App.est.SkirtingLiFt) * System.Convert.ToDecimal(App.est.SkirtingCost)).ToString();

            lblSkirtTtl.Text = "Total: $" + App.est.SkirtingTotalCost + ".00";

            //var TotalSkirtingCost = Int32.Parse(App.deckCalc.SkirtingLiFt) * Int32.Parse(App.deckCalc.SkirtingCost);

            //lblSkirtTtl.Text = TotalSkirtingCost.ToString("C");
        }



        // Get Total Number of Steps and Price
        void StepCost_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            App.est.StepNum = txtNumSteps.Text;

            var SelectedStepCost = ((Picker)sender).SelectedItem;

            App.est.StepCost = (string)SelectedStepCost;

            App.est.StepTotalCost = (System.Convert.ToDecimal(App.est.StepNum) * System.Convert.ToDecimal(App.est.StepCost)).ToString();

            lblStepTtl.Text = "Total: $" + App.est.StepTotalCost + ".00";

            //var TotalStepCost = Int32.Parse(App.deckCalc.StepNum) * Int32.Parse(App.deckCalc.StepCost);

            //lblStepTtl.Text = TotalStepCost.ToString("C");
        }


        // Get Total Number of Posts and Price
        void PostCost_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            App.est.PostNum = txtNumPosts.Text;

            var SelectedPostCost = ((Picker)sender).SelectedItem;

            App.est.PostCost = (string)SelectedPostCost;

            App.est.PostTotalCost = (System.Convert.ToDecimal(App.est.PostNum) * System.Convert.ToDecimal(App.est.PostCost)).ToString();

            lblPostTtl.Text = "Total: $" + App.est.PostTotalCost + ".00";

            //var TotalPostCost = Int32.Parse(App.deckCalc.PostNum) * Int32.Parse(App.deckCalc.PostCost);

            //lblPostTtl.Text = TotalPostCost.ToString("C");
        }


        // Get Beam Type and Price

        void BeamCost_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            App.est.BeamType = txtBeamType.Text;

            var SelectedBeamCost = ((Picker)sender).SelectedItem;

            App.est.BeamCost = (string)SelectedBeamCost;

            App.est.BeamTotalCost = (System.Convert.ToDecimal(App.est.BeamType) * System.Convert.ToDecimal(App.est.BeamCost)).ToString();

            lblBeamTtl.Text = "Total: $" + App.est.BeamTotalCost + ".00";

            //var TotalBeamCost = Int32.Parse(App.deckCalc.BeamType) * Int32.Parse(App.deckCalc.BeamCost);

            //lblBeamTtl.Text = TotalBeamCost.ToString("C");
        }

        void UpdateEstimate_Clicked(object sender, System.EventArgs e)
        {
            // Deck
            selectedEstimate.DeckSqFt = txtDeckSqFt.Text;
            selectedEstimate.DeckTotalCost = lblDeckTtl.Text;
            selectedEstimate.DeckCost = pkrDeckCost.SelectedItem.ToString();


            // Spindals
            selectedEstimate.SpindalLiFt = txtDeckSqFt.Text;
            selectedEstimate.SpindalTotalCost = lblSpindalTtl.Text;
            selectedEstimate.SpindalCost = pkrSpindalCost.SelectedItem.ToString();


            // Rails
            selectedEstimate.RailLiFt = txtRailLiFt.Text;
            selectedEstimate.RailTotalCost = lblRailTtl.Text;
            selectedEstimate.RailCost = pkrRailCost.SelectedItem.ToString();


            // Fasca
            selectedEstimate.FascaLiFt = txtFascaLiFt.Text;
            selectedEstimate.FascaTotalCost = lblFascaTtl.Text;
            selectedEstimate.FascaCost = pkrFascaCost.SelectedItem.ToString();


            // Skirting
            selectedEstimate.SkirtingLiFt = txtSkirtLiFt.Text;
            selectedEstimate.SkirtingTotalCost = lblSkirtTtl.Text;
            selectedEstimate.SkirtingCost = pkrSkirtCost.SelectedItem.ToString();


            // Steps
            selectedEstimate.StepNum = txtNumSteps.Text;
            selectedEstimate.StepTotalCost = lblStepTtl.Text;
            selectedEstimate.StepCost = pkrStepCost.SelectedItem.ToString();


            // Posts
            selectedEstimate.PostNum = txtNumPosts.Text;
            selectedEstimate.PostTotalCost = lblPostTtl.Text;
            selectedEstimate.PostCost = pkrPostCost.SelectedItem.ToString();


            // Beams
            selectedEstimate.BeamType = txtBeamType.Text;
            selectedEstimate.BeamTotalCost = lblBeamTtl.Text;
            selectedEstimate.BeamCost = pkrBeamCost.SelectedItem.ToString();


            // grab database connection
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                // create table for Estimate
                conn.CreateTable<Estimate>();
                int rows = conn.Update(selectedEstimate);

                // check if it was inserted
                if (rows > 0)
                {
                    DisplayAlert("Success", "Estimate Successfully Updated", "Ok");
                }
                else
                {
                    DisplayAlert("Failure", "Estimate Failed to be Updated", "Ok");
                }
            }
        }



        void DeleteEstimate_Clicked(object sender, System.EventArgs e)
        {
            // grab database connection
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                // create table for Estimate
                conn.CreateTable<Estimate>();
                int rows = conn.Delete(selectedEstimate);

                // check if it was inserted
                if (rows > 0)
                {
                    DisplayAlert("Success", "Estimate Successfully Deleted", "Ok");
                }
                else
                {
                    DisplayAlert("Failure", "Estimate Failed to be Deleted", "Ok");
                }
            }
        }
    }
}
