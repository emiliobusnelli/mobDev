using Xamarin.Forms;

namespace HelloWorld
{
    public partial class HelloWorldPage : ContentPage
    {
        public HelloWorldPage()
        {
            InitializeComponent();
        }

        void chgDisplay(object sender, System.EventArgs e)
        {
            if(lblDisplay.Text == "Hey Joe, you seeing this?"){
                lblDisplay.Text = "";
            }
            else if(lblDisplay.Text == ""){
                lblDisplay.Text = "Haha, gotcha!";
            }
            else{
                lblDisplay.Text = "Hey Joe, you seeing this?";
            }

        }
    }
}
