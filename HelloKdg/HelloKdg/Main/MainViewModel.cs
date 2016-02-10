using System.Windows.Input;
using HelloKdg.NavigateDemo;
using HelloKdg.Navigation;
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

        public MainViewModel(IAppNavigation navigation)
        {
            _navigation = navigation;
        }

        public string MainText => "sup brah!";

        public ICommand NavigateToDemo => new Command(() => _navigation.NavigateTo<DemoPage>());
        
    }
}