using System;
using System.Diagnostics;
using System.Windows.Input;
using HelloKdg.NavigateDemo;
using HelloKdg.Navigation;
using HelloKdg.Services;
using Xamarin.Forms;

namespace HelloKdg.Main
{
    public interface IMainViewModel
    {
        string MainText { get; }
        ICommand NavigateToDemo { get; }
    }

    internal class MainViewModel : IMainViewModel
    {
        private readonly IAppNavigation _navigation;
        private readonly IWeatherService _weatherService;

        public Action<string> DisplayAlert { get; set; }

        public MainViewModel(IAppNavigation navigation, IWeatherService weatherService)
        {
            _navigation = navigation;
            _weatherService = weatherService;
        }

        public string MainText => "sup brah!";

        public ICommand NavigateToDemo => new Command(() => _navigation.NavigateTo<DemoPage>());

        public ICommand CallService => new Command(async () =>
        {
            try
            {
                var result = await _weatherService.GetWeatherResultFor(51.2167, 4.4000);
                MessagingCenter.Send(this, "DisplayAlert", $"Temperature: {result?.main?.temp}°C{Environment.NewLine}Windspeed: {result?.wind?.speed}m/s");
            }
            catch (Exception ex)
            {
                MessagingCenter.Send(this, "DisplayAlert", "Oeps, tis kapot!");
            }
        });

    }
}