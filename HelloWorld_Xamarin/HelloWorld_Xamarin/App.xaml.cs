using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld_Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AbsolutePage();
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
