using System;
using Xamarin.Forms;
using ADR.Views;
namespace ADR
{
    public class TabController : TabbedPage
    {
        public TabController()
        {
            Children.Add(new LengthPage() { Title = "Footage", IconImageSource = "footagetab"});
            //Children.Add(new StainPage() { Title = "Stain", IconImageSource = "staintab"});
            Children.Add(new EstimationPage() { Title = "Estimation", IconImageSource = "esttab"});
            Children.Add(new EstimateListPage() { Title = "Estimates", IconImageSource = "estimatelisttab" });
        }
    }
}
