using System;
using Xamarin.Forms;

namespace CaouselDemo
{
    public partial class CaouselDemoPage : CarouselPage
    {
        public CaouselDemoPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            // this demos the next page
            base.OnAppearing();
            Device.StartTimer(TimeSpan.FromMilliseconds(200), () => {
                this.CurrentPage = this.Children[1];
                return false;
            });
            // This brings you back to main page
            Device.StartTimer(TimeSpan.FromMilliseconds(1000), () => {
                this.CurrentPage = this.Children[0];
                return false;
            });
        }


    }
}
