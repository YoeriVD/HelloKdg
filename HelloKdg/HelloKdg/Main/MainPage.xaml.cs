using System.Runtime.InteropServices;
using Xamarin.Forms;

namespace HelloKdg.Main
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MessagingCenter.Subscribe<MainViewModel, string>(this, "DisplayAlert", (sender, args) => DisplayAlert("Alert", args, "Ok"));
        }
        
    }
}