using System;
using System.Collections.Generic;
using ADR.Model;

using Xamarin.Forms;

namespace ADR.Views
{
    public partial class LengthPage : ContentPage
    {
        public LengthPage()
        {
            InitializeComponent();
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

        private void ClearForm_Clicked(object sender, EventArgs e)
        {



            // Clear Input Boxes
            txtDeckSqFt.Text = string.Empty;
            txtSpindalLiFt.Text = string.Empty;
            txtRailLiFt.Text = string.Empty;
            txtFascaLiFt.Text = string.Empty;
            txtSkirtLiFt.Text = string.Empty;
            txtNumSteps.Text = string.Empty;
            txtNumPosts.Text = string.Empty;
            txtBeamType.Text = string.Empty;


            //// Reset Pickers
            pkrDeckCost.SelectedItem = null;
            //pkrSpindalCost.SelectedIndex = default;
            //pkrRailCost.SelectedIndex = default;
            //pkrFascaCost.SelectedIndex = default;
            //pkrSkirtCost.SelectedIndex = default;
            //pkrStepCost.SelectedIndex = default;
            //pkrPostCost.SelectedIndex = default;
            //pkrBeamCost.SelectedIndex = default;


            // Clear Labels
            lblDeckTtl.Text = "Total: ";
            lblSpindalTtl.Text = "Total: ";
            lblRailTtl.Text = "Total: ";
            lblFascaTtl.Text = "Total: ";
            lblSkirtTtl.Text = "Total: ";
            lblStepTtl.Text = "Total: ";
            lblPostTtl.Text = "Total: ";
            lblBeamTtl.Text = "Total: ";
        }


        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();


        //    // Clear Input Boxes
        //    txtDeckSqFt.Text = string.Empty;
        //    txtSpindalLiFt.Text = string.Empty;
        //    txtRailLiFt.Text = string.Empty;
        //    txtFascaLiFt.Text = string.Empty;
        //    txtSkirtLiFt.Text = string.Empty;
        //    txtNumSteps.Text = string.Empty;
        //    txtNumPosts.Text = string.Empty;
        //    txtBeamType.Text = string.Empty;


        //    // Reset Pickers
        //    pkrDeckCost.SelectedIndex = default;
        //    pkrSpindalCost.SelectedIndex = default;
        //    pkrRailCost.SelectedIndex = default;
        //    pkrFascaCost.SelectedIndex = default;
        //    pkrSkirtCost.SelectedIndex = default;
        //    pkrStepCost.SelectedIndex = default;
        //    pkrPostCost.SelectedIndex = default;
        //    pkrBeamCost.SelectedIndex = default;


        //    // Clear Labels
        //    lblDeckTtl.Text = "Total: ";
        //    lblSpindalTtl.Text = "Total: ";
        //    lblRailTtl.Text = "Total: ";
        //    lblFascaTtl.Text = "Total: ";
        //    lblSkirtTtl.Text = "Total: ";
        //    lblStepTtl.Text = "Total: ";
        //    lblPostTtl.Text = "Total: ";
        //    lblBeamTtl.Text = "Total: ";




        //}
    }





        


    
}
