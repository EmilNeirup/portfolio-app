using System;
using Xamarin.Forms;

namespace PortfolioApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CaseDetails Case1Details = new CaseDetails(
               "CMS",
               "cms.png",
               "cms-logo.png",
               "Creating and updating your website should be the least of your worries. With Umbraco, you get a content management system known and loved for its flexibility and great editing experience. Use the open source version of Umbraco for free and install, setup, and host it yourself or let us take care of it all for you on Umbraco Cloud. You get a free 14-day trial and if you get hooked, prices start from just 225 kr./month.",
               "With Umbraco CMS, you give yourself the freedom to finally express your true self digitally.Your Umbraco Cloud website is up and running in just a few minutes, goes live with new improvements with a single click and because of automatic updates, your website is always updated with the latest bug and security fixes without you lifting a finger.It's not just hours you get back - it's comfort, reassurance and predictability when you need it the most.",
               "Forums",
               "Free",
               "Build in editors",
               "User Groups",
               "check.png",
               "delete.png",
               "check.png",
               "check.png"
             );

            CaseDetails Case2Details = new CaseDetails(
               "Cypress",
                "cypress.png",
                "cypress-logo.png",
                "Until now, end-to-end testing wasn’t easy. It was the part developers hated. Not anymore. Cypress makes setting up, writing, running and debugging tests easy. Most end-to-end testing tools are Selenium-based, which is why they all share the same problems. To make Cypress different, we built a new architecture from the ground up. Whereas Selenium executes remote commands through the network, Cypress runs in the same run-loop as your application.",
                "Cypress is not a general automation framework, nor is it a unit testing framework for your back end services. There are already great tools out there that do that. Rather, we specialize in one thing - creating a great experience while you write end to end tests for your web applications.",
                "Time travel",
                "Real time reloads",
                "Manual Waiting",
                "Selenium",
                "check.png",
                "check.png",
                "delete.png",
                "delete.png"
            );

            CaseDetails Case3Details = new CaseDetails(
               "PWA",
               "pwa.png",
               "react.png",
               "Progressive Web Apps are web apps that use emerging web browser APIs and features along with traditional progressive enhancement strategy to bring a native app-like user experience to cross-platform web applications. Progressive Web Apps are a useful design pattern, though they aren't a formalized standard. WA can be thought of as similar to AJAX or other similar patterns that encompass a set of application attributes",
               "including use of specific web technologies and techniques. React makes it painless to create interactive UIs. Design simple views for each state in your application, and React will efficiently update and render just the right components when your data changes. Declarative views make your code more predictable and easier to debug.",
               "Browser",
               "Mobile Functions",
               "App Store",
               "Offline use",
               "check.png",
               "check.png",
               "delete.png",
               "delete.png"
             );

            CaseDetails Case4Details = new CaseDetails(
               "Native Apps",
               "nativeApps.png",
               "swift.png",
               "wift. Open source-sprog fyldt med power, så alle kan lave fantastiske apps. Swift er et solidt og intuitivt programmeringssprog, som er udviklet af Apple til at lave apps til iOS, Apple TV og Apple Watch samt Mac - programmer.Det er designet, så udviklere får mere frihed end nogensinde.Swift er nemt at bruge og er open source, så alle med en idé kan skabe noget utroligt. Udviklere laver alleredeimponerende ting med Swift.",
               "Swift er et hurtigt og effektivt sprog, som giver feedback i realtid, og det kan uden problemer integreres i eksisterende Objective-C-kode. Så udviklere kan skrive mere sikker og pålidelig kode, spare tid og skabe endnu bedre oplevelser med apps. Flere og flere udviklere integrerer Swift-kode i deres apps og programmer. Og nogle udvikler endda helt nye apps og programmer udelukkende med Swift.",
               "App Store",
               "Offline use",
               "Browser",
               "Mobile Functions",
               "check.png",
               "check.png",
               "delete.png",
               "check.png"
             );

            CMS_Tile.BindingContext = Case1Details;
            Cypress_Tile.BindingContext = Case2Details;
            PWA_Tile.BindingContext = Case3Details;
            Native_Tile.BindingContext = Case4Details;

        }

        async void ToMyPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyPage());
        }

        async void OpenCase(object sender, EventArgs e)
        {
            StackLayout Myframe = sender as StackLayout;

            await Navigation.PushAsync(new CasePage(Myframe.BindingContext as CaseDetails));

        }

    }
}
