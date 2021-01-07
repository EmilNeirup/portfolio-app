using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using PortfolioApp.iOS;


[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomRender))]

namespace PortfolioApp.iOS
{
    public class CustomRender : NavigationRenderer
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // remove lower border and shadow of the navigation bar
            NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
            NavigationBar.ShadowImage = new UIImage();
        }
    }
}


