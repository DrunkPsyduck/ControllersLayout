using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControllersLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TiposAlerta ());
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
