using System;
namespace PortfolioApp
{
    public class CaseDetails
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Logo { get; set; }
        public string FirstText { get; set; }
        public string SecondText { get; set; }
        public string Label1 { get; set; }
        public string Label2 { get; set; }
        public string Label3 { get; set; }
        public string Label4 { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }

        public CaseDetails(string title, string image, string logo, string firsttext, string secondtext, string label1, string label2, string label3, string label4, string image1, string image2, string image3, string image4)
        {
            Title = title;
            Image = image;
            Logo = logo;
            FirstText = firsttext;
            SecondText = secondtext;
            Label1 = label1;
            Label2 = label2;
            Label3 = label3;
            Label4 = label4;
            Image1 = image1;
            Image2 = image2;
            Image3 = image3;
            Image4 = image4;
        }
    }
}
