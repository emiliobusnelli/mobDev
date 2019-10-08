using Xamarin.Forms;
using DistanceConverter.Views;

namespace DistanceConverter
{
    public partial class DistanceConverterPage : ContentPage
    {
        public DistanceConverterPage()
        {
            InitializeComponent();

            Title = "Distanceee Converter";

            ToolbarItem tbi = new ToolbarItem();
            tbi.Text = "About";

            tbi.Clicked += delegate {
                Navigation.PushAsync(new AboutPage());
            };
            this.ToolbarItems.Add(tbi);
        }
    }
}
