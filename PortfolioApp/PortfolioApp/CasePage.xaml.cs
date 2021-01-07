using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PortfolioApp
{
    public partial class CasePage : ContentPage
    {
        public CasePage(CaseDetails caseDetails)
        {
            InitializeComponent();

            Title = caseDetails.Title;

            container.BindingContext = caseDetails;
        }

        async void ToMyPage(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
