using Xamarin.Forms;

namespace AddMaster
{
    public partial class AddMasterPage : ContentPage
    {
        public AddMasterPage()
        {
            InitializeComponent();
        }

        void Add_Clicked(object sender, System.EventArgs e)
        {
            double dblFirstNum, dblSecondNum;

            // try to parse txtFirstNum Text, if successful, output it to dblFirstNum
            double.TryParse(txtFirstNum.Text,out dblFirstNum);
            double.TryParse(txtSecondNum.Text,out dblSecondNum);

            lblDisplay.Text = (dblFirstNum + dblSecondNum).ToString();
        }

        void Clear_Clicked(object sender, System.EventArgs e)
        {
            txtFirstNum.Text = string.Empty;
            txtSecondNum.Text = string.Empty;
            lblDisplay.Text = "0";
        }
    }
}
