using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PortfolioApp
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
        }

        async void ToMyPage(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
