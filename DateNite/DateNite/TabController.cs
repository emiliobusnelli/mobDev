using System;
using Xamarin.Forms;
using DateNite.Views;

namespace DateNite
{
    public class TabController : TabbedPage
    {
        public TabController()
        {
            Children.Add(new CoffeePage() { Title = "Coffee", Icon = "coffeetab" });
            Children.Add(new DinnerPage() { Title = "Dinner", Icon = "dinnertab" });
            Children.Add(new MoviePage() { Title = "Movie", Icon = "movietab" });
            Children.Add(new CostPage() { Title = "Cost", Icon = "costtab" });
        }
    }
}