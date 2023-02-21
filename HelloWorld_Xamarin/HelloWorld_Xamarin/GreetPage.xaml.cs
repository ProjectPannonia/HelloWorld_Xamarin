using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0.5;

            /* Target device handler - old way
            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);
            else if (Device.OS == TargetPlatform.Android)
                Padding = new Thickness(10, 20, 0, 0);
            else if (Device.OS == TargetPlatform.WinPhone)
                Padding = new Thickness(30, 20, 0, 0);
            */
            /* Target device handler - cleaner way 
            Padding = Device.OnPlatform<Thickness>(
                iOS: new Thickness(0, 20, 0, 0),
                Android: new Thickness(10, 20, 0, 0),
                WinPhone: new Thickness(30, 20, 0, 0)
            );
            */
            /* Target device handler - with lamda expression */
            Device.OnPlatform(
                iOS: () =>
                {
                    Padding = new Thickness(0, 20, 0, 0);
                },
                Android: () =>
                {
                    //...
                });
            //label.Text = String.Format("Value is {0:F2}", slider.Value);
        }

        /*
        void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
        */
    }
}