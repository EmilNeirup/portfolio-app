using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PortfolioApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage()) {
                BarBackgroundColor = Color.FromHex("#464F51"),
                BarTextColor = Color.FromHex("#F6E8EA"),
            } ;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
