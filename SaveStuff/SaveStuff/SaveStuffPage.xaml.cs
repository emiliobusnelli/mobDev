    using Xamarin.Forms;

namespace SaveStuff
{
    public partial class SaveStuffPage : ContentPage
    {
        public SaveStuffPage()
        {
            InitializeComponent();
        }

        void Save_Clicked(object sender, System.EventArgs e)
        {
            Application.Current.Properties["UserName"] = txtUsername.Text;
        }

        void Read_Clicked(object sender, System.EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("UserName"))
            {
                txtUsername.Text = Application.Current.Properties["UserName"].ToString();
            }
        }

        void Clear_Clicked(object sender, System.EventArgs e)
        {
            txtUsername.Text = string.Empty;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Read_Clicked(null, null);
        }
    }
}