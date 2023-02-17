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