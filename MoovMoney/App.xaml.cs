using FreshMvvm.Maui;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using MoovMoney.PageModels;

namespace MoovMoney
{
    public partial class App : Microsoft.Maui.Controls.Application
    {
        public App()
        {
            InitializeComponent();

            var container = new FreshTabbedNavigationContainer();
            //var iconHouse = ResourcesUtility.FindResource<string>("IconHouse");
            container.AddTab<HomeTabPageModel>("Home", "home.png");
            container.AddTab<OurPartnersTabPageModel>("Our partners", "moov.png");
            container.AddTab<MyAccountTabPageModel>("My account", "user.png");

            container.BarBackgroundColor = Colors.White;

            container.SelectedTabColor = Color.FromHsv(27,100,94);
            container.UnselectedTabColor = Colors.Black;
            container.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            container.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);

            MainPage = container;
        }
    }
}