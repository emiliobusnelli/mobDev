using Xamarin.Forms;

namespace PlatosCalculator
{
    public partial class PlatosCalculatorPage : ContentPage
    {
        

        public PlatosCalculatorPage()
        {
            InitializeComponent();

            pkrGender.Items.Add("Male");
            pkrGender.Items.Add("Female");
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selGender = pkrGender.Items[pkrGender.SelectedIndex];
            lblOptAge.Text = "???";
            txtAge.Text = "";
        }

        void Calc_Clicked(object sender, System.EventArgs e)
        {
            var selGender = pkrGender.SelectedItem;
            double dblAge;


            double.TryParse(txtAge.Text, out dblAge); 


            if(selGender.Equals("Male")){
                lblOptAge.Text = ((dblAge / 2) + 7).ToString();
            }
            else{
                lblOptAge.Text = ((dblAge * 2) - 14).ToString();
            }
        }
    }
}
